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


namespace VISTA
{
    [MODELO.MODELO_DE_SEGURIDAD.ESTRUCTURA.formulario(CLASE = "frmLOGIN", DESCRIPCION = "Ingreso al Sistema", MENU = false, MODULO = "ventanas", SEGURIDAD = false)]
    public partial class frmLOGIN : Form
    {
        MODELO.USUARIO oUSUARIO;
      
        CONTROLADORA.USUARIOS cUSUARIOS;
        CONTROLADORA.MODELO_DE_SEGURIDAD.LOGIN cLOGIN;
       
        public MODELO.USUARIO USUARIO_ACTUAL
        {
            get { return oUSUARIO; }
        }

        public frmLOGIN()
        {
            InitializeComponent();
            
            cUSUARIOS = CONTROLADORA.USUARIOS.ObtenerInstancia();
            cLOGIN = CONTROLADORA.MODELO_DE_SEGURIDAD.LOGIN.ObtenerInstancia();
           
        }

      

        private void button1_Click(object sender, EventArgs e)
        {

            
            if (string.IsNullOrEmpty(txtUSUARIO.Text))
            {
                
               MessageBox.Show("Debe ingresar el nombre de usuario");
                return;
            }
            if (string.IsNullOrEmpty(txtCONTRASEÑA.Text))
            {
                MessageBox.Show("Debe ingresar la contraseña del usuario");
                return;
            }


            oUSUARIO = cUSUARIOS.ObtenerUsuarioLogin(txtUSUARIO.Text);
            if (oUSUARIO == null)
            {
                MessageBox.Show("Usuario  incorrecto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            if (oUSUARIO.Contraseña != CONTROLADORA.MODELO_DE_SEGURIDAD.FUNCIONES_BASICAS.EncriptarContraseña(txtCONTRASEÑA.Text))
            {
                MessageBox.Show("Contraseña incorrecta", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           
            MODELO.LOGIN oLOGIN = new MODELO.LOGIN();
            oLOGIN.Fecha_login = System.DateTime.Now;
            oLOGIN.USUARIOS = oUSUARIO;
            oLOGIN.Fecha_logout = Convert.ToDateTime("10/10/2050");
            cLOGIN.AGREGAR_LOGIN(oLOGIN);

            this.DialogResult = DialogResult.OK;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            MODELO_DE_SEGURIDAD.frmOLVIDE_CLAVE frm = new MODELO_DE_SEGURIDAD.frmOLVIDE_CLAVE();
            DialogResult dr = frm.ShowDialog();
        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
