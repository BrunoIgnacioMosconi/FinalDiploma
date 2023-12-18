using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class USUARIO
    {
        public Int32 cod_usuario { get; set; }       
        public string Nombre { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
        public string Email { get; set; }
        public bool Estado { get; set; }
        public bool Conectado { get; set; }

        public USUARIO()
        {
            GRUPOs = new HashSet<GRUPO>();
        }
        public virtual ICollection<MODELO.GRUPO>GRUPOs { get; set; }

        public System.Boolean VALIDAR_ACCION(string formulario, string control)
        {
            bool RESULTADO = false;
            if (this.GRUPOs.Count(g => g.cod_grupo == 1) > 0)
            {
                RESULTADO = true;
            }
            else
            {
                foreach (GRUPO oGRUPO in this.GRUPOs)
                {
                    if (oGRUPO.ACCIONES.Count(acc => acc.FORMULARIO == formulario && acc.CONTROL == control) > 0)
                        RESULTADO = true;
                }
            }
            return RESULTADO;
        }

        public System.Boolean VALIDA_MODULO(string modulo)
        {
            bool RESULTADO = false;
            if (this.GRUPOs.Count(g => g.cod_grupo == 2) > 0)
            {
                RESULTADO = true;
            }
            else
            {
                foreach (GRUPO oGRUPO in this.GRUPOs)
                {
                    if (oGRUPO.ACCIONES.Count(acc => acc.MODULO == modulo) > 0)
                        
                        RESULTADO = true;
                }
            }
            return RESULTADO;
        }
        public override string ToString()
        {
            return Nombre.ToString();
        }

    }
}
