namespace ArchitectureServices.Core.PlantUmlModels
{
    public class Application_Interface(string serviceName, string description)
    {
        public string ServiceName => serviceName;
        public string Description => description;
    }
}
