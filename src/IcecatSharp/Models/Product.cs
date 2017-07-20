using System.Collections.Generic;
using System.Xml.Serialization;

namespace IcecatSharp.Models
{
    [XmlRoot(ElementName = "Product")]
    public class IceCatProduct
    {
        [XmlElement(ElementName = "CategoryFeatureGroup")]
        public List<CategoryFeatureGroup> CategoryFeatureGroup { get; set; }
        [XmlElement(ElementName = "Category")]
        public Category Category { get; set; }
        [XmlElement(ElementName = "EANCode")]
        public EANCode EANCode { get; set; }
        [XmlElement(ElementName = "ReasonsToBuy")]
        public string ReasonsToBuy { get; set; }
        [XmlElement(ElementName = "ProductBundled")]
        public string ProductBundled { get; set; }
        [XmlElement(ElementName = "ProductDescription")]
        public List<ProductDescription> ProductDescription { get; set; }
        [XmlElement(ElementName = "ProductFeature")]
        public List<ProductFeature> ProductFeature { get; set; }
        [XmlElement(ElementName = "ProductGallery")]
        public ProductGallery ProductGallery { get; set; }
        [XmlElement(ElementName = "ProductMultimediaObject")]
        public string ProductMultimediaObject { get; set; }
        [XmlElement(ElementName = "ProductRelated")]
        public List<ProductRelated> ProductRelated { get; set; }
        [XmlElement(ElementName = "SummaryDescription")]
        public SummaryDescription SummaryDescription { get; set; }
        [XmlElement(ElementName = "Supplier")]
        public Supplier Supplier { get; set; }
        [XmlAttribute(AttributeName = "Code")]
        public string Code { get; set; }
        [XmlAttribute(AttributeName = "HighPic")]
        public string HighPic { get; set; }
        [XmlAttribute(AttributeName = "HighPicHeight")]
        public string HighPicHeight { get; set; }
        [XmlAttribute(AttributeName = "HighPicSize")]
        public string HighPicSize { get; set; }
        [XmlAttribute(AttributeName = "HighPicWidth")]
        public string HighPicWidth { get; set; }
        [XmlAttribute(AttributeName = "ID")]
        public string ID { get; set; }
        [XmlAttribute(AttributeName = "LowPic")]
        public string LowPic { get; set; }
        [XmlAttribute(AttributeName = "LowPicHeight")]
        public string LowPicHeight { get; set; }
        [XmlAttribute(AttributeName = "LowPicSize")]
        public string LowPicSize { get; set; }
        [XmlAttribute(AttributeName = "LowPicWidth")]
        public string LowPicWidth { get; set; }
        [XmlAttribute(AttributeName = "Name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "Pic500x500")]
        public string Pic500x500 { get; set; }
        [XmlAttribute(AttributeName = "Pic500x500Height")]
        public string Pic500x500Height { get; set; }
        [XmlAttribute(AttributeName = "Pic500x500Size")]
        public string Pic500x500Size { get; set; }
        [XmlAttribute(AttributeName = "Pic500x500Width")]
        public string Pic500x500Width { get; set; }
        [XmlAttribute(AttributeName = "Prod_id")]
        public string Prod_id { get; set; }
        [XmlAttribute(AttributeName = "Quality")]
        public string Quality { get; set; }
        [XmlAttribute(AttributeName = "ReleaseDate")]
        public string ReleaseDate { get; set; }
        [XmlAttribute(AttributeName = "ThumbPic")]
        public string ThumbPic { get; set; }
        [XmlAttribute(AttributeName = "ThumbPicSize")]
        public string ThumbPicSize { get; set; }
        [XmlAttribute(AttributeName = "Title")]
        public string Title { get; set; }
    }

    [XmlRoot(ElementName = "ReasonToBuy")]
    public class ReasonToBuy
    {
        [XmlAttribute(AttributeName = "ID")]
        public string ID { get; set; }
        [XmlAttribute(AttributeName = "Value")]
        public string Value { get; set; }
        [XmlAttribute(AttributeName = "HighPic")]
        public string HighPic { get; set; }
        [XmlAttribute(AttributeName = "HighPicSize")]
        public string HighPicSize { get; set; }
        [XmlAttribute(AttributeName = "No")]
        public string No { get; set; }
        [XmlAttribute(AttributeName = "Title")]
        public string Title { get; set; }
        [XmlAttribute(AttributeName = "langid")]
        public string Langid { get; set; }
    }

    [XmlRoot(ElementName = "Name")]
    public class Name
    {
        [XmlAttribute(AttributeName = "ID")]
        public string ID { get; set; }
        [XmlAttribute(AttributeName = "langid")]
        public string Langid { get; set; }
        [XmlAttribute(AttributeName = "Value")]
        public string Value { get; set; }
    }

    [XmlRoot(ElementName = "FeatureGroup")]
    public class FeatureGroup
    {
        [XmlElement(ElementName = "Name")]
        public List<Name> Name { get; set; }
        [XmlAttribute(AttributeName = "ID")]
        public string ID { get; set; }
    }

    [XmlRoot(ElementName = "CategoryFeatureGroup")]
    public class CategoryFeatureGroup
    {
        [XmlElement(ElementName = "FeatureGroup")]
        public List<FeatureGroup> FeatureGroup { get; set; }
        [XmlAttribute(AttributeName = "ID")]
        public string ID { get; set; }
        [XmlAttribute(AttributeName = "No")]
        public string No { get; set; }
    }

    [XmlRoot(ElementName = "Category")]
    public class Category
    {
        [XmlElement(ElementName = "Name")]
        public List<Name> Name { get; set; }
        [XmlAttribute(AttributeName = "ID")]
        public string ID { get; set; }
    }

    [XmlRoot(ElementName = "EANCode")]
    public class EANCode
    {
        [XmlAttribute(AttributeName = "EAN")]
        public string EAN { get; set; }
    }

    [XmlRoot(ElementName = "ProductDescription")]
    public class ProductDescription
    {
        [XmlAttribute(AttributeName = "ID")]
        public string ID { get; set; }
        [XmlAttribute(AttributeName = "LongDesc")]
        public string LongDesc { get; set; }
        [XmlAttribute(AttributeName = "ManualPDFSize")]
        public string ManualPDFSize { get; set; }
        [XmlAttribute(AttributeName = "ManualPDFURL")]
        public string ManualPDFURL { get; set; }
        [XmlAttribute(AttributeName = "PDFSize")]
        public string PDFSize { get; set; }
        [XmlAttribute(AttributeName = "PDFURL")]
        public string PDFURL { get; set; }
        [XmlAttribute(AttributeName = "ShortDesc")]
        public string ShortDesc { get; set; }
        [XmlAttribute(AttributeName = "URL")]
        public string URL { get; set; }
        [XmlAttribute(AttributeName = "WarrantyInfo")]
        public string WarrantyInfo { get; set; }
        [XmlAttribute(AttributeName = "langid")]
        public string Langid { get; set; }
    }

    [XmlRoot(ElementName = "Sign")]
    public class Sign
    {
        [XmlAttribute(AttributeName = "ID")]
        public string ID { get; set; }
        [XmlAttribute(AttributeName = "langid")]
        public string Langid { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "Signs")]
    public class Signs
    {
        [XmlElement(ElementName = "Sign")]
        public List<Sign> Sign { get; set; }
    }

    [XmlRoot(ElementName = "Measure")]
    public class Measure
    {
        [XmlElement(ElementName = "Signs")]
        public Signs Signs { get; set; }
        [XmlAttribute(AttributeName = "ID")]
        public string ID { get; set; }
        [XmlAttribute(AttributeName = "Sign")]
        public string Sign { get; set; }
    }

    [XmlRoot(ElementName = "LocalValue")]
    public class LocalValue
    {
        [XmlElement(ElementName = "Measure")]
        public Measure Measure { get; set; }
        [XmlAttribute(AttributeName = "Value")]
        public string Value { get; set; }
    }

    [XmlRoot(ElementName = "Feature")]
    public class Feature
    {
        [XmlElement(ElementName = "Measure")]
        public Measure Measure { get; set; }
        [XmlElement(ElementName = "Name")]
        public List<Name> Name { get; set; }
        [XmlAttribute(AttributeName = "ID")]
        public string ID { get; set; }
    }

    [XmlRoot(ElementName = "ProductFeature")]
    public class ProductFeature
    {
        [XmlElement(ElementName = "LocalValue")]
        public LocalValue LocalValue { get; set; }
        [XmlElement(ElementName = "Feature")]
        public List<Feature> Feature { get; set; }
        [XmlAttribute(AttributeName = "Localized")]
        public string Localized { get; set; }
        [XmlAttribute(AttributeName = "ID")]
        public string ID { get; set; }
        [XmlAttribute(AttributeName = "Local_ID")]
        public string Local_ID { get; set; }
        [XmlAttribute(AttributeName = "Value")]
        public string Value { get; set; }
        [XmlAttribute(AttributeName = "CategoryFeature_ID")]
        public string CategoryFeature_ID { get; set; }
        [XmlAttribute(AttributeName = "CategoryFeatureGroup_ID")]
        public string CategoryFeatureGroup_ID { get; set; }
        [XmlAttribute(AttributeName = "No")]
        public string No { get; set; }
        [XmlAttribute(AttributeName = "Presentation_Value")]
        public string Presentation_Value { get; set; }
        [XmlAttribute(AttributeName = "Translated")]
        public string Translated { get; set; }
        [XmlAttribute(AttributeName = "Mandatory")]
        public string Mandatory { get; set; }
        [XmlAttribute(AttributeName = "Searchable")]
        public string Searchable { get; set; }
    }

    [XmlRoot(ElementName = "ProductPicture")]
    public class ProductPicture
    {
        [XmlAttribute(AttributeName = "IsMain")]
        public string IsMain { get; set; }
        [XmlAttribute(AttributeName = "LowPic")]
        public string LowPic { get; set; }
        [XmlAttribute(AttributeName = "LowPicHeight")]
        public string LowPicHeight { get; set; }
        [XmlAttribute(AttributeName = "LowPicWidth")]
        public string LowPicWidth { get; set; }
        [XmlAttribute(AttributeName = "LowSize")]
        public string LowSize { get; set; }
        [XmlAttribute(AttributeName = "No")]
        public string No { get; set; }
        [XmlAttribute(AttributeName = "Original")]
        public string Original { get; set; }
        [XmlAttribute(AttributeName = "OriginalSize")]
        public string OriginalSize { get; set; }
        [XmlAttribute(AttributeName = "Pic")]
        public string Pic { get; set; }
        [XmlAttribute(AttributeName = "Pic500x500")]
        public string Pic500x500 { get; set; }
        [XmlAttribute(AttributeName = "Pic500x500Height")]
        public string Pic500x500Height { get; set; }
        [XmlAttribute(AttributeName = "Pic500x500Size")]
        public string Pic500x500Size { get; set; }
        [XmlAttribute(AttributeName = "Pic500x500Width")]
        public string Pic500x500Width { get; set; }
        [XmlAttribute(AttributeName = "PicHeight")]
        public string PicHeight { get; set; }
        [XmlAttribute(AttributeName = "PicWidth")]
        public string PicWidth { get; set; }
        [XmlAttribute(AttributeName = "ProductPicture_ID")]
        public string ProductPicture_ID { get; set; }
        [XmlAttribute(AttributeName = "Size")]
        public string Size { get; set; }
        [XmlAttribute(AttributeName = "ThumbPic")]
        public string ThumbPic { get; set; }
        [XmlAttribute(AttributeName = "ThumbSize")]
        public string ThumbSize { get; set; }
    }

    [XmlRoot(ElementName = "ProductGallery")]
    public class ProductGallery
    {
        [XmlElement(ElementName = "ProductPicture")]
        public ProductPicture ProductPicture { get; set; }
    }

    [XmlRoot(ElementName = "Supplier")]
    public class Supplier
    {
        [XmlAttribute(AttributeName = "ID")]
        public string ID { get; set; }
        [XmlAttribute(AttributeName = "Name")]
        public string Name { get; set; }
    }

    [XmlRoot(ElementName = "ProductRelatedItem")]
    public class ProductRelatedItem
    {
        [XmlElement(ElementName = "Supplier")]
        public Supplier Supplier { get; set; }
        [XmlAttribute(AttributeName = "ID")]
        public string ID { get; set; }
        [XmlAttribute(AttributeName = "Prod_id")]
        public string Prod_id { get; set; }
        [XmlAttribute(AttributeName = "ThumbPic")]
        public string ThumbPic { get; set; }
        [XmlAttribute(AttributeName = "Name")]
        public string Name { get; set; }
    }

    [XmlRoot(ElementName = "ProductRelated")]
    public class ProductRelated
    {
        [XmlElement(ElementName = "Product")]
        public ProductRelatedItem ProductRelatedItem { get; set; }
        [XmlAttribute(AttributeName = "ID")]
        public string ID { get; set; }
        [XmlAttribute(AttributeName = "Category_ID")]
        public string Category_ID { get; set; }
        [XmlAttribute(AttributeName = "Reversed")]
        public string Reversed { get; set; }
        [XmlAttribute(AttributeName = "Preferred")]
        public string Preferred { get; set; }
        [XmlAttribute(AttributeName = "Order")]
        public string Order { get; set; }
    }

    [XmlRoot(ElementName = "SummaryDescription")]
    public class SummaryDescription
    {
        [XmlElement(ElementName = "ShortSummaryDescription")]
        public string ShortSummaryDescription { get; set; }
        [XmlElement(ElementName = "LongSummaryDescription")]
        public string LongSummaryDescription { get; set; }
    }
}
