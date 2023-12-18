using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO.MODELO_DE_SEGURIDAD
{
    public class ESTRUCTURA
    {
        [System.AttributeUsage(System.AttributeTargets.Class |
                  System.AttributeTargets.Struct,
                  AllowMultiple = true)
    ]

        public class accion : System.Attribute
        {
            public string DESCRIPCION { get; set; }
            public string CONTROL { get; set; }
            public string FORMULARIO { get; set; }
            public string FORMULARIO_DESCRIPCION { get; set; }
            public string MODULO { get; set; }
        }

        public class formulario : System.Attribute
        {
            public formulario()
            {
                ACCIONES = new List<accion>();
            }
            public string DESCRIPCION { get; set; }
            public string CLASE { get; set; }
            public string MODULO { get; set; }
            public bool MENU { get; set; }
            public bool SEGURIDAD { get; set; }

            public List<accion> ACCIONES { get; set; }
        }
    }
}
