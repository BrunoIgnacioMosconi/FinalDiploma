using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Data.Entity;
using MODELO;
using System.Windows;

namespace CONTROLADORA
{
    public class ACCIONES
    {
        private static ACCIONES instancia;
        public static ACCIONES ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new ACCIONES();
            }
            return instancia;
        }
        DATOS.EMPRESA oEMPRESA;
        private ACCIONES()
        {
            oEMPRESA = DATOS.EMPRESA.ObtenerInstancia();
        }
        #region  OBTENER ACCION
       
        public static List<MODELO.MODELO_DE_SEGURIDAD.ESTRUCTURA.formulario> OBTENER_ACCIONES()
        {
            List<MODELO.MODELO_DE_SEGURIDAD.ESTRUCTURA.formulario> FORMULARIOS = new List<MODELO.MODELO_DE_SEGURIDAD.ESTRUCTURA.formulario>();
            Assembly VISTA = Assembly.LoadFrom("VISTA.exe");
            foreach (System.Type type in VISTA.GetTypes())
            {
                //pregunto si es de tipo Formulario
                if (type.IsSubclassOf(typeof(System.Windows.Forms.Form)))
                {
                    object[] attrs = type.GetCustomAttributes(typeof(MODELO.MODELO_DE_SEGURIDAD.ESTRUCTURA.formulario), true);

                    foreach (MODELO.MODELO_DE_SEGURIDAD.ESTRUCTURA.formulario a in attrs)
                    {
                        if (a.SEGURIDAD)
                        {
                            object[] acciones = type.GetCustomAttributes(typeof(MODELO.MODELO_DE_SEGURIDAD.ESTRUCTURA.accion), true);

                            foreach (MODELO.MODELO_DE_SEGURIDAD.ESTRUCTURA.accion ac in acciones)
                            {

                                a.ACCIONES.Add(ac);
                            }
                        }

                        FORMULARIOS.Add(a);
                    }
                }
            }
            return FORMULARIOS;
        }
        #endregion
    }
}
