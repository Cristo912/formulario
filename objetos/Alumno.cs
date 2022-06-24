using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
    public class Alumno : Persona 
    {
        private int notas { get; set; }
        private int numero_Lista { get; set; }

        public Alumno(int ci, string nombre, string segundo_nombre, string apellido, string segundo_apellido, string email, int telefono) : base(ci, nombre, segundo_nombre, apellido, segundo_apellido, email, telefono)
        {

        }

        
    }
}
