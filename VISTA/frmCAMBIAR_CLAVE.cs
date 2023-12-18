using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VISTA.MODELO_DE_SEGURIDAD
{
    [MODELO.MODELO_DE_SEGURIDAD.ESTRUCTURA.formulario(CLASE = "frmCAMBIAR_CLAVE", DESCRIPCION = "Cambio de contraseña de acceso", MENU = true, MODULO = "Menu", SEGURIDAD = true)]
    [MODELO.MODELO_DE_SEGURIDAD.ESTRUCTURA.accion(CONTROL = "btnGUARDAR", DESCRIPCION = "Cambiar contraseña de acceso", FORMULARIO = "frmCAMBIAR_CLAVE", FORMULARIO_DESCRIPCION = "Cambio de contraseña de acceso", MODULO = "Menu")]
    public partial class frmCAMBIAR_CLAVE : Form
    {
        MODELO.USUARIO oUSUARIO;
        CONTROLADORA.USUARIOS cUSUARIOS;
        private static frmCAMBIAR_CLAVE instancia;
        public static frmCAMBIAR_CLAVE obtener_instancia(MODELO.USUARIO miUSUARIO)
        {
            if (instancia == null)
                instancia = new frmCAMBIAR_CLAVE(miUSUARIO);
            if (instancia.IsDisposed)
                instancia = new frmCAMBIAR_CLAVE(miUSUARIO);

            return instancia;
        }
        public frmCAMBIAR_CLAVE(MODELO.USUARIO MiUsuario)
        {
            InitializeComponent();
            oUSUARIO = MiUsuario;
            cUSUARIOS = CONTROLADORA.USUARIOS.ObtenerInstancia();

            txtCVIEJA.Text = string.Empty;
            txtNCONTRASEÑA.Text = string.Empty;
            txtRCONTRASEÑA.Text = string.Empty;
        }

        private void btnGUARDAR_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCVIEJA.Text))
            {
                MessageBox.Show("Debe ingresar la contraseña actual", "ATENCION!!");
                return;
            }
            if (oUSUARIO.Contraseña != CONTROLADORA.MODELO_DE_SEGURIDAD.FUNCIONES_BASICAS.EncriptarContraseña(txtCVIEJA.Text))
            {
                MessageBox.Show("La contraseña actual ingresada no coincide con la contraseña registrada", "ATENCION!!");
                return;
            }
            if (string.IsNullOrEmpty(txtNCONTRASEÑA.Text))
            {
                MessageBox.Show("La nueva contraseña debe contener al menos un caracter", "ATENCION!!");
                return;
            }
            if (txtCVIEJA.Text == txtNCONTRASEÑA.Text)
            {
                MessageBox.Show("La nueva contraseña debe ser distinta a la actual", "ATENCION!!");
                return;
            }
            if (txtNCONTRASEÑA.Text != txtRCONTRASEÑA.Text)
            {
                MessageBox.Show("Las nuevas contraseñas deben coincidir", "ATENCION!!");
                return;
            }

            oUSUARIO.Contraseña = CONTROLADORA.MODELO_DE_SEGURIDAD.FUNCIONES_BASICAS.EncriptarContraseña(txtNCONTRASEÑA.Text);           
            cUSUARIOS.MODIFICAR_USUARIOS(oUSUARIO);

            MessageBox.Show("Se ha establecido la nueva contraseña, la misma deberá ser usada en el próximo inicio de sesión", "CAMBIO DE CONTRASENA ACEPTADA");

            this.Close();
        }

        private void txtCVIEJA_Enter(object sender, EventArgs e)
        {
          
           
        }

        private void txtCVIEJA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtNCONTRASEÑA.Focus();
        }

        private void txtNCONTRASEÑA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtRCONTRASEÑA.Focus();
        }

        private void txtRCONTRASEÑA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnGUARDAR.Focus();
        }
    }
}
