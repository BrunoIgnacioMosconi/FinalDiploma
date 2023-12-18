using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
   public abstract class FORMAS_DE_PAGO
    {
        public Int32 cod_formas_de_pago { get; set; }
        public abstract decimal Calcular_total(decimal total);
        
        public abstract Int32 Cantidad_cuotas();
        public  decimal Calcular_precio_cuota(decimal calcular_total, Int32 cantidad_cuotas)
        {
            decimal total;
            total = calcular_total / cantidad_cuotas;
            return total;
        }
    }
    public class EFECTIVO : FORMAS_DE_PAGO
    {
        
        public  override decimal Calcular_total(decimal total)
        {
            decimal tot = total * (decimal)0.85;
            return tot;
        }
        public  override Int32 Cantidad_cuotas()
        {
            Int32 cant = 1;
            return cant;
        }
       

    }
    public class DEBITO : FORMAS_DE_PAGO
    {
        public override decimal Calcular_total(decimal total)
        {
            
            return total;
        }
        public override Int32 Cantidad_cuotas()
        {
            Int32 cant = 1;
            return cant;
        }
       

    }
    public class CREDITO1 : FORMAS_DE_PAGO
    {
        public override decimal Calcular_total(decimal total)
        {
            
            return total;
        }
        public override Int32 Cantidad_cuotas()
        {
            Int32 cant = 1;
            return cant;
        }
        

    }
    public class CREDITO3 : FORMAS_DE_PAGO
    {
        public override decimal Calcular_total(decimal total)
        {
            total = total * (decimal)1.05;
            return total;
        }
        public override Int32 Cantidad_cuotas()
        {
            Int32 cant = 3;
            return cant;
        }
        

    }
    public class CREDITO12 : FORMAS_DE_PAGO
    {
        public override decimal Calcular_total(decimal total)
        {
            total = total * (decimal)1.30;
            return total;
        }
        public override Int32 Cantidad_cuotas()
        {
            Int32 cant = 12;
            return cant;
        }

        

    }
    public  class CREDITO6 : FORMAS_DE_PAGO
    {
        public override decimal Calcular_total(decimal total)
        {
            total = total * (decimal)1.15;
            return total;
        }
        public override Int32 Cantidad_cuotas()
        {
            Int32 cant = 6;
            return cant;
        }

    }

}
