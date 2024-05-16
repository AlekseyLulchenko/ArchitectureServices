// See https://aka.ms/new-console-template for more information
using ArchitectureServices.Application;

string filename = "";
Console.WriteLine("Полное имя файла: ");
filename = Console.ReadLine();

PlantUmlSchemaService schemaService = new PlantUmlSchemaService();
schemaService.CreateFromFile(filename);

Console.WriteLine("Hello, World!");
