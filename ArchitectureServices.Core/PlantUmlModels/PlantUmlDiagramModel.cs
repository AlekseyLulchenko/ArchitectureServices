namespace ArchitectureServices.Core.PlantUmlModels
{
    public class PlantUmlDiagramModel
    {
        public List<Application_Interface> APIs { get; set; }
        public List<Application_Component> APIConsumers { get; set; }
        public List<Rel_Flow> Relation_Flows { get; set; }

    }
}
