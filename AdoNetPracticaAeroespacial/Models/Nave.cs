using System;
using System.Collections.Generic;
using System.Text;

namespace AdoNetPracticaAeroespacial.Models
{
    public class Nave
    {
        public int NaveId { get; set; }
        public string NombreNave { get; set; }
        public string Modelo { get; set; }
        public int CapacidadMax { get; set; }
        public string Estado { get; set; }
    }
}
