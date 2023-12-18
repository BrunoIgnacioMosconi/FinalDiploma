using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class PRODUCTO
    {
        
        public Int32 cod_producto { get; set; }       
        public Int32 cod_proveedor { get; set; }
        public string descripcion { get; set; }
        public string talle { get; set; }
        public string Marca { get; set; }
        public decimal precio_unitario { get; set; }
        public string tipo_producto { get; set; }
        public string color { get; set; }
        public Int32 cantidad_Actual { get; set; }
        public string cod_barra { get; set; }
        public string Estado { get { return CambiarEstado(); } }
        public Int32 cantStock { get; set; }
        //se le agrega un item cada vez que lo creamos ya que a item le ponemos la referencia del producto por eso
        //no pusimos el atach, detach
        public virtual ICollection<ITEM> ITEMs { get; set; }

        public string  CambiarEstado()
        {
            string estado;

            if (cantidad_Actual == 0)
            {
                estado = "Sin stock";
            }
            else if(cantidad_Actual > 0 && cantidad_Actual <= cantStock)
            {
                estado = "Stock minimo";
            }
            else
            {
                estado = "Stock suficiente";
            }
            return estado;
        }
        //Notify para avisar cuando cambia el estado del stock
        public void Notificar()
        {
            foreach (MODELO.ITEM oITEM in this.ITEMs )
            {
                oITEM.Update();
            }
        }
        public PRODUCTO()
        {
            this.ITEMs= new HashSet<ITEM>();           
        }

        public PRODUCTO(int id, string miDescripcion)
        {
            cod_producto = id;
            descripcion = miDescripcion;
        }
        
        public override string ToString()
        {
            return descripcion.ToString() +" "+ tipo_producto.ToString() + " " + Marca.ToString();          
        }
    }
}
