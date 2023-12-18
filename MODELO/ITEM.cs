using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
   public abstract class ITEM
    {
        public Int32 cod_item { get; set; }                      
        public PRODUCTO Producto { get; set; }
        //atributo observador que se actualiza con el nuevo estado del producto cuando se activa el update desde el notificar
        //del producto
        public string Observador { get; set; }
        public int cantidad { get; set; }

        //Update
        public void Update()
        {
            Observador = Producto.Estado;
        }
    }

    public class ITEM_VENTA: ITEM
    {
     public VENTA oVenta { get; set; }
     public decimal precio_unitario_venta { get; set; }
     public decimal subtotal_venta { get { return precio_unitario_venta * cantidad; } }
    }

    public class ITEM_OC: ITEM
    {
     public ORDENDECOMPRA oORDEN { get; set; }
     public decimal precio_unitario_compra { get; set; }
     public decimal subtotal_compra { get { return precio_unitario_compra * cantidad; } }
    }

    public class ITEM_REMITO: ITEM
    {
     public REMITO oREMITO { get; set; }
     public decimal precio_unitario_remito { get; set; }
     public decimal subtotal_remito { get { return precio_unitario_remito * cantidad; } }
    }
}
