using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class AUDITORIA_PRODUCTO
    {

        public Int32 cod_auditoriaP { get; set; }
        public Int32 cod_proveedor { get; set; }
        public string descripcion { get; set; }
        public string talle { get; set; }
        public string Marca { get; set; }
        public decimal precio_unitario { get; set; }
        public string tipo_producto { get; set; }
        public string color { get; set; }
        
        public string cod_barra { get; set; }
        
        public MODELO.USUARIO USUARIO { get; set; }
        public DateTime fecha_hora { get; set; }
        public string movimiento { get; set; }
    }
}
