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
    public partial class frmEMPLEADO : Form
    {
        string accion;
        MODELO.EMPLEADO oEMPLEADO;
        CONTROLADORA.EMPLEADOS cEMPLEADO;
        public frmEMPLEADO(MODELO.EMPLEADO MiEmpleado, string MiAccion)
        {
            InitializeComponent();
            accion = MiAccion;
            oEMPLEADO = MiEmpleado;
            cEMPLEADO = CONTROLADORA.EMPLEADOS.ObtenerInstancia();
            if (accion == "M")
            {
                txtNOMBRE.Text = oEMPLEADO.nombre;
                txtAPELLIDO.Text = oEMPLEADO.apellido;
                txtDIRECCION.Text = oEMPLEADO.direccion;
                txtDNI.Text = oEMPLEADO.dni.ToString();
                txtTELEFONO.Text = oEMPLEADO.telefono.ToString();
                
            }
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNOMBRE.Text))
            {
                MessageBox.Show("Debe ingresar un nombre", "Ingresar nombre", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtAPELLIDO.Text))
            {
                MessageBox.Show("Debe ingresar un apellido", "Ingresar apellido", MessageBoxButtons.OK,
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
            int DNI;
            if (!int.TryParse(txtDNI.Text, out DNI))
            {
                MessageBox.Show("Debe ingresar un DNI", "Ingresar DNI", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }
            oEMPLEADO.nombre = txtNOMBRE.Text;
            oEMPLEADO.apellido = txtAPELLIDO.Text;
            oEMPLEADO.direccion = txtDIRECCION.Text;
            oEMPLEADO.telefono = TELEFONO;
            oEMPLEADO.dni = DNI;
            if (accion == "A")
            {
                cEMPLEADO.AGREGAR_EMPLEADOS(oEMPLEADO);
            }
            else
            {
                cEMPLEADO.MODIFICAR_EMPLEADOS(oEMPLEADO);
            }
            this.DialogResult = DialogResult.OK;
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

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
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
