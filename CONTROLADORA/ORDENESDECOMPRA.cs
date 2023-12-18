using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class ORDENESDECOMPRA
    {
        public static ORDENESDECOMPRA instancia;
        public static ORDENESDECOMPRA ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new ORDENESDECOMPRA();
            }
            return instancia;
        }
        DATOS.EMPRESA oEMPRESA;
        private ORDENESDECOMPRA()
        {
            oEMPRESA = DATOS.EMPRESA.ObtenerInstancia();
        }
        #region AMB ORDENES DE COMPRA
        public void AGREGAR_ORDENESDECOMPRAS(MODELO.ORDENDECOMPRA oORDENDECOMPRA)
        {
            oEMPRESA.ORDENESDECOMPRAS.Add(oORDENDECOMPRA);
            oEMPRESA.SaveChanges();
        }
        public void ELIMINAR_ORDENESDECOMPRAS(MODELO.ORDENDECOMPRA oORDENDECOMPRA)
        {
            oEMPRESA.ORDENESDECOMPRAS.Remove(oORDENDECOMPRA);
            oEMPRESA.SaveChanges();
        }
        public void MODIFICAR_ORDENESDECOMPRAS(MODELO.ORDENDECOMPRA oORDENDECOMPRA)
        {
            oEMPRESA.Entry(oORDENDECOMPRA).State = System.Data.Entity.EntityState.Modified;
            oEMPRESA.SaveChanges();
        }
        #endregion
        #region PRODUCTOS
        public List<MODELO.ITEM_OC> LISTAR_PRODUCTO(MODELO.ORDENDECOMPRA oORDENES)
        {
            return oORDENES.ITEMS.ToList();
        }
        #endregion
        #region LISTAR ORDEN DE COMPRA 
        public System.Collections.IEnumerable LISTAR_ORDENDECOMPRA(string proveedor)
        {
            var ORDENES = from ORDEN in oEMPRESA.ORDENESDECOMPRAS.Include("cod_proveedor").ToList()
                          where ORDEN.cod_proveedor.nombre.ToLower().Contains(proveedor.ToLower())//BUSCAR
                          select ORDEN;
            return ORDENES.ToList();

        }
        public System.Collections.IEnumerable LISTAR_ORDENDECOMPRA_ESTADO(string estado)
        {
            var ORDENES = from ORDEN in oEMPRESA.ORDENESDECOMPRAS.Include("cod_proveedor").ToList()
                          where estado == "Todos" ? true : ORDEN.Estado.ToLower().Contains(estado.ToLower())//BUSCAR
                          select new
                          {
                              cod_orden = ORDEN.cod_orden,
                              cod_proveedor = ORDEN.cod_proveedor,
                              fecha = ORDEN.fecha,
                              precio = ORDEN.precio,
                              Estado = ORDEN.Estado
                          };

            return ORDENES.ToList();
        }

        #endregion
        #region OBTENER PROVEEDOR, ITEMS Y BUSCAR PROVEEDOR

        public MODELO.PROVEEDOR BUSCAR_PROVEEDOR(Int32 CODIGO)
        {
            return oEMPRESA.PROVEEDORES.Find(CODIGO);
        }
        public System.Collections.IEnumerable ObtenerItems(MODELO.ORDENDECOMPRA oORDENDECOMPRA) // agrega columnas para mostrarlas en la grilla
        {
            var items = from item in oEMPRESA.ITEMS_OC.Include("Producto").ToList()
                        select item;
            return oEMPRESA.ORDENESDECOMPRAS.Include("ITEMS").FirstOrDefault(v => v.cod_orden == oORDENDECOMPRA.cod_orden).ITEMS.ToList();
        }
        public List<MODELO.PROVEEDOR> obtenerProveedores(bool todos = false)
        {
            List<MODELO.PROVEEDOR> proveedores = oEMPRESA.PROVEEDORES.ToList();
            if (todos)
                proveedores.Add(new MODELO.PROVEEDOR(0, ""));
            return proveedores.ToList();
        }
        #endregion
    }
}
