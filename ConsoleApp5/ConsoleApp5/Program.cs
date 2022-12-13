using Newtonsoft.Json;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ConsoleApp5
{ 
    class program{

   
    private static string _path = @"C:\Users\olive\OneDrive\Desktop\json\Ganador.json";
static void Main(string[] args)
{
            //var ganador = GetGanadors();
            //serializarJson(ganador);

            var ganador = GetGanadorFromFile();
            DeserializeJsonFile(ganador);
}
        #region "Create"
        public static void serializarJson(List<Ganador> ganador)
        {
             string ganadorJson = JsonConvert.SerializeObject(ganador.ToArray(), Formatting.Indented);
            File.WriteAllText(_path, ganadorJson);
        }
 public static List<Ganador> GetGanadors()
    {
            List<Ganador> ganador = new List<Ganador>{
                new Ganador
                {
                    Name = "Oliver",
                    Categoria = "D"
                } 
            };
                    

 
    return ganador;
      }
        #endregion

        #region "Leer"
        public static string GetGanadorFromFile()
        {
            string GanadorJsonFile;
            using (var read = new StreamReader(_path))
            {
                GanadorJsonFile = read.ReadToEnd();
            }
            return GanadorJsonFile;
    }


        public static void DeserializeJsonFile(string GanadorJsonFile)
        {
            Console.WriteLine(GanadorJsonFile);

            var ganador = JsonConvert.DeserializeObject<List<Ganador>>(GanadorJsonFile);
            Console.WriteLine(string.Format("Ganadores: Nombre {0} Categoria {1}", ganador[0].Name, ganador[0].Categoria));


        }
        #endregion
    }






}