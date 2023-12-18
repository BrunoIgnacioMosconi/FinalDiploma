using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class REMITOS
    {
        public static REMITOS instancia;
        public static REMITOS ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new REMITOS();
            }
            return instancia;
        }
        DATOS.EMPRESA oEMPRESA;
        private REMITOS()
        {
            oEMPRESA = DATOS.EMPRESA.ObtenerInstancia();
        }
        public void AGREGAR_PRODUCTOSORDENES(MODELO.REMITO oPRODUCTOORDEN)
        {
            oEMPRESA.REMITOs.Add(oPRODUCTOORDEN);
            oEMPRESA.SaveChanges();
        }

        public System.Collections.IEnumerable CalcularItemsFaltantes(MODELO.ORDENDECOMPRA oORDENDECOMPRA)
        {
            var itemsoc = from itemoc in oEMPRESA.ITEMS_OC.Include("producto").ToList()
                          where itemoc.oORDEN == oORDENDECOMPRA
                          select itemoc;

            var remitos = from remito in oEMPRESA.REMITOs.Include("oORDENESDECOMPRA").ToList()
                          where remito.oORDENESDECOMPRA == oORDENDECOMPRA
                          select remito;

            List<MODELO.ITEM_REMITO> items_faltantes = new List<MODELO.ITEM_REMITO>();
            foreach (MODELO.ITEM_OC item in itemsoc.ToList())
            {
                MODELO.ITEM_REMITO oItem = new MODELO.ITEM_REMITO();
                oItem.Producto = item.Producto;
                oItem.cantidad = item.cantidad;
                oItem.precio_unitario_remito = item.precio_unitario_compra;
                items_faltantes.Add(oItem);
            }
            
            foreach (MODELO.REMITO remito in remitos.ToList())
            {
                var itemsrc = from itemrc in oEMPRESA.ITEMS_REMITO.Include("oREMITO").ToList()
                              where itemrc.oREMITO == remito
                              select itemrc;

                foreach (MODELO.ITEM_REMITO item in itemsrc.ToList())
                {
                    MODELO.ITEM_REMITO oItem = items_faltantes.Find(_=>_.Producto == item.Producto);
                    oItem.cantidad -= item.cantidad;
                    if (oItem.cantidad == 0)
                        items_faltantes.Remove(oItem);
                }
            }
            return items_faltantes.ToList();
        }
       
        public System.Collections.IEnumerable ObtenerItems(MODELO.ORDENDECOMPRA oORDENDECOMPRA) 
        {
            var ITEMS = from ITEM in oEMPRESA.ITEMS_OC.Include("Producto").ToList()
                        where ITEM.oORDEN==oORDENDECOMPRA 
                        select ITEM;
                      

            return ITEMS.ToList();
        }
        public System.Collections.IEnumerable ObtenerItems(MODELO.REMITO oREMITO)
        {
            var ITEMS = from ITEM in oEMPRESA.ITEMS_REMITO.Include("Producto").ToList()
                        where ITEM.oREMITO == oREMITO
                        select ITEM;

            return ITEMS.ToList();
        }
        public System.Collections.IEnumerable ObtenerRemitos(DateTime Fecha)
        {
            var remitos = from remito in oEMPRESA.REMITOs.ToList()
                          where Fecha.Date ==Convert.ToDateTime("26/09/2050") ? true: remito.fecha.Date == Fecha.Date
                          select remito;
            return remitos.ToList();

        }
        public void AumentarStock(MODELO.REMITO oREMITO)
        {
            foreach (var item in oREMITO.ITEMS)
            {
                item.Producto.cantidad_Actual += item.cantidad;
                oEMPRESA.SaveChanges();
            }
        }
        public void AGREGAR_ITEMS(MODELO.ITEM_REMITO oITEM)
        {
            oEMPRESA.ITEMS_REMITO.Add(oITEM);
            oEMPRESA.SaveChanges();
        }
    }
}
