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
    public partial class frmPROVEEDOR : Form
    {
        string accion;
        MODELO.PROVEEDOR oPROVEEDOR;
        CONTROLADORA.PROVEEDORES cPROVEEDORES;
        CONTROLADORA.USUARIOS cUSUARIOS;
        public frmPROVEEDOR(string MiAccion, MODELO.PROVEEDOR MiProveedor )
        {
            InitializeComponent();
            oPROVEEDOR = MiProveedor;
            accion = MiAccion;
            cPROVEEDORES = CONTROLADORA.PROVEEDORES.ObtenerInstancia();
            cUSUARIOS = CONTROLADORA.USUARIOS.ObtenerInstancia();
            
            if (accion == "M")
            {
                txtNOMBRE.Text = oPROVEEDOR.nombre;
                txtAPELLIDO.Text = oPROVEEDOR.apellido;
                txtLOCALIDAD.Text = oPROVEEDOR.localidad;
                txtEMAIL.Text = oPROVEEDOR.email;
                txtTELEFONO.Text = oPROVEEDOR.telefono.ToString();
              
                txtDIRECCION.Text = oPROVEEDOR.direccion;
            }
        }

        private void btnGUARDAR_Click(object sender, EventArgs e)
        {
          
        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNOMBRE.Text))
            {
                MessageBox.Show("Debe ingresar un nombre", "Ingresar nombre", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtEMAIL.Text))
            {
                MessageBox.Show("Debe ingresar un email", "Ingresar mail", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtDIRECCION.Text))
            {
                MessageBox.Show("Debe ingresar una direccion", "Ingresar direccion", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }
            int TELEFONO;
            if (!int.TryParse(txtTELEFONO.Text, out TELEFONO))
            {
                MessageBox.Show("Debe ingresar un telefono", "Ingresar telefono", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }
            
            if (string.IsNullOrWhiteSpace(txtLOCALIDAD.Text))
            {
                MessageBox.Show("Debe ingresar una localidad", "Ingresar localidad", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtEMAIL.Text))
            {

                MessageBox.Show("Debe ingresar un mail", "Ingresar contraseña", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;

            }
            if (!cUSUARIOS.ValidarMail(txtEMAIL.Text))
            {
                MessageBox.Show("Debe ingresar un mail valido", "Ingresar contraseña", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            
            oPROVEEDOR.nombre = txtNOMBRE.Text;
            oPROVEEDOR.apellido = txtAPELLIDO.Text;
            oPROVEEDOR.email = txtEMAIL.Text;
            oPROVEEDOR.localidad = txtLOCALIDAD.Text;
           
            oPROVEEDOR.telefono = TELEFONO;
            oPROVEEDOR.direccion = txtDIRECCION.Text;
            if (accion == "A")
            {
                cPROVEEDORES.AGREGAR_PROVEEDORES(oPROVEEDOR);
            }
            else
            {
                cPROVEEDORES.MODIFICAR_PROVEEDORES(oPROVEEDOR);
            }
            this.DialogResult = DialogResult.OK;
        }
        public static bool ValidarMail(string email)
        {
            String expresion = @"\A(\w+\.?\w*\@\w+\.)(com)\Z";

            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void txtTELEFONO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtQUIL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtNOMBRE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtLOCALIDAD_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
