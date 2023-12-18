using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class ACCION
    {
        public Int32 cod_accion { get; set; }
        public string DESCIPCION_ACCION { get; set; }
        public string CONTROL { get; set; }
        public string FORMULARIO { get; set; }
        public string FORMULARIO_DESCRIPCION { get; set; }
        public string MODULO { get; set; }
        public virtual GRUPO Grupo { get; set; }
    }
}

