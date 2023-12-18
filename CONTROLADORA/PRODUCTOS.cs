using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
   public class PRODUCTOS
    {
        public static PRODUCTOS instancia;
        public static PRODUCTOS ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new PRODUCTOS();
            }
            return instancia;
        }
        DATOS.EMPRESA oEMPRESA;
        private PRODUCTOS()
        {
            oEMPRESA = DATOS.EMPRESA.ObtenerInstancia();
        }
        #region OBTENER PROVEEDEORES
        public List<MODELO.PROVEEDOR> obtenerProveedores(bool todos = false)
        {
            List<MODELO.PROVEEDOR> proveedores = oEMPRESA.PROVEEDORES.ToList();
            if (todos)
                proveedores.Add(new MODELO.PROVEEDOR(0, ""));
            return proveedores.ToList();
        }
        #endregion
        #region AGREGAR. MODIFICAR Y LISTAR PRODUCTOS
        public void AGREGAR_PRODUCTOS(MODELO.PRODUCTO oPRODUCTO)
        {
            oEMPRESA.PRODUCTOS.Add(oPRODUCTO);
            oEMPRESA.SaveChanges();
        }
        public void MODIFICAR_PRODUCTOS(MODELO.PRODUCTO oPRODUCTO)
        {
            oEMPRESA.Entry(oPRODUCTO).State = System.Data.Entity.EntityState.Modified;
            oEMPRESA.SaveChanges();
        }
        public List<MODELO.PRODUCTO> LISTAR_PRODUCTOS(string codigo)
        {
            var productos = from producto in oEMPRESA.PRODUCTOS.ToList()
                            where producto.cod_barra.ToLower().Contains(codigo.ToLower())//BUSCAR
                            select producto;
            return productos.ToList();
        }
        #endregion
        #region BUSCAR PRODUCTO
        public MODELO.PRODUCTO BUSCAR_PRODUCTO(Int32 CODIGO)
        {
            return oEMPRESA.PRODUCTOS.Find(CODIGO);
        }
        #endregion
        #region AUDITORIA
        public void AGREGAR_AUDITORIA_PRODUCTOS(MODELO.AUDITORIA_PRODUCTO oPRODUCTO_AUDITORIA)
        {
            oEMPRESA.AUDITORIAS_PROCUTO.Add(oPRODUCTO_AUDITORIA);
            oEMPRESA.SaveChanges();
        }
        #endregion

        public bool VALIDAR_PRODUCTO_EXISTENTE(string codbarra)
        {
            if (oEMPRESA.PRODUCTOS.Any(_ => _.cod_barra == codbarra))
            {
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}
