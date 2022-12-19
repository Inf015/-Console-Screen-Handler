using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Formulario
    {
        public int ID{ get; set; }
        public string Titulo {get; set; }
        public List<Pregunta> Preguntas {get; set; }
    }
}

public class Pregunta
{
    public string Texto { get; set; }
    public bool Requerido { get; set; }
}
