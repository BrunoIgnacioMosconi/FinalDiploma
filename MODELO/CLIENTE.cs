using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class CLIENTE
    {
        public Int32 cod_cliente { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string localidad { get; set; }
        public string direccion { get; set; }
        public Int32 telefono { get; set; }
      

        public CLIENTE(int id, string miNombre)
        {
            cod_cliente = id;
            nombre = miNombre;
        }
        public CLIENTE()
        {
            
        }

        public override string ToString()
        {
            return nombre.ToString();
        }


    }

    
}
