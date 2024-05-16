using System.Xml.Serialization;

namespace ArchitectureServices.Core
{
    public class XmlRestRelation
    {
        [XmlElement("apisource")]
        public string ApiSource { get; set; }

        [XmlElement("apiconsumer")]
        public string ApiConsumer { get; set; }
    }
}
