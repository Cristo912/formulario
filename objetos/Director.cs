using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
    public class Director : Persona, Idirector
    {
        private double año_ingreso { get; set; }
        private double sueldo_pago { get; set; }
        
        public Director(int ci, string nombre, string segundo_nombre, string apellido, string segundo_apellido, string email, int telefono ) : base(ci, nombre, segundo_nombre, apellido, segundo_apellido, email, telefono)
        {

        }
        public double sueldo_TOTAL
        {
            get
            {
                return año_ingreso * sueldo_pago;
            }
        }

    }
    }

