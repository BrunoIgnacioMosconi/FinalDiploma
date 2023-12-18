using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class VENTA
    {
        public Int32 cod_venta { get; set; }       
        public virtual ICollection<ITEM_VENTA> ITEMS { get; set; }
        public virtual ICollection<PAGO> PAGOS { get; set; }
        
        public EMPLEADO Cod_empleado { get; set; }
        public CLIENTE Cod_cliente { get; set; }
        public DateTime fecha_De_Venta   { get; set; }
        public Int32 Nro_Factura { get; set; }
        public string Tipo_factura { get; set; }      
        public decimal TotalConDescuento { get; set; } 
        public decimal total { get; set; }        
        
       
        
        public string Obtener_Pagos
        {
            get
            {
                string p = "";
                foreach (PAGO oPAGO in this.PAGOS)
                {
                    
                    p +=  oPAGO + " - "; 
                }
                return p;
            }

        }
        public VENTA()
        {
            this.ITEMS = new HashSet<MODELO.ITEM_VENTA>();
            this.PAGOS = new HashSet<MODELO.PAGO>();
        }
      
        
           
        

        public override string ToString()
        {
            return "Nro de factura"+" "+Nro_Factura.ToString()+","+Tipo_factura;     
        }
    }
}
