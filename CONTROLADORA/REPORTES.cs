using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class REPORTES
    {
        public static REPORTES instancia;
        public static REPORTES ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new REPORTES();
            }
            return instancia;
        }
        DATOS.EMPRESA oEMPRESA;
        private REPORTES()
        {
            oEMPRESA = DATOS.EMPRESA.ObtenerInstancia();
        }
        public System.Collections.IEnumerable LISTAR_CLIENTES(DateTime fi, DateTime ff)
        {
            var ventas = from venta in oEMPRESA.VENTAS.Include("Cod_cliente").ToList()
                         where venta.fecha_De_Venta.Date <= ff.Date && venta.fecha_De_Venta.Date >= fi.Date
                         select new { cod_venta = venta.cod_venta, Cod_cliente = venta.Cod_cliente, Total = venta.total };

            return ventas.ToList();
        }
        public System.Collections.IEnumerable LISTAR_PRODUCTOS(DateTime fi, DateTime ff)
        {
            var ventas = from venta in oEMPRESA.VENTAS.Include("ITEMS").ToList()                      
                         where venta.fecha_De_Venta.Date <= ff.Date && venta.fecha_De_Venta.Date >= fi.Date
                         select venta;

            List<MODELO.ITEM_VENTA> item_venta = new List<MODELO.ITEM_VENTA>();

            foreach (MODELO.VENTA oVENTA  in ventas.ToList())
            {
                var items = from item in oEMPRESA.ITEMS_VENTA.Include("Producto").Include("oVenta").ToList()
                            where item.oVenta == oVENTA
                            select item;

                foreach (MODELO.ITEM_VENTA oITEM in items.ToList())
                {
                    item_venta.Add(oITEM);
                }
            }
            return item_venta.ToList();
        }
        public System.Collections.IEnumerable LISTAR_PROVEEDORES(DateTime fi, DateTime ff)
        {
            var ordenes = from orden in oEMPRESA.ORDENESDECOMPRAS.Include("cod_proveedor").ToList()
                         where orden.fecha.Date <= ff.Date && orden.fecha.Date >= fi.Date
                         select new { cod_orden = orden.cod_orden, cod_proveedor = orden.cod_proveedor, Total = orden.precio };

            return ordenes.ToList();
        }
        public System.Collections.IEnumerable LISTAR_EMPLEADOS(DateTime fi, DateTime ff)
        {
            var ventas = from venta in oEMPRESA.VENTAS.Include("Cod_empleado").ToList()
                         where venta.fecha_De_Venta.Date <= ff.Date && venta.fecha_De_Venta.Date >= fi.Date
                         select new { cod_venta = venta.cod_venta, Cod_empleado = venta.Cod_empleado, Total = venta.total };

            return ventas.ToList();
        }
    }
}
