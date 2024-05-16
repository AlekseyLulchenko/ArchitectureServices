
using ArchitectureServices.Core;
using ArchitectureServices.Core.PlantUmlModels;

namespace ArchitectureServices.Application
{
    public class PlantUmlSchemaService
    {
        public void CreateFromFile(string filename)
        {
            XMLLoader loader = new XMLLoader();

            RestApiRelationsXmlSchema doc = loader.LoadDocument("d:\\Projects\\Platform Services\\ArchitectureServices\\Payload\\test1.xml");
            XmlSchemaProcessor xmlSchemaProcessor = new XmlSchemaProcessor();
            
            PlantUmlDiagramModel plantUmlDiagramModel = xmlSchemaProcessor.BuildPlantUmlModel(doc);

        }
    }
}
