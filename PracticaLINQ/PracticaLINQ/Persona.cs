using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaLINQ
{
    public class Persona
    {
        [DebuggerDisplay("Nombre")]
        public string Nombre { get; set; }
        public int Edad { get; set; }   
        public bool Soltero { get; set; }
        public DateTime FechaNacimiento { get; set; } 
        public DateTime FechaIngresoEmpresa { get; set; }
        public List<string> Telefonos { get; set; } 
        public int IdEmpresa { get; set; }  
    }
}
