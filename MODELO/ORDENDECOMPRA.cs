using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class ORDENDECOMPRA
    {
        public Int32 cod_orden { get; set; }        
        public PROVEEDOR cod_proveedor { get; set; }
        public virtual ICollection<REMITO> REMITOS { get; set; }
        public virtual ICollection<ITEM_OC> ITEMS { get; set; }      
        public DateTime fecha { get; set; }      
        public decimal precio { get; set; }
        public string Estado { get; set; }

        public ORDENDECOMPRA()
        {
            this.ITEMS = new HashSet<ITEM_OC>();
            this.REMITOS = new HashSet<REMITO>();
        }
        public override string ToString()
        {
            return cod_orden.ToString();
        }



    }
}
