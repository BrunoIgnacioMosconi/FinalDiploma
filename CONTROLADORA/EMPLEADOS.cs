using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class EMPLEADOS
    {
        public static EMPLEADOS instancia;
        public static EMPLEADOS ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new EMPLEADOS();
            }
            return instancia;
        }
        DATOS.EMPRESA oEMPRESA;
        private EMPLEADOS()
        {
            oEMPRESA = DATOS.EMPRESA.ObtenerInstancia();
        }
        public void AGREGAR_EMPLEADOS(MODELO.EMPLEADO oEMPLEADO)
        {
            oEMPRESA.EMPLEADOS.Add(oEMPLEADO);
            oEMPRESA.SaveChanges();
        }
        public void ELIMINAR_EMPLEADOS(MODELO.EMPLEADO oEMPLEADO)
        {
            oEMPRESA.EMPLEADOS.Remove(oEMPLEADO);
            oEMPRESA.SaveChanges();
        }
        public void MODIFICAR_EMPLEADOS(MODELO.EMPLEADO oEMPLEADO)
        {
            oEMPRESA.Entry(oEMPLEADO).State = System.Data.Entity.EntityState.Modified;
            oEMPRESA.SaveChanges();
        }
        public List<MODELO.EMPLEADO> LISTAR_EMPLEADOS(string nombre)
        {
            var empleados = from empleado in oEMPRESA.EMPLEADOS.ToList()
                            where empleado.nombre.ToLower().Contains(nombre.ToLower())
                            select empleado;
            return empleados.ToList();
        }
        public MODELO.EMPLEADO BUSCAR_EMPLEADO(Int32 CODIGO)
        {
            return oEMPRESA.EMPLEADOS.Find(CODIGO);
        }

    }
}
