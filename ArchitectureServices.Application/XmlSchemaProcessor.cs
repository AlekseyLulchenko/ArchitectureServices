using ArchitectureServices.Core;
using ArchitectureServices.Core.PlantUmlModels;

namespace ArchitectureServices.Application
{
    public class XmlSchemaProcessor
    {
        public PlantUmlDiagramModel BuildPlantUmlModel(RestApiRelationsXmlSchema xmlSchema)
        {

            var APIs = xmlSchema.RestRelations
                .Select(relation => new { relation.ApiSource })
                .Distinct()
                .Select(r => new Application_Interface(serviceName: r.ApiSource, description: r.ApiSource))
                .ToList();

            var APIConsumers = xmlSchema.RestRelations
                .Select(relation => new { relation.ApiConsumer })
                .Distinct()
                .Select(r => new Application_Component(serviceName: r.ApiConsumer, description: r.ApiConsumer))
                .ToList();

            PlantUmlDiagramModel plantUmlDiagramModel = new PlantUmlDiagramModel
            {
                APIs = APIs,
                APIConsumers = APIConsumers
            };

            return plantUmlDiagramModel;
        }
    }
}
