using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
    internal class Profesor : Persona ,Idirector
    {
        private string materias { get; set; }
        private string salon { get; set; }

        private double sueldo { get; set; }
        private int año_INGRESO { get; set; }

        public Profesor(int ci, string nombre, string segundo_nombre, string apellido, string segundo_apellido, string email, int telefono) : base(ci, nombre, segundo_nombre, apellido, segundo_apellido, email, telefono)
        {

        }
        public double sueldo_TOTAL
        {
            get 
            {
                return sueldo * año_INGRESO;
                    }
        }
    }
}
