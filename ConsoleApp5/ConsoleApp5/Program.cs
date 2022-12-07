using System.Text.Json;
using System.Text.Json.Serialization;

namespace ConsoleApp5
{ 
static void Main(string[] args)
{
    /* hardcode test
    Console.WriteLine("Name");
    string name= Console.ReadLine();

    Console.WriteLine("Edad");
    int edad = int.Parse(Console.ReadLine());
    */
    Persona persona = new Persona();
        string mijson = JsonSerializer.Serialize(persona);

}
}