using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class GRUPOS
    {
        private static GRUPOS instancia;
        public static GRUPOS ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new GRUPOS();
            }
            return instancia;
        }
        DATOS.EMPRESA oEMPRESA;
        private GRUPOS()
        {
            oEMPRESA = DATOS.EMPRESA.ObtenerInstancia();
        }
        #region AMB
        public void AGREGAR_GRUPOS(MODELO.GRUPO oGRUPO)
        {
            oEMPRESA.GRUPOs.Add(oGRUPO);
            oEMPRESA.SaveChanges();
        }
        public void ELIMINAR_GRUPOS(MODELO.GRUPO oGRUPO)
        {
            oEMPRESA.GRUPOs.Remove(oGRUPO);
            oEMPRESA.SaveChanges();
        }
        public void MODIFICAR_GRUPOS(MODELO.GRUPO oGRUPO)
        {
            oEMPRESA.Entry(oGRUPO).State = System.Data.Entity.EntityState.Modified;
            oEMPRESA.SaveChanges();
        }
        #endregion      
        #region OBTENER USUARIO, GRUPO_USUARIO Y LISTAR GRUPO
        public MODELO.GRUPO ObtenerUsuariosGrupos(MODELO.GRUPO oGRUPO)
        {
            MODELO.GRUPO grupo = oEMPRESA.GRUPOs.Include("USUARIOS").FirstOrDefault(_ => _.cod_grupo == oGRUPO.cod_grupo);
            return grupo;

        }

        public List<MODELO.GRUPO> LISTAR_GRUPOS(string nombre)
        {
            var grupos = from grupo in oEMPRESA.GRUPOs.ToList()
                          where grupo.NOMBRE.ToLower().Contains(nombre.ToLower())
                          select grupo;
            return grupos.ToList();
        }
        public System.Collections.IEnumerable ObtenerAcciones(MODELO.GRUPO oGRUPO)
        {
            var acciones = from accion in oEMPRESA.ACCIONs.Include("Grupo").ToList()
                           where accion.Grupo == oGRUPO
                           select accion;
            return acciones.ToList();
        }
        public List<MODELO.USUARIO> ObtenerUsuarios()
        {
            return oEMPRESA.USUARIOs.ToList();
        }
        #endregion
    }
}
