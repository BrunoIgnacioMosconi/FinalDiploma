using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class PROVEEDORES
    {
        public static PROVEEDORES instancia;
        public static PROVEEDORES ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new PROVEEDORES();
            }
            return instancia;
        }
        DATOS.EMPRESA oEMPRESA;
        private PROVEEDORES()
        {
            oEMPRESA = DATOS.EMPRESA.ObtenerInstancia();
        }
        public void AGREGAR_PROVEEDORES(MODELO.PROVEEDOR oPROVEEDOR)
        {
            oEMPRESA.PROVEEDORES.Add(oPROVEEDOR);
            oEMPRESA.SaveChanges();
        }
        public void ELIMINAR_PROVEEDORES(MODELO.PROVEEDOR oPROVEEDOR)
        {
            oEMPRESA.PROVEEDORES.Remove(oPROVEEDOR);
            oEMPRESA.SaveChanges();
        }
        public void MODIFICAR_PROVEEDORES(MODELO.PROVEEDOR oPROVEEDOR)
        {
            oEMPRESA.Entry(oPROVEEDOR).State = System.Data.Entity.EntityState.Modified;
            oEMPRESA.SaveChanges();
        }
        public List<MODELO.PROVEEDOR> LISTAR_PROVEEDORES(string nombre)
        {
            var proveedores = from proveedor in oEMPRESA.PROVEEDORES.ToList()
                            where proveedor.nombre.ToLower().Contains(nombre.ToLower())
                            select proveedor;
            return proveedores.ToList();
        }
    }
}
