using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CONTROLADORA
{
   public class FachadaBACKUP
    {
        public static FachadaBACKUP instancia;
        public static FachadaBACKUP ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new FachadaBACKUP();
            }
            return instancia;
        }
        DATOS.EMPRESA oEMPRESA;

        private CONTROLADORA.FachadaGENERAR_BACKUP oGENERAR_BACKUP;
        private CONTROLADORA.FachadaRECUPERAR_BACKUP oRECUPERAR_BACKUP;

        public FachadaBACKUP()
        {
            oEMPRESA = DATOS.EMPRESA.ObtenerInstancia();
            oGENERAR_BACKUP = new FachadaGENERAR_BACKUP();
            oRECUPERAR_BACKUP = new FachadaRECUPERAR_BACKUP();
        }
        public void GENERAR_COPIA() // FUNCION ANONIMA 
        {
            oGENERAR_BACKUP.GenerarBackUp();
        }
        public string RESTAURAR_COPIA(string nombre)
        {
            oRECUPERAR_BACKUP.RestaurarBackUp(nombre);
            return nombre;
        }
    }


    public class FachadaGENERAR_BACKUP
    {
        public void GenerarBackUp()
        {
            DateTime d = DateTime.Now;
            string dd = d.Day + "-" + d.Month;

            string servername = "DESKTOP-695UECB\\BRUNO2017";
            string dbname = "[DATOS.EMPRESA]";
            string aaa = @"Data Source=" + servername + "; Initial Catalog= DATOS.EMPRESA ; Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;App=EntityFramework";
            SqlConnection con = new SqlConnection(aaa);

            try
            {

                con.Open();
                string str = "USE " + dbname + ";";
                string str1 = "BACKUP DATABASE " + dbname + " TO DISK = 'C:\\Users\\bruno\\Desktop\\final diploma\\FINAL ENTREGA\\backup\\" + dbname + " - " + dd + "-" + System.DateTime.Now.Hour + System.DateTime.Now.Minute +  ".Bak' WITH FORMAT,MEDIANAME = 'Z_SQLserverBackups',NAME = 'full backup of " + dbname + "';";
                SqlCommand cmd1 = new SqlCommand(str, con);
                SqlCommand cmd2 = new SqlCommand(str1, con);

                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();

                con.Close();
            }

            catch (Exception ex)
            {
                throw new Exception("Error al intentar ejecutar el procedimiento almacenado dbo.GenerarBackUp. " + ex.Message, ex);
            }

            finally
            {
                con.Close();
            }

        }
        
    }
    public class FachadaRECUPERAR_BACKUP
    {
        public string RestaurarBackUp(string nombre)
        {
            string servername = "DESKTOP-695UECB\\BRUNO2017";
            string dbname = "[DATOS.EMPRESA]";
            string aaa = @"Data Source=" + servername + "; Initial Catalog= DATOS.EMPRESA ; Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;App=EntityFramework";
            SqlConnection con = new SqlConnection(aaa);

            try
            {

                con.Open();
                string str = "USE master; ";
                string str1 = "ALTER DATABASE " + dbname + " SET SINGLE_USER WITH ROLLBACK IMMEDIATE;";
                string str3 = "RESTORE DATABASE " + dbname + " FROM DISK = '" + nombre + "' WITH REPLACE ";

                SqlCommand cmd1 = new SqlCommand(str, con);
                SqlCommand cmd2 = new SqlCommand(str1, con);
                SqlCommand cmd3 = new SqlCommand(str3, con);
                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                cmd3.ExecuteNonQuery();

                con.Close();
            }

            catch (Exception ex)
            {
                throw new Exception("Error al intentar ejecutar el procedimiento almacenado dbo.RestaurarBackUp. " + ex.Message, ex);
            }

            finally
            {
                con.Close();
            }
            return nombre;
        }

    }
}

