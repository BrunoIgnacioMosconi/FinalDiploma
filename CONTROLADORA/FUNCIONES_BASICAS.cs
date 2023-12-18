using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;


namespace CONTROLADORA.MODELO_DE_SEGURIDAD
{
   public class FUNCIONES_BASICAS
    {
        private static FUNCIONES_BASICAS instancia;
        public static FUNCIONES_BASICAS ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new FUNCIONES_BASICAS();
            }
            return instancia;
        }
        DATOS.EMPRESA oEMPRESA;
        private FUNCIONES_BASICAS()
        {
            oEMPRESA = DATOS.EMPRESA.ObtenerInstancia();
        }

        public static void GenerarExcel()
        {
            string FileTest = "D:\\Generar_Excel\\Planilla.xlsx";
            if (File.Exists(FileTest))
            {
                File.Delete(FileTest);
            }
            Excel.Application oApp;
            Excel.Worksheet oSheet;
            Excel.Workbook oBook;
            oApp = new Excel.Application();
            oBook = oApp.Workbooks.Add();
            oSheet = (Excel.Worksheet)oBook.Worksheets.get_Item(1);
            oSheet.Cells[1, 1] = "";

            oBook.SaveAs(FileTest);
            oBook.Close();
            oApp.Quit();

        }

        #region GENERAR CONTRASEÑA ALEATORIA
        public static string GenerarContraseñaAleatoria()
        {
            char[] ValueAfanumeric = { 'q', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p', 'a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'z', 'x', 'c', 'v', 'b', 'n', 'm', 'Q', 'W', 'E', 'R', 'T', 'Y', 'U', 'I', 'O', 'P', 'A', 'S', 'D', 'F', 'G', 'H', 'J', 'K', 'L', 'Z', 'X', 'C', 'V', 'B', 'N', 'M', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            Random random = new Random();
            int longitud = 6;
            string ClaveAleat = String.Empty;
            for (int i = 0; i < longitud; i++)
            {
                int rm = random.Next(0, 2);
                if (rm == 0)
                {
                    ClaveAleat += random.Next(0, 10);
                }
                else
                {
                    ClaveAleat += ValueAfanumeric[random.Next(0, 59)];
                }
            }
            return ClaveAleat;
        }
        #endregion
        #region ENCRIPTAR CONTRASEÑA 
        public static string EncriptarContraseña(string clave)
        {
            byte[] passBytes = Encoding.Unicode.GetBytes(clave);
            SHA256 sha = SHA256.Create();
            byte[] hash = sha.ComputeHash(passBytes);
            string hashString = Encoding.Unicode.GetString(hash);
            return hashString;
        }
        #endregion
        #region ENVIAR MAIL
        public static bool EnviarEmail(string para, string asunto, string cuerpo)
        {
            System.Net.Mail.MailMessage mmsg = new System.Net.Mail.MailMessage();
            mmsg.To.Add(para);
            mmsg.Subject = asunto;
            mmsg.SubjectEncoding = System.Text.Encoding.UTF8; //Para los servidores

            mmsg.Body = cuerpo;
            mmsg.BodyEncoding = System.Text.Encoding.UTF8;
            mmsg.IsBodyHtml = true;

            mmsg.From = new System.Net.Mail.MailAddress("b.i.mosconi@gmail.com");

            System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();

            cliente.Credentials = new System.Net.NetworkCredential("b.i.mosconi@gmail.com", "syek sfyg dkfl abrg");

            cliente.Port = 587;
            cliente.EnableSsl = true;

            cliente.Host = "smtp.gmail.com"; //mail.dominio.com

            try
            {
                cliente.Send(mmsg);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion
        #region VALIDAR MAIL
        public static bool ValidarEmail(string mail)
        {
            string expresion;
            expresion = @"\A(\w+\.?\w*\@\w+\.)(com)\Z";
            System.Text.RegularExpressions.Regex automata = new Regex(expresion);
            return automata.IsMatch(mail);
        }
        #endregion

    }
}
