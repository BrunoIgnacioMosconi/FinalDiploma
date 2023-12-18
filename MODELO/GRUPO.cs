using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class GRUPO
    {
        public Int32 cod_grupo { get; set; }
        public GRUPO(int miID, string miNombre)
        {
            cod_grupo = miID;
            NOMBRE = miNombre;

        }

        public GRUPO()
        {
            USUARIOS = new HashSet <USUARIO>();
            ACCIONES = new HashSet <ACCION>();
        }
      
        public string NOMBRE { get; set; }

        public override string ToString()
        {
            return NOMBRE;
        }

        public virtual ICollection<USUARIO> USUARIOS { get; set; }
        public virtual ICollection<ACCION> ACCIONES { get; set; }

        

}
}

