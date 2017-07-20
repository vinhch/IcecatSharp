using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace IcecatSharp.Infrastructure
{
    public static class CustomXmlParser
    {
        public static readonly XmlReaderSettings CustomXmlReaderSetting = new XmlReaderSettings
        {
            DtdProcessing = (DtdProcessing)2, //TODO: change to DtdProcessing.Parse
            MaxCharactersFromEntities = 10240
        };

        public static async Task<string> Parse(string nodeName, string xmlString)
        {
            using (var stringReader = new StringReader(xmlString))
            using (var xmlReader = XmlReader.Create(stringReader, CustomXmlReaderSetting))
            {
                if (xmlReader.ReadToFollowing(nodeName))
                {
                    return await xmlReader.ReadOuterXmlAsync();
                }
            }
            throw new Exception($"Can not find Xml node {nodeName}");
        }

        private static T ParseReader<T>(XmlReader xmlReader, string nodeName)
        {
            var objectSerializer = new XmlSerializer(typeof(T));
            if (string.IsNullOrEmpty(nodeName))
            {
                return (T)objectSerializer.Deserialize(xmlReader);
            }
            else if (xmlReader.ReadToFollowing(nodeName))
            {
                return (T)objectSerializer.Deserialize(xmlReader.ReadSubtree());
            }
            xmlReader.Dispose(); //TODO: change to xmlReader.Close()
            throw new Exception($"Can not parse Xml to {typeof(T).Name} object");
        }

        public static T Parse<T>(string xmlString, string nodeName = null)
        {
            using (var stringReader = new StringReader(xmlString))
            using (var xmlReader = XmlReader.Create(stringReader, CustomXmlReaderSetting))
            {
                return ParseReader<T>(xmlReader, nodeName);
            }
            throw new Exception($"Can not parse Xml to {typeof(T).Name} object");
        }

        public static T ParseFile<T>(string fileName, string nodeName = null)
        {
            using (var xmlReader = XmlReader.Create(fileName, CustomXmlReaderSetting))
            {
                return ParseReader<T>(xmlReader, nodeName);
            }
            throw new Exception($"Can not parse Xml to {typeof(T).Name} object");
        }

        public static IEnumerable<T> ParseToList<T>(string xmlString, string itemNodeName)
        {
            using (var stringReader = new StringReader(xmlString))
            using (var xmlReader = XmlReader.Create(stringReader, CustomXmlReaderSetting))
            {
                if (string.IsNullOrEmpty(itemNodeName))
                {
                    var objectSerializer = new XmlSerializer(typeof(IEnumerable<T>));
                    var list = (IEnumerable<T>)objectSerializer.Deserialize(xmlReader);
                    foreach (var item in list)
                    {
                        yield return item;
                    }
                }
                else
                {
                    var objectSerializer = new XmlSerializer(typeof(T));
                    while (xmlReader.ReadToFollowing(itemNodeName))
                    {
                        var itemObject = (T)objectSerializer.Deserialize(xmlReader.ReadSubtree());
                        yield return itemObject;
                    }
                }
            }
        }

        public static IEnumerable<T> ParseFileToList<T>(string fileName, string itemNodeName, string itemElementName = null)
        {
            using (var xmlReader = XmlReader.Create(fileName, CustomXmlReaderSetting))
            {
                if (string.IsNullOrEmpty(itemNodeName))
                {
                    var objectSerializer = string.IsNullOrEmpty(itemElementName)
                        ? new XmlSerializer(typeof(IEnumerable<T>))
                        : new XmlSerializer(typeof(IEnumerable<T>), new XmlRootAttribute(itemElementName));

                    var list = (IEnumerable<T>)objectSerializer.Deserialize(xmlReader);
                    foreach (var item in list)
                    {
                        yield return item;
                    }
                }
                else
                {
                    var objectSerializer = string.IsNullOrEmpty(itemElementName)
                        ? new XmlSerializer(typeof(T))
                        : new XmlSerializer(typeof(T), new XmlRootAttribute(itemElementName));

                    while (xmlReader.ReadToFollowing(itemNodeName))
                    {
                        var itemObject = (T)objectSerializer.Deserialize(xmlReader.ReadSubtree());
                        yield return itemObject;
                    }
                }
            }
        }
    }
}
