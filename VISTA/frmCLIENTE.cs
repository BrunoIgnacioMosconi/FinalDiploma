using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VISTA
{
    public partial class frmCLIENTE : Form
    {
        string accion;
        MODELO.CLIENTE oCLIENTE;
        CONTROLADORA.CLIENTES cCLIENTES;
        public frmCLIENTE(string MiAccion, MODELO.CLIENTE miCLIENTE )
        {
            InitializeComponent();
            oCLIENTE = miCLIENTE;
            accion = MiAccion;
            cCLIENTES = CONTROLADORA.CLIENTES.ObtenerInstancia();
            if (accion == "M")
            {
                txtNOMBRE.Text = oCLIENTE.nombre;
                txtAPELLIDO.Text = oCLIENTE.apellido;
                txtDIRECCION.Text = oCLIENTE.direccion;
               
                txtLOCALIDAD.Text = oCLIENTE.localidad;
                txtTELEFONO.Text = oCLIENTE.telefono.ToString();
            }
        }

        

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNOMBRE.Text))
            {
                MessageBox.Show("Debe ingresar un nombre",  "Ingresar nombre", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtAPELLIDO.Text))
            {
                MessageBox.Show("Debe ingresar un apellido", "Ingresar apellido", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtLOCALIDAD.Text))
            {
                MessageBox.Show("Debe ingresar una localidad", "Ingresar localidad", MessageBoxButtons.OK,
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
                MessageBox.Show("Debe ingresar un telefono");
                return;
            }
           
            oCLIENTE.nombre = txtNOMBRE.Text;
            oCLIENTE.apellido = txtAPELLIDO.Text;
            oCLIENTE.localidad = txtLOCALIDAD.Text;
            oCLIENTE.direccion = txtDIRECCION.Text;
            oCLIENTE.telefono = Convert.ToInt32(txtTELEFONO.Text);
            
            if (accion == "A")
            {
                cCLIENTES.AGREGAR_CLIENTES(oCLIENTE);
            }
            else
            {
                cCLIENTES.MODIFICAR_CLIENTES(oCLIENTE);
            }
            this.DialogResult = DialogResult.OK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
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

        

        private void txtNOMBRE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtAPELLIDO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
