using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
   public class LOGIN
    {
        public Int32 Cod_Login { get; set; }
        public USUARIO USUARIOS { get; set; }
        public DateTime Fecha_login { get; set; }
        public DateTime Fecha_logout { get; set; }
    }
}
