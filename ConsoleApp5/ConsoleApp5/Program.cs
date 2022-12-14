using Newtonsoft.Json;

namespace ConsoleApp5
{
    class program
    {
        private static string _path = @"C:\Users\olive\OneDrive\Documents\GitHub\-Console-Screen-Handler\ConsoleApp5\ConsoleApp5\test.json";
        private static string _path2 = @"C:\Users\olive\OneDrive\Documents\GitHub\-Console-Screen-Handler\ConsoleApp5\ConsoleApp5\test2.json";
        static void Main(string[] args)
        {
            //var ganador = GetGanadors();

            var ganador = GetGanadorFromFile();
            DeserializeJsonFile(ganador);
        }


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

        #region "Formulario"
        public static void DeserializeJsonFile(string GanadorJsonFile)
        {
            List<Data> Respuestas = new List<Data>();

            var ganador = JsonConvert.DeserializeObject<Formulario>(GanadorJsonFile);
            foreach (var Pregunta in ganador.Preguntas)
            {
                while (true)
                {
                    Console.WriteLine($"{Pregunta.Texto}");
                    var respuesta = Console.ReadLine();
                    Console.Clear();

                    if (!string.IsNullOrWhiteSpace(respuesta))
                    {
                        Respuestas.Add(new(Pregunta.Texto, respuesta));
                        break;
                    }
                    Console.Clear();
                }

            }
            serializarJson(Respuestas, _path2);
        }
        #endregion


        #region "Data"
        public static void serializarJson(List<Data> data, string path2)
        {
            var x = File.ReadAllText(path2);
            var bk = JsonConvert.DeserializeObject<List<Data>>(x);

            foreach (var b in data)
            {
                bk.Add(b);
            }
            string DataJson = JsonConvert.SerializeObject(bk);
            File.WriteAllText(path2, DataJson);
        }

        #endregion

        public static string buscar()
    }






}
#endregion