using System.Collections.Generic;
using System.Xml.Serialization;

namespace IcecatSharp.Models
{
    [XmlRoot(ElementName = "file")]
    public class IceCatFile
    {
        [XmlElement(ElementName = "M_Prod_ID")]
        public M_Prod_ID M_Prod_ID { get; set; }
        [XmlElement(ElementName = "EAN_UPCS")]
        public EAN_UPCS EAN_UPCS { get; set; }
        [XmlElement(ElementName = "Country_Markets")]
        public Country_Markets Country_Markets { get; set; }
        [XmlAttribute(AttributeName = "path")]
        public string Path { get; set; }
        [XmlAttribute(AttributeName = "Product_ID")]
        public int Product_ID { get; set; }
        [XmlAttribute(AttributeName = "Updated")]
        public string Updated { get; set; }
        [XmlAttribute(AttributeName = "Quality")]
        public string Quality { get; set; }
        [XmlAttribute(AttributeName = "Supplier_id")]
        public int Supplier_id { get; set; }
        [XmlAttribute(AttributeName = "Prod_ID")]
        public string Prod_ID { get; set; }
        [XmlAttribute(AttributeName = "Catid")]
        public string Catid { get; set; }
        [XmlAttribute(AttributeName = "On_Market")]
        public bool On_Market { get; set; }
        [XmlAttribute(AttributeName = "Stock")]
        public string Stock { get; set; }
        [XmlAttribute(AttributeName = "Model_Name")]
        public string Model_Name { get; set; }
        [XmlAttribute(AttributeName = "Product_View")]
        public int Product_View { get; set; }
        [XmlAttribute(AttributeName = "HighPic")]
        public string HighPic { get; set; }
    }

    [XmlRoot(ElementName = "M_Prod_ID")]
    public class M_Prod_ID
    {
        [XmlAttribute(AttributeName = "Supplier_id")]
        public string Supplier_id { get; set; }
        [XmlAttribute(AttributeName = "Supplier_name")]
        public string Supplier_name { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "EAN_UPC")]
    public class EAN_UPC
    {
        [XmlAttribute(AttributeName = "Value")]
        public string Value { get; set; }
    }

    [XmlRoot(ElementName = "EAN_UPCS")]
    public class EAN_UPCS
    {
        [XmlElement(ElementName = "EAN_UPC")]
        public List<EAN_UPC> EAN_UPC { get; set; }
    }

    [XmlRoot(ElementName = "Country_Market")]
    public class Country_Market
    {
        [XmlAttribute(AttributeName = "Value")]
        public string Value { get; set; }
    }

    [XmlRoot(ElementName = "Country_Markets")]
    public class Country_Markets
    {
        [XmlElement(ElementName = "Country_Market")]
        public List<Country_Market> Country_Market { get; set; }
    }
}
