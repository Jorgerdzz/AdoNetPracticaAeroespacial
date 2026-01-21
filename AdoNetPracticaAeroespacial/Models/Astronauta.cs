using System;
using System.Collections.Generic;
using System.Text;

namespace AdoNetPracticaAeroespacial.Models
{
    public class Astronauta
    {
        public int AstronautaId { get; set; }
        public string Apellido { get; set; }
        public string Rango { get; set; }
        public string FechaIngreso { get; set; }
        public int Salario { get; set; }
        public int Bono { get; set; }
        public int NaveId { get; set; }
    }
}
