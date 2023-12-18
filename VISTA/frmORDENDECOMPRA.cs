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
    public partial class frmORDENDECOMPRA : Form
    {
        CONTROLADORA.ORDENESDECOMPRA cORDENES;
        string accion;
        MODELO.ITEM_OC oITEM;
        MODELO.PRODUCTO BPRODUCTO { get; set; }
        MODELO.ORDENDECOMPRA oORDENES;

        public frmORDENDECOMPRA(string MiAccion)
        {
            InitializeComponent();
            accion = MiAccion;
            cORDENES = CONTROLADORA.ORDENESDECOMPRA.ObtenerInstancia();

        }

        public frmORDENDECOMPRA(MODELO.ORDENDECOMPRA MiOrden, string MiAccion)
        {
            InitializeComponent();
            cmbPROVEEDOR.Text = "Seleccionar";
            accion = MiAccion;
            oORDENES = MiOrden;
            cORDENES = CONTROLADORA.ORDENESDECOMPRA.ObtenerInstancia();
            cmbPROVEEDOR.DataSource = cORDENES.obtenerProveedores();
            txtTOTAL.Enabled = false;
            
           
            if (accion != "A")
            {
                cmbPROVEEDOR.SelectedItem = oORDENES.cod_proveedor;
                dtpFECHA.Value = oORDENES.fecha;
                ARMA_GRILLA(oORDENES);
                txtTOTAL.Text = oORDENES.precio.ToString();
            }
            if (accion == "M")
            {
                btnGUARDAR.Enabled = false;
                cmbPROVEEDOR.Enabled = false;
                txtPRODUCTO.Enabled = false;
                txt_CANTIDAD.Enabled = false;
                dtpFECHA.Enabled = false;
                btnAGREGAR.Enabled = false;
                btnELIMINAR.Enabled = false;
                btnBUSCARPRODUCTO.Enabled = false;




            }


        }
       public void cargar()
        {
            cmbPROVEEDOR.Items.Add("Seleccionar");
            cmbPROVEEDOR.SelectedItem = "Seleccionar";

        }
        public void ARMA_GRILLA(MODELO.ORDENDECOMPRA oORDENES)
        {
            dgvORDENESDECOMPRAS.DataSource = null;
            dgvORDENESDECOMPRAS.DataSource = cORDENES.ObtenerItems(oORDENES);

            this.dgvORDENESDECOMPRAS.Columns["oORDEN"].Visible = false;

        }
        public void ARMA_GRILLA()
        {
            dgvORDENESDECOMPRAS.DataSource = null;
            dgvORDENESDECOMPRAS.DataSource = oORDENES.ITEMS.ToList();

            this.dgvORDENESDECOMPRAS.Columns["cod_item"].Visible = false;
            this.dgvORDENESDECOMPRAS.Columns["Observador"].Visible = false;
            this.dgvORDENESDECOMPRAS.Columns["oORDEN"].Visible = false;
        }

        private void btnBUSCARPRODUCTO_Click_1(object sender, EventArgs e)
        {

            frmPRODUCTOS frm = new frmPRODUCTOS("Buscar"); //DARLE DOBLE CLICK PARA QUE APAREZCA EN UN TEXTBOX DESDE UNA GRILLA
            DialogResult DR = frm.ShowDialog();
            if (DR == DialogResult.OK)
            {
                BPRODUCTO = frm.ObteneroProducto;
                txtPRODUCTO.Text = BPRODUCTO.descripcion + " " + BPRODUCTO.Marca;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cmbPROVEEDOR.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un proveedor", "Ingresar proveedor", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_CANTIDAD.Text))
            {
                MessageBox.Show("Debe ingresar una cantidad", "Ingresar cantidad", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPRODUCTO.Text))
            {
                MessageBox.Show("Debe ingresar un producto", "Ingresar producto", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }
            oORDENES.cod_proveedor = (MODELO.PROVEEDOR)cmbPROVEEDOR.SelectedItem;
            oORDENES.fecha = dtpFECHA.Value;
            oORDENES.precio = Convert.ToDecimal(txtTOTAL.Text);
            oORDENES.Estado = "PENDIENTE";
            if (accion == "A")
            {
                cORDENES.AGREGAR_ORDENESDECOMPRAS(oORDENES);
            }
            else
            {
                cORDENES.MODIFICAR_ORDENESDECOMPRAS(oORDENES);
            }
            this.DialogResult = DialogResult.OK;
        }
        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        private void btnBUSCARPRODUCTO_Click(object sender, EventArgs e)
        {
            frmPRODUCTOS frm = new frmPRODUCTOS("Buscar"); //DARLE DOBLE CLICK PARA QUE APAREZCA EN UN TEXTBOX DESDE UNA GRILLA
            DialogResult DR = frm.ShowDialog();
            if (DR == DialogResult.OK)
            {
                BPRODUCTO = frm.ObteneroProducto;
                txtPRODUCTO.Text = BPRODUCTO.descripcion;
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAGREGAR_Click_1(object sender, EventArgs e)
        {
            if (cmbPROVEEDOR.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un proveedor");
                return;
            }
            int CANTIDAD;
            if (!int.TryParse(txt_CANTIDAD.Text, out CANTIDAD))
            {
                MessageBox.Show("Debe ingresar una cantidad");
                return;
            }
            if (BPRODUCTO == null)
            {

                MessageBox.Show("Debe ingresar un producto");
                return;
            }
            oITEM = new MODELO.ITEM_OC();
            oITEM.Producto = BPRODUCTO;          
            oITEM.cantidad = CANTIDAD;
            oITEM.precio_unitario_compra = BPRODUCTO.precio_unitario;
            oORDENES.ITEMS.Add(oITEM);
            ARMA_GRILLA();
            decimal total = 0;
            foreach (DataGridViewRow row in dgvORDENESDECOMPRAS.Rows)
            {
                total += Convert.ToDecimal(row.Cells["subtotal_compra"].Value);
            }
            txtTOTAL.Text = total.ToString();
        }

        private void btnELIMINAR_Click_1(object sender, EventArgs e)
        {
            if (dgvORDENESDECOMPRAS.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un producto");
                return;
            }
            decimal total = decimal.Parse(txtTOTAL.Text) - oITEM.subtotal_compra;
           
            txtTOTAL.Text = total.ToString();
            oORDENES.ITEMS.Remove(oITEM);
            ARMA_GRILLA(oORDENES);
        }

       

        private void txt_CANTIDAD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

       

        
    }
}
