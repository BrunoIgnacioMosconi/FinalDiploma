using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class EMPLEADO
    {
        public Int32 cod_empleado { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public Int32 dni { get; set; }
        public string direccion { get; set; }
        public Int32 telefono { get; set; }


        public EMPLEADO(int id, string miNombre)
        {
            cod_empleado = id;
            nombre = miNombre;
        }

        public EMPLEADO()
        {
        }

        public override string ToString()
        {
            return nombre.ToString();
        }
    }
}
