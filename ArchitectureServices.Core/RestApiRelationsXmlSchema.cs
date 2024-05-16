using System.Xml.Serialization;

namespace ArchitectureServices.Core
{
    [XmlRoot("RestApiRelationsXmlSchema")]
    public class RestApiRelationsXmlSchema
    {
        [XmlArray("data")]
        [XmlArrayItem("DATA_RECORD")]
        public List<XmlRestRelation> RestRelations { get; set; }
    }
}
