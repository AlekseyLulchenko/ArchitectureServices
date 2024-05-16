using ArchitectureServices.Core;
using System.Xml.Serialization;

namespace ArchitectureServices.Application
{
    public class XMLLoader
    {
        public RestApiRelationsXmlSchema LoadDocument(string fileName)
        {
            if (!Path.Exists(fileName))
            {
                throw new FileNotFoundException("Указанный файл не найден.");
            }

            var serializer = new XmlSerializer(typeof(RestApiRelationsXmlSchema));
            RestApiRelationsXmlSchema? restApiRelationsXmlSchema;
            using (StreamReader reader = new StreamReader(fileName))
            {
                restApiRelationsXmlSchema = (RestApiRelationsXmlSchema)serializer.Deserialize(reader);
            }

            return restApiRelationsXmlSchema;
        }
    }
}
