using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace VISTA
{
    [MODELO.MODELO_DE_SEGURIDAD.ESTRUCTURA.formulario(CLASE = "frmBACKUP", DESCRIPCION = "Generar Back Up del sistema", MENU = true, MODULO = "Sistema", SEGURIDAD = true)]
    [MODELO.MODELO_DE_SEGURIDAD.ESTRUCTURA.accion(CONTROL = "btnGENERAR", DESCRIPCION = "Generar Backu Up", FORMULARIO = "frmBACKUP", FORMULARIO_DESCRIPCION = "Generar Back Up del sistema", MODULO = "Sistema")]
    [MODELO.MODELO_DE_SEGURIDAD.ESTRUCTURA.accion(CONTROL = "btnRESTAURAR", DESCRIPCION = "Restaurar Backu Up", FORMULARIO = "frmBACKUP", FORMULARIO_DESCRIPCION = "Restaurar Back Up del sistema", MODULO = "Sistema")]
    public partial class frmBACKUP : Form
    {
        private static frmBACKUP instancia;
        public static frmBACKUP obtener_instancia(MODELO.USUARIO oUSUARIO)
           
        {
            if (instancia == null)
            {
                instancia = new frmBACKUP(oUSUARIO);
            }
            if (instancia.IsDisposed)
            {
                instancia = new frmBACKUP(oUSUARIO);
            }
            return instancia;


        }
        CONTROLADORA.FachadaBACKUP cBACKUP;
        public frmBACKUP(MODELO.USUARIO oUSUARIO)
        {
            InitializeComponent();
            cBACKUP = CONTROLADORA.FachadaBACKUP.ObtenerInstancia();
            btnGENERAR.Enabled = false;
            btnGENERAR.Enabled = oUSUARIO.VALIDAR_ACCION("frmBACKUP", "btnGENERAR");
            btnRESTAURAR.Enabled = oUSUARIO.VALIDAR_ACCION("frmBACKUP", "btnRESTAURAR");
            
            
        }
       
        private void gtnGENERAR_Click(object sender, EventArgs e)
        {
            cBACKUP.GENERAR_COPIA();
        }

        private void btnRESTAURAR_Click(object sender, EventArgs e)
        {
            OpenFileRestaurarCopia.InitialDirectory = @"C";
            OpenFileRestaurarCopia.Title = "Busque la copia de seguridad";
            OpenFileRestaurarCopia.CheckFileExists = true;
            OpenFileRestaurarCopia.CheckPathExists = true;
            OpenFileRestaurarCopia.DefaultExt = "BAK";
            OpenFileRestaurarCopia.Filter = "Text files (*.bak)|*.bak";
            OpenFileRestaurarCopia.FilterIndex = 2;
            OpenFileRestaurarCopia.RestoreDirectory = true;
            OpenFileRestaurarCopia.ReadOnlyChecked = true;
            OpenFileRestaurarCopia.ShowReadOnly = true;

            DialogResult resultado = OpenFileRestaurarCopia.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                DialogResult confirmacion = MessageBox.Show("¿Seguro deseas restaurar la Base de Datos con esta Copia de Seguridad? \n\nIMPORTANTE: Se recomienda realizar una Copia de Seguridad antes de proceder con la Restauración.",
                    "Restaurar Copia de Seguridad", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (confirmacion == DialogResult.OK)
                {
                    String nombreArchivo = OpenFileRestaurarCopia.FileName;
                    try
                    {
                        String mensaje = cBACKUP.RESTAURAR_COPIA(nombreArchivo);  //cFachadBackup.MetodoRestaurarCopia(nombreArchivo);
                        if (mensaje == "Y")
                        {
                            MessageBox.Show("La Base de Datos se ha restaurado satisfactoriamente", "Restaurar Copia de Seguridad",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("La copia de seguridad a sido restaurada con exito","ATENCION",
                                MessageBoxButtons.OK, MessageBoxIcon.None);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Restaurar Copia de Seguridad",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            
        }

        private void btnSALIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
