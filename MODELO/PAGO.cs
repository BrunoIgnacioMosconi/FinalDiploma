using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
   public class PAGO
    {
        
        public Int32 cod_pago { get; set; }
        public FORMAS_DE_PAGO Formas_de_pago  {get;set;}
        public VENTA oVenta { get; set; }
        public Int32 Cantidad_De_cuotas { get; set; }
        public decimal Precio_de_cuota { get; set; }
        public decimal Total { get; set; }
        public decimal Monto_seleccionado { get; set; }

 
       

      public override string ToString()
        {
            string F;
            switch (Formas_de_pago.GetType().ToString())
            {
                case "MODELO.EFECTIVO":
                    F = "EFECTIVO";

                    break;

                case "MODELO.CREDITO3":
                    F = "CREDITO 3 CUOTAS";

                    break;
                case "MODELO.DEBITO":
                    F = "DEBITO";

                    break;

                case "MODELO.CREDITO6":
                    F = "CREDITO 6 CUOTAS";

                    break;
                case "MODELO.CREDITO12":
                    F = "CREDITO 12 CUOTAS";

                    break;
                case "MODELO.CREDITO1":
                    F = "CREDITO 1 CUOTAS";

                    break;

                default: F = "";
                    break;
            }
            return F.ToString() + " " + Total.ToString();
        }
    }
}
