using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CONTROLADORA.MODELO_DE_SEGURIDAD
{
    public class LOGIN
    {
        private static LOGIN instancia;
        public static LOGIN ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new LOGIN();
            }
            return instancia;
        }
        DATOS.EMPRESA oEMPRESA;
        private LOGIN()
        {
            oEMPRESA = DATOS.EMPRESA.ObtenerInstancia();
        }
        #region METODOS PARA AUDITAR LOGIN
        public void AGREGAR_LOGIN(MODELO.LOGIN oLOGIN)
        {
            oEMPRESA.LOGINs.Add(oLOGIN);
            oEMPRESA.SaveChanges();
        }
        public void MODIFICAR_LOGIN(MODELO.LOGIN oLOGIN)
        {
            oEMPRESA.Entry(oLOGIN).State = System.Data.Entity.EntityState.Modified;
            oEMPRESA.SaveChanges();
        }
        public System.Collections.IEnumerable OBTENER_LOGINS(string nombre)
        {
            var logins = from login in oEMPRESA.LOGINs.Include("USUARIOS").ToList()
                         where login.USUARIOS.Nombre.ToLower().Contains(nombre.ToLower())
                         select login;

            return logins.ToList();
        }
        public MODELO.LOGIN OBTENER_LOGIN(MODELO.USUARIO oUSUARIO)
        {
            var logins = from login in oEMPRESA.LOGINs.Include("USUARIOS").ToList()
                         where login.USUARIOS == oUSUARIO && login.Fecha_logout == Convert.ToDateTime("10/10/2050")
                         select login;
            if (logins != null && logins.Count() > 0) {
                return logins.ToList().ElementAt(0);
            }
            var oLogin = new MODELO.LOGIN();
            return oLogin;
        }
        public Int32 CANTIDAD_USUARIOS_CONECTADOS()
        {
            return oEMPRESA.USUARIOs.Count(_ => _.Conectado == true);
        }
        #endregion
        #region METODOS PARA OBTENER USUARIO Y LOS PERMISOS Y ACCIONES DEL MISMO
      
        public List<MODELO.ACCION> ObtenerAccionesDelUsuario(MODELO.USUARIO oUSUARIO)
        {
            var grupos = from grupo in oEMPRESA.GRUPOs.Include("USUARIOS").ToList()
                         where grupo.USUARIOS.Contains(oUSUARIO)
                         select grupo;
            List<MODELO.GRUPO> gruposs = grupos.ToList();
            List<MODELO.ACCION> acciones = new List<MODELO.ACCION>();
            foreach (MODELO.GRUPO oGRUPO in gruposs)
            {
                var accioness = (from accion in oEMPRESA.ACCIONs.Include("Grupo").ToList()
                                 where oGRUPO.ACCIONES.Contains(accion)
                                 select accion).Distinct();
                foreach (MODELO.ACCION oACCION in accioness.ToList())
                {
                    acciones.Add(oACCION);
                }
            }
            return acciones.ToList();
        }

        public void VERIFICA_PERMISOS_ADMINISTRADOR()
        {
            MODELO.GRUPO GRUPO = oEMPRESA.GRUPOs.Include("ACCIONES").FirstOrDefault(gru => gru.cod_grupo == 1);
            if (GRUPO.ACCIONES.Count == 0)
            {
                List<MODELO.MODELO_DE_SEGURIDAD.ESTRUCTURA.formulario> FORMULARIOS = CONTROLADORA.ACCIONES.OBTENER_ACCIONES();

                var modulos = (from formulario in FORMULARIOS
                               where formulario.SEGURIDAD && formulario.MODULO == "Sistema"
                               select new { DESCRIPCION = formulario.MODULO })
                              .Distinct();

                foreach (var MODULO in modulos)
                {
                    var formularios = from formulario in FORMULARIOS
                                      where formulario.MODULO == MODULO.DESCRIPCION
                                      select formulario;

                    foreach (MODELO.MODELO_DE_SEGURIDAD.ESTRUCTURA.formulario oFORM in formularios)
                    {
                        foreach (MODELO.MODELO_DE_SEGURIDAD.ESTRUCTURA.accion oACCION in oFORM.ACCIONES)
                        {
                            if (GRUPO.ACCIONES.Count(acc => (acc.MODULO == oACCION.MODULO) && (acc.FORMULARIO == oACCION.FORMULARIO) && (acc.CONTROL == oACCION.CONTROL)) == 0)
                            {
                                MODELO.ACCION miACCION = new MODELO.ACCION();
                                miACCION.CONTROL = oACCION.CONTROL;
                                miACCION.DESCIPCION_ACCION = oACCION.DESCRIPCION;
                                miACCION.FORMULARIO = oACCION.FORMULARIO;
                                miACCION.FORMULARIO_DESCRIPCION = oACCION.FORMULARIO_DESCRIPCION;
                                miACCION.MODULO = oACCION.MODULO;

                                GRUPO.ACCIONES.Add(miACCION);
                            }
                        }
                    }
                }
            }
            oEMPRESA.Entry(GRUPO).State = EntityState.Modified;
            oEMPRESA.SaveChanges();
        }
        #endregion
    }
}
