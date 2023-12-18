using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CONTROLADORA
{
    public class USUARIOS
    {
        private static USUARIOS instancia;
        public static USUARIOS ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new USUARIOS();
            }
            return instancia;
        }
        DATOS.EMPRESA oEMPRESA;
        private USUARIOS()
        {
            oEMPRESA = DATOS.EMPRESA.ObtenerInstancia();
        }
        #region ABM
        public void AGREGAR_USUARIOS(MODELO.USUARIO oUSUARIO)
        {
            oEMPRESA.USUARIOs.Add(oUSUARIO);
            oEMPRESA.SaveChanges();
        }
        public void ELIMINAR_USUARIOS(MODELO.USUARIO oUSUARIO)
        {
            oUSUARIO.Estado = false;

            oEMPRESA.Entry(oUSUARIO).State = System.Data.Entity.EntityState.Modified;
            oEMPRESA.SaveChanges();
        }
       
        public void MODIFICAR_USUARIOS(MODELO.USUARIO oUSUARIO)
        {
            oEMPRESA.Entry(oUSUARIO).State = System.Data.Entity.EntityState.Modified;
            oEMPRESA.SaveChanges();
        }

        #endregion
        #region OBTENER GRUPO Y USUARIO
        public MODELO.USUARIO ObtenerUsuario(string Mail)
        {
            return oEMPRESA.USUARIOs.FirstOrDefault(_ => _.Email == Mail);
        }
        public MODELO.USUARIO ObtenerUsuario(int codigo)
        {
            return oEMPRESA.USUARIOs.Include("GRUPOs").FirstOrDefault(u => u.cod_usuario == codigo);
        }
        public MODELO.USUARIO ObtenerUsuarioLogin(string Usuario)
        {
            return oEMPRESA.USUARIOs.FirstOrDefault(_ => _.Usuario == Usuario);
        }
        public List<MODELO.GRUPO> OBTENER_GRUPOS()
        {
            var grupos = from grupo in oEMPRESA.GRUPOs

                         select grupo;

            return grupos.ToList();
        }
        #endregion        
        #region MAIL
        public bool VALIDAR_MAIL_EXISTENTE(string mail)
        {
            if (oEMPRESA.USUARIOs.Any(_ => _.Email == mail))
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        public bool ValidarMail(string email)
        {
            String expresion = @"\A(\w+\.?\w*\@\w+\.)(com)\Z";

            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        #endregion
        #region USUARIO
        public System.Collections.IEnumerable LISTAR_USUARIOS(string mail)
        {
            var USUARIOS = from USUARIO in oEMPRESA.USUARIOs.Include("GRUPOs").ToList()
                           where USUARIO.Email.ToLower().Contains(mail.ToLower())//BUSCAR
                           select USUARIO;
            return USUARIOS.ToList();
        }
        public bool VALIDAR_USUARIO_EXISTENTE(string usuario)
        {
            if (oEMPRESA.USUARIOs.Any(_ => _.Usuario == usuario))
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        public MODELO.USUARIO ObtenerUsuarioyPass(string user, string pass)
        {
            MODELO.USUARIO usuario = oEMPRESA.USUARIOs.FirstOrDefault(c => c.Usuario == user);

            if (usuario.Contraseña == pass)
            {
                return usuario;
            }
            else
            {
                usuario = null;
                return usuario;
            }
        }
        #endregion
    }
}
