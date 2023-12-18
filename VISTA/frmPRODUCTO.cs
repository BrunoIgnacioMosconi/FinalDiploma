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
    public partial class frmPRODUCTO : Form
    {
        string accion;
        MODELO.PRODUCTO oPRODUCTO;
        MODELO.USUARIO oUSUARIO;
        CONTROLADORA.PRODUCTOS cPRODUCTOS;
        public frmPRODUCTO( MODELO.PRODUCTO MiProducto, string MiAccion, MODELO.USUARIO MiUsuario )
        {

            InitializeComponent();
            accion = MiAccion;
            oUSUARIO = MiUsuario;
            oPRODUCTO = MiProducto;
            cPRODUCTOS = CONTROLADORA.PRODUCTOS.ObtenerInstancia();
            cPRODUCTOS = CONTROLADORA.PRODUCTOS.ObtenerInstancia();
            cmbPROVEEDOR.DataSource = cPRODUCTOS.obtenerProveedores();
            CARGAR_COLOR();
            CARGAR_MARCA();

            if (accion == "M")
            {
                txtDESCRIPCION.Text = oPRODUCTO.descripcion;
                txtCODBARRA.Text = oPRODUCTO.cod_barra;
                cmbMARCA.Text = oPRODUCTO.Marca;
                txtPRECIOUNITARIO.Text = oPRODUCTO.precio_unitario.ToString();
                cmbCOLOR.Text = oPRODUCTO.color;
                txtTIPODEPRODUCTO.Text = oPRODUCTO.tipo_producto;

                if (oPRODUCTO.talle == "L")
                {
                    rdl.Checked = true;                   
                }
                else if (oPRODUCTO.talle =="S")
                {
                    rdS.Checked = true;
                }
                else if (oPRODUCTO.talle == "XS")
                {
                    rdXS.Checked = true;
                }
                else if (oPRODUCTO.talle =="XL")
                {
                    rdXL.Checked = true;
                }
                else if (oPRODUCTO.talle == "M")
                {
                    rdM.Checked = true;
                }
                else if (oPRODUCTO.talle == "XXL")
                {
                    rdXXL.Checked = true;
                }

            }
            if(accion == "C")
            {
                txtDESCRIPCION.Enabled = false;
                txtPRECIOUNITARIO.Enabled = false;
                cmbCOLOR.Enabled = false;
                txtTIPODEPRODUCTO.Enabled = false;
                cmbMARCA.Enabled = false;
                cmbPROVEEDOR.Enabled = false;
                txtCODBARRA.Enabled = false;
                rdl.Enabled = false;
                rdS.Enabled = false;
                rdXS.Enabled = false;
                rdXL.Enabled = false;
                rdM.Enabled = false;
                rdXXL.Enabled = false;

                cmbMARCA.Text = oPRODUCTO.Marca;
                txtDESCRIPCION.Text = oPRODUCTO.descripcion;
                txtCODBARRA.Text = oPRODUCTO.cod_barra;
                txtPRECIOUNITARIO.Text = oPRODUCTO.precio_unitario.ToString();
                cmbCOLOR.Text = oPRODUCTO.color;
                txtTIPODEPRODUCTO.Text = oPRODUCTO.tipo_producto;
                if (oPRODUCTO.talle == "L")
                {
                    rdl.Checked = true;
                }
                else if (oPRODUCTO.talle == "S")
                {
                    rdS.Checked = true;
                }
                else if (oPRODUCTO.talle == "XS")
                {
                    rdXS.Checked = true;
                }
                else if (oPRODUCTO.talle == "XL")
                {
                    rdXL.Checked = true;
                }
                else if (oPRODUCTO.talle == "M")
                {
                    rdM.Checked = true;
                }
                else if (oPRODUCTO.talle == "XXL")
                {
                    rdXXL.Checked = true;
                }

            }

        }          
        
        public void CARGAR_COLOR()
        {
            cmbCOLOR.Items.Add("Seleccionar");
            cmbCOLOR.SelectedItem = "Seleccionar";
            cmbCOLOR.Items.Add("ROJO");
            cmbCOLOR.Items.Add("AZUL");
            cmbCOLOR.Items.Add("JEAN");
            cmbCOLOR.Items.Add("AMARILLO");
            cmbCOLOR.Items.Add("NARANJA");
            cmbCOLOR.Items.Add("NEGRO");
            cmbCOLOR.Items.Add("BLANCO");
            cmbCOLOR.Items.Add("ROJO CON ESTAMPA");
            cmbCOLOR.Items.Add("AZUL CON ESTAMPA");      
            cmbCOLOR.Items.Add("AMARILLO CON ESTAMPA");
            cmbCOLOR.Items.Add("NARANJA CON ESTAMPA");
            cmbCOLOR.Items.Add("NEGRO CON ESTAMPA");
            cmbCOLOR.Items.Add("BLANCO CON ESTAMPA");
            cmbCOLOR.Items.Add("OTRO");
        }
        public void CARGAR_MARCA()
        {
            cmbMARCA.Items.Add("Seleccionar");
            cmbMARCA.SelectedItem = "Seleccionar";
            cmbMARCA.Items.Add("Reebok ");
            cmbMARCA.Items.Add("Nike ");
            cmbMARCA.Items.Add("Adidas");
            cmbMARCA.Items.Add("Puma");
            cmbMARCA.Items.Add("New Balance");
            cmbMARCA.Items.Add("Everlast");
            cmbMARCA.Items.Add("Fila");
            cmbMARCA.Items.Add("Kappa");
            cmbMARCA.Items.Add("Topper");
            cmbMARCA.Items.Add("DC");
            cmbMARCA.Items.Add("Billabong");
            cmbMARCA.Items.Add("C1rca");
            cmbMARCA.Items.Add("Kevingston");
            cmbMARCA.Items.Add("Levi's");
            cmbMARCA.Items.Add("Holliester");
            cmbMARCA.Items.Add("Lacoste");
            cmbMARCA.Items.Add("Tommy Hilfiger");
            cmbMARCA.Items.Add("Zara");
            cmbMARCA.Items.Add("Mango");

        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbMARCA.Text))
            {
                MessageBox.Show("Debe ingresar una marca", "Ingresar marca", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtDESCRIPCION.Text))
            {
                MessageBox.Show("Debe ingresar una descripcion", "Ingresar descripcion", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }
            decimal PRECIO;
            if (!decimal.TryParse(txtPRECIOUNITARIO.Text, out PRECIO))
            {
                MessageBox.Show("Debe ingresar un precio", "Ingresar precio", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }
            int CODIGO;
            if (!int.TryParse(txtCODBARRA.Text, out CODIGO))
            {
                MessageBox.Show("Debe ingresar un codigo", "Ingresar codigo", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }
            if (cmbCOLOR.SelectedItem.ToString() == "Seleccionar")
            {
                MessageBox.Show("Debe seleccionar un color", "Seleccionar color", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }
            if (cmbMARCA.SelectedItem.ToString() == "Seleccionar")
            {
                MessageBox.Show("Debe seleccionar una marca", "Seleccionar marca", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtTIPODEPRODUCTO.Text))
            {
                MessageBox.Show("Debe ingresar untipo de producto", "Ingresar producto", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }
            if (rdl.Checked == false && rdM.Checked == false && rdS.Checked == false && rdXL.Checked == false && rdXS.Checked == false && rdXXL.Checked == false)
            {
                MessageBox.Show("Debe seleccionar un talle", "Seleccionar talle", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }
            if (!cPRODUCTOS.VALIDAR_PRODUCTO_EXISTENTE(txtCODBARRA.Text))
            {
                if (!(accion == "M" && oPRODUCTO.cod_barra == txtCODBARRA.Text))
                {
                    MessageBox.Show("Este codigo ya esta registrado en el sistema");
                    return;
                }

            }

            if (accion == "M")
            {
                AGREGAR_AUDITORIA("MODIFICACION", oPRODUCTO);
            }
            
            oPRODUCTO.descripcion = txtDESCRIPCION.Text;
            oPRODUCTO.Marca = cmbMARCA.SelectedItem.ToString();
            oPRODUCTO.cod_proveedor = ((MODELO.PROVEEDOR)cmbPROVEEDOR.SelectedItem).cod_proveedor;
            oPRODUCTO.precio_unitario = Convert.ToDecimal(txtPRECIOUNITARIO.Text);
            oPRODUCTO.cod_barra = txtCODBARRA.Text;
            if (rdl.Checked == true)
            {
                oPRODUCTO.talle = "L";
            }
            else if (rdS.Checked == true)
            {
                oPRODUCTO.talle = "S";
            }
            else if (rdXS.Checked == true)
            {
                oPRODUCTO.talle = "XS";
            }
            else if (rdXL.Checked == true)
            {
                oPRODUCTO.talle = "XL";
            }
            else if (rdM.Checked == true)
            {
                oPRODUCTO.talle = "M";
            }
            else if (rdXXL.Checked == true)
            {
                oPRODUCTO.talle = "XXL";
            }
            oPRODUCTO.tipo_producto = txtTIPODEPRODUCTO.Text;
            oPRODUCTO.color = cmbCOLOR.SelectedItem.ToString();

            if (accion == "A")
            {
                oPRODUCTO.cantidad_Actual = 0;
                cPRODUCTOS.AGREGAR_PRODUCTOS(oPRODUCTO);
                AGREGAR_AUDITORIA("ALTA", oPRODUCTO);
            }
            else if(accion == "M")
            {
                cPRODUCTOS.MODIFICAR_PRODUCTOS(oPRODUCTO);
            }
           
            this.DialogResult = DialogResult.OK;
        }
        public void AGREGAR_AUDITORIA(string movimiento, MODELO.PRODUCTO oPRODUCTO)
        {
            MODELO.AUDITORIA_PRODUCTO a = new MODELO.AUDITORIA_PRODUCTO();
            a.cod_barra = oPRODUCTO.cod_barra;
            a.descripcion = oPRODUCTO.descripcion;
            a.cod_proveedor = oPRODUCTO.cod_proveedor;
            a.color = oPRODUCTO.color;
            a.tipo_producto = oPRODUCTO.tipo_producto;
            a.precio_unitario = oPRODUCTO.precio_unitario;
            a.talle = oPRODUCTO.talle;
            a.Marca = oPRODUCTO.Marca;
            a.fecha_hora = System.DateTime.Now;
            a.movimiento = movimiento;
            a.USUARIO = oUSUARIO;

            cPRODUCTOS.AGREGAR_AUDITORIA_PRODUCTOS(a);
        }
        private void txtPRECIOUNITARIO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtCODBARRA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
