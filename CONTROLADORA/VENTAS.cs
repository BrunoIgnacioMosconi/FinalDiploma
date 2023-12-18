using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class VENTAS
    {
        public static VENTAS instancia;
        public static VENTAS ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new VENTAS();
            }
            return instancia;
        }
        DATOS.EMPRESA oEMPRESA;
        private VENTAS()
        {
            oEMPRESA = DATOS.EMPRESA.ObtenerInstancia();
        }
        #region PAGOS
        public System.Collections.IEnumerable LISTAR_PAGO_FACTURA(MODELO.VENTA oVENTA)
        {
            var pagos = from pago in oEMPRESA.PAGOS.Include("oVenta").Include("Formas_de_pago").ToList()
                        where pago.oVenta.cod_venta == oVENTA.cod_venta
                        select pago;

            return pagos.ToList();
        }
        public System.Collections.IEnumerable LISTAR_PAGOS(MODELO.VENTA oVENTA)
        {
            var pagos = from pago in oEMPRESA.PAGOS.Include("oVenta").Include("Formas_de_pago").ToList()
                        where pago.oVenta == null ? false : pago.oVenta.cod_venta == oVENTA.cod_venta
                        select new { Codigo = pago.cod_pago, FormaPago = pago.ToString(), MontoSeleccionado = pago.Monto_seleccionado, Total = pago.Total, PrecioCuota = pago.Precio_de_cuota, CantidadCuotas = pago.Cantidad_De_cuotas };

            return pagos.ToList();
        }
        public void ELIMINAR_PAGOS(MODELO.PAGO oPAGO)
        {
            oEMPRESA.PAGOS.Remove(oPAGO);
            oEMPRESA.SaveChanges();
        }
        public void AGREGAR_PAGOS(MODELO.PAGO oPAGO)
        {
            oEMPRESA.PAGOS.Add(oPAGO);
            oEMPRESA.SaveChanges();
        }
        #endregion
        #region LISTAR  PRODUCTOS     
      
        public System.Collections.IEnumerable LISTAR_PRODUCTO(MODELO.VENTA oVENTA)
        {
            var items = from item in oEMPRESA.ITEMS_VENTA.Include("Producto").Include("oVenta").ToList()
                        where item.oVenta == oVENTA
                        select item;
            
            return items.ToList();
        }
        #endregion
        #region METODO PARA CALCULAR NUMERO DE FACTURA
        public int ObtenerFactura()
        {
            Int32 nro = 1;
            foreach (var venta in oEMPRESA.VENTAS)
            {
                if (venta.Nro_Factura > nro)
                {
                    nro = venta.Nro_Factura;
                }
            }
            return (nro + 1);
        }
        #endregion
        #region OBTENER  EMPLEADOS, CLIENTES
        public List<MODELO.EMPLEADO> ObtenerEmpleado(bool todos = false)
        {
            List<MODELO.EMPLEADO> empleado = oEMPRESA.EMPLEADOS.ToList();
            if (todos)
                empleado.Add(new MODELO.EMPLEADO(0, ""));
            return empleado.ToList();
        }
        public List<MODELO.CLIENTE> ObtenerCliente(bool todos = false)
        {
            List<MODELO.CLIENTE> cliente = oEMPRESA.CLIENTES.ToList();
            if (todos)
                cliente.Add(new MODELO.CLIENTE(0, ""));
            return cliente.ToList();
        }
        #endregion
        #region VENTA
        public void AGREGAR_VENTAS(MODELO.VENTA oVENTA)
        {
            oEMPRESA.VENTAS.Add(oVENTA);
            oEMPRESA.SaveChanges();
        }
        public MODELO.VENTA ObtenerVenta(Int32 codigo)
        {
            return oEMPRESA.VENTAS.Find(codigo);
        }
        public System.Collections.IEnumerable LISTAR_VENTAS(DateTime Fecha)
        {
            var ventas = (from venta in oEMPRESA.VENTAS.Include("Cod_empleado").Include("PAGOS").Include("Cod_cliente").ToList()
                          from pago in oEMPRESA.PAGOS.Include("Formas_de_pago").ToList()
                          where Fecha.Date == Convert.ToDateTime("10/10/2050") ? true : Fecha.ToShortDateString() == venta.fecha_De_Venta.ToShortDateString()
                          select new { cod_venta = venta.cod_venta, Numero_de_factura = venta.Nro_Factura, Empleado = venta.Cod_empleado, Pagos = venta.Obtener_Pagos, Fecha = venta.fecha_De_Venta, Total = venta.total,TotalConDescuento = venta.TotalConDescuento, Cliente = venta.Cod_cliente })
                         .Distinct();


            return ventas.ToList();
        }
        #endregion
        #region AGREGAR LOS ITEMS Y LAS VENTAS Y DESCONTAR LAS UNIDADES DE STOCK SI SE REALIZA UNA VENTA
        public void AGREGAR_ITEMS(MODELO.ITEM_VENTA oITEM)
        {
            oEMPRESA.ITEMS_VENTA.Add(oITEM);
            oEMPRESA.SaveChanges();
        }
      
        public void DescontarUnidadesStock(MODELO.VENTA oVENTA)
        {
            foreach (var item in oVENTA.ITEMS)
            {
                item.Producto.cantidad_Actual -= item.cantidad;
                oEMPRESA.SaveChanges();
            }

        }  
        #endregion
    }
}
