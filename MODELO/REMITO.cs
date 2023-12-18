using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class REMITO
    {
        public Int32 cod_remito { get; set; }
        public DateTime fecha { get; set; }
        public ORDENDECOMPRA oORDENESDECOMPRA { get; set; }
        public virtual List<ITEM_REMITO> ITEMS { get; set; }
        public decimal total { get; set; }

        public REMITO()
        {
            this.ITEMS = new List<MODELO.ITEM_REMITO>();

        }
    }
}
