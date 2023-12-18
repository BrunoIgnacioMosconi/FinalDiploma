using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
   public  class PROVEEDOR
    {


        public Int32 cod_proveedor { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string direccion { get; set; }
        public string localidad { get; set; }
       
        public string email { get; set; }
        public Int32 telefono { get; set; }

        public PROVEEDOR(int id, string miNombre)
        {
            cod_proveedor = id;
            nombre = miNombre;
        }

        public PROVEEDOR()
        {
        }
        public override string ToString()
        {
            return nombre.ToString();
        }

    }
}
