using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLADORA
{
    public class CLIENTES
    {
        public static CLIENTES instancia;
        public static CLIENTES ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new CLIENTES();
            }
            return instancia;
        }
        DATOS.EMPRESA oEMPRESA;
        private CLIENTES()
        {
            oEMPRESA = DATOS.EMPRESA.ObtenerInstancia();
        }
        public void AGREGAR_CLIENTES(MODELO.CLIENTE oCLIENTE)
        {
            oEMPRESA.CLIENTES.Add(oCLIENTE);
            oEMPRESA.SaveChanges();
        }
        public void ELIMINAR_CLIENTES(MODELO.CLIENTE oCLIENTE)
        {
            oEMPRESA.CLIENTES.Remove(oCLIENTE);
            oEMPRESA.SaveChanges();
        }
        public void MODIFICAR_CLIENTES(MODELO.CLIENTE oCLIENTE)
        {
            oEMPRESA.Entry(oCLIENTE).State = System.Data.Entity.EntityState.Modified;
            oEMPRESA.SaveChanges();
        }
        public List<MODELO.CLIENTE> LISTAR_CLIENTES()
        {
            return oEMPRESA.CLIENTES.ToList();
        }
        public List<MODELO.CLIENTE> BUSCAR_CLIENTE(string nombre)
        {
            return oEMPRESA.CLIENTES.Where(_ => _.nombre == nombre).ToList();
        }
        public MODELO.CLIENTE BUSCAR_CLIEN(Int32 CODIGO)
        {
            return oEMPRESA.CLIENTES.Find(CODIGO);
        }
    }
}
