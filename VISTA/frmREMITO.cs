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
    public partial class frmREMITO : Form
    {

        MODELO.REMITO oREMITO;
        MODELO.ORDENDECOMPRA oORDEN;
        CONTROLADORA.REMITOS C_REMITO;
        CONTROLADORA.ORDENESDECOMPRA C_ORDEN;
        public frmREMITO(MODELO.REMITO MiRemito)
        {
            InitializeComponent();
            oREMITO = MiRemito;
            C_REMITO = CONTROLADORA.REMITOS.ObtenerInstancia();
          
            ArmaGrilla(oREMITO);
        }
        public frmREMITO(MODELO.ORDENDECOMPRA MiOrden)
        {
            InitializeComponent();
            oORDEN = MiOrden;
            C_REMITO = CONTROLADORA.REMITOS.ObtenerInstancia();
            C_ORDEN = CONTROLADORA.ORDENESDECOMPRA.ObtenerInstancia();

            oREMITO = new MODELO.REMITO();
            foreach (MODELO.ITEM_REMITO i in C_REMITO.CalcularItemsFaltantes(oORDEN))
            {
                MODELO.ITEM_REMITO Items = new MODELO.ITEM_REMITO();
                Items.cantidad = i.cantidad;
                Items.Producto = i.Producto;
                Items.precio_unitario_remito = i.precio_unitario_remito;
                C_REMITO.AGREGAR_ITEMS(Items);
                oREMITO.ITEMS.Add(Items);
            }
     
            ArmaGrilla();
        }
       
       public void ArmaGrilla(MODELO.REMITO oREMITO)
        {
            dgvPRODUCTO_ORDEN.DataSource = null;
            dgvPRODUCTO_ORDEN.DataSource = C_REMITO.ObtenerItems(oREMITO);
            this.dgvPRODUCTO_ORDEN.Columns["oREMITO"].Visible = false;
            
            this.dgvPRODUCTO_ORDEN.Columns["Observador"].Visible = false;
            txtTOTAL.Text = calcularTotal().ToString();
            dtpFECHA.Value = oREMITO.fecha;

            txtTOTAL.Enabled = false;
            txtUNIDAD.Enabled = false;
            dtpFECHA.Enabled = false;
            btnGUARDAR.Enabled = false;
            btnELIMINAR.Enabled = false;
            
        }

        private void ArmaGrilla()
        {
            dgvPRODUCTO_ORDEN.DataSource = null;
            dgvPRODUCTO_ORDEN.DataSource = oREMITO.ITEMS.ToList();
            txtTOTAL.Text = calcularTotal().ToString();
            this.dgvPRODUCTO_ORDEN.Columns["oREMITO"].Visible = false;
            this.dgvPRODUCTO_ORDEN.Columns["Observador"].Visible = false;

        }
        public decimal calcularTotal()
        {
            decimal total = 0;
            foreach (var item in oREMITO.ITEMS)
            {
                total += item.subtotal_remito;
            }
            return total;
        }
      

        private void btnELIMINAR_Click(object sender, EventArgs e)
        {
            if (dgvPRODUCTO_ORDEN.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una orden");
                return;
            }

            MODELO.ITEM_REMITO oITEM = (MODELO.ITEM_REMITO)dgvPRODUCTO_ORDEN.CurrentRow.DataBoundItem;
            if (txtUNIDAD.Text == "")
            {
                MessageBox.Show("Debe ingresar una cantidad");
                return;
            }
            if (oITEM.cantidad < Convert.ToInt32(txtUNIDAD.Text))
            {
                MessageBox.Show("No se puede disminuir esa cantidad");
                return;
            }
            else if (oITEM.cantidad == Convert.ToInt32(txtUNIDAD.Text))
            {
                oREMITO.ITEMS.Remove(oITEM);
            }
            else
            {
                oITEM.cantidad -= Convert.ToInt32(txtUNIDAD.Text);
            }
           
            ArmaGrilla();
        }

        private void btnGUARDAR_Click(object sender, EventArgs e)
        {
            oREMITO.oORDENESDECOMPRA = oORDEN;
            oREMITO.fecha = dtpFECHA.Value;
            oREMITO.total = decimal.Parse(txtTOTAL.Text);


           
            C_REMITO.AGREGAR_PRODUCTOSORDENES(oREMITO);
            C_REMITO.AumentarStock(oREMITO);
            if (ValidarEstado(oORDEN))
            {
                oORDEN.Estado = "ENTREGADO";
            }
            else
            {
                oORDEN.Estado = "ENTREGA NO COMPLETADA";
            }
            C_ORDEN.MODIFICAR_ORDENESDECOMPRAS(oORDEN);
            this.DialogResult = DialogResult.OK;

        }

        private void txtUNIDAD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        public bool ValidarEstado(MODELO.ORDENDECOMPRA oORDEN)
        {                    
            bool a = true;
            foreach (MODELO.ITEM_REMITO item in C_REMITO.CalcularItemsFaltantes(oORDEN))
            {
                if (item.cantidad != 0)
                {
                    a = false;
                }
            }
            return a;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
