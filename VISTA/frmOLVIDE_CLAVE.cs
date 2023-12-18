using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace VISTA.MODELO_DE_SEGURIDAD
{
    [MODELO.MODELO_DE_SEGURIDAD.ESTRUCTURA.formulario(CLASE = "frmOLVIDE_CLAVE", DESCRIPCION = "recuperar clave de acceso", MENU = false, MODULO = "Ventanas", SEGURIDAD = false)]
    public partial class frmOLVIDE_CLAVE : Form
    {
        CONTROLADORA.USUARIOS cUSUARIOS;
        
        public frmOLVIDE_CLAVE()
        {
            InitializeComponent();
            cUSUARIOS = CONTROLADORA.USUARIOS.ObtenerInstancia();
        }

       
        private void btnRECUPERAR_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMAIL.Text))
            {

                MessageBox.Show("Debe ingresar un mail", "Ingresar contraseña", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;

            }
            
            if (!CONTROLADORA.MODELO_DE_SEGURIDAD.FUNCIONES_BASICAS.ValidarEmail(txtMAIL.Text))
            {
                MessageBox.Show("Debe ingresar un mail valido", "Ingresar contraseña", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            MODELO.USUARIO oUSUARIO = cUSUARIOS.ObtenerUsuario(txtMAIL.Text);
            if (oUSUARIO == null)
            {
                MessageBox.Show("No se encotro el usuario para esa cuenta");
                return;
            }

            if (oUSUARIO.Estado == false)
            {
                MessageBox.Show("La cuenta esta desactivada");
                return;
            }

            string NuevaClave = CONTROLADORA.MODELO_DE_SEGURIDAD.FUNCIONES_BASICAS.GenerarContraseñaAleatoria();

            oUSUARIO.Contraseña = CONTROLADORA.MODELO_DE_SEGURIDAD.FUNCIONES_BASICAS.EncriptarContraseña(NuevaClave);

            cUSUARIOS.MODIFICAR_USUARIOS(oUSUARIO);
            if (CONTROLADORA.MODELO_DE_SEGURIDAD.FUNCIONES_BASICAS.EnviarEmail(oUSUARIO.Email, "NuevaClave", "Su nueva contraseña es "+ NuevaClave))
            {
                MessageBox.Show("Se envio su nueva contraseña satisfactoriamente");
            }
            else
            {
                MessageBox.Show("No se pudo enviar su nueva contraseña", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            this.DialogResult = DialogResult.OK;



        }
       
    }
}
