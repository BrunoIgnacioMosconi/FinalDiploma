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
    [MODELO.MODELO_DE_SEGURIDAD.ESTRUCTURA.formulario(CLASE = "frmORDENESDECOMPRA", DESCRIPCION = "Ordenes de compra del sistema", MENU = true, MODULO = "Sistema", SEGURIDAD = true)]
    [MODELO.MODELO_DE_SEGURIDAD.ESTRUCTURA.accion(CONTROL = "btnELIMINAR", DESCRIPCION = "Eliminar Ordenes de compra del sistema", FORMULARIO = "frmORDENESDECOMPRA", FORMULARIO_DESCRIPCION = "Ordenes de compra del sistema", MODULO = "Sistema")]
    [MODELO.MODELO_DE_SEGURIDAD.ESTRUCTURA.accion(CONTROL = "btnCONSULTAR", DESCRIPCION = "Consultar datos de la orden de compra", FORMULARIO = "frmORDENESDECOMPRA", FORMULARIO_DESCRIPCION = "Ordenes de compra del sistema", MODULO = "Sistema")]
    [MODELO.MODELO_DE_SEGURIDAD.ESTRUCTURA.accion(CONTROL = "btnAGREGAR", DESCRIPCION = "Agregar ordenes de compra del sistema", FORMULARIO = "frmORDENESDECOMPRA", FORMULARIO_DESCRIPCION = "Ordenes de compra del sistema", MODULO = "Sistema")]
    public partial class frmORDENESDECOMPRA : Form
    {
        private static frmORDENESDECOMPRA instancia;
        public static frmORDENESDECOMPRA obtener_instancia(MODELO.USUARIO oUSUARIO)
        
        {
            if (instancia == null)
            {
                instancia = new frmORDENESDECOMPRA(oUSUARIO);
            }
            if (instancia.IsDisposed)
            {
                instancia = new frmORDENESDECOMPRA(oUSUARIO);
            }
            return instancia;
        }
        CONTROLADORA.ORDENESDECOMPRA C_ODC;
        public frmORDENESDECOMPRA(MODELO.USUARIO oUSUARIO)
        {
            InitializeComponent();
            btnAGREGAR.Enabled = false;
            btnAGREGAR.Enabled = oUSUARIO.VALIDAR_ACCION("frmORDENESDECOMPRA", "btnAGREGAR");
            btnCONSULTAR.Enabled = oUSUARIO.VALIDAR_ACCION("frmORDENESDECOMPRA", "btnCONSULTAR");
            btnELIMINAR.Enabled = oUSUARIO.VALIDAR_ACCION("frmORDENESDECOMPRA", "btnELIMINAR");

            C_ODC = CONTROLADORA.ORDENESDECOMPRA.ObtenerInstancia();
            ArmaGrilla("");
        }
      
        private void ArmaGrilla(string proveedor)
        {
            dgvORDENES.DataSource = null;
            dgvORDENES.DataSource = C_ODC.LISTAR_ORDENDECOMPRA(proveedor);

            dgvORDENES.Columns[1].HeaderText = "Proveedor";
            dgvORDENES.Columns[0].HeaderText = "ID Orden";
            dgvORDENES.Columns[3].HeaderText = "Precio";
            dgvORDENES.Columns[4].HeaderText = "Fecha";
        
            this.dgvORDENES.Columns["ITEMS"].Visible = false;
            this.dgvORDENES.Columns["REMITOS"].Visible = false;

        }
        private void btnELIMINAR_Click(object sender, EventArgs e)
        {
            if (dgvORDENES.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una orden de compra");
                return;
            }
            MODELO.ORDENDECOMPRA oORDENES = (MODELO.ORDENDECOMPRA)dgvORDENES.CurrentRow.DataBoundItem;
            DialogResult respuesta = MessageBox.Show("Desea eliminar la orden de compra " , "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (respuesta == DialogResult.Yes)
            {
                C_ODC.ELIMINAR_ORDENESDECOMPRAS(oORDENES);
                ArmaGrilla("");
            }
        }

        private void btnMODIFICAR_Click(object sender, EventArgs e)
        {
            if (dgvORDENES.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una orden de compra");
                return;
            }
            frmORDENDECOMPRA frm = new frmORDENDECOMPRA((MODELO.ORDENDECOMPRA)dgvORDENES.CurrentRow.DataBoundItem, "M");
            DialogResult respuesta = frm.ShowDialog();
            if (respuesta == DialogResult.OK)
            {
                ArmaGrilla("");
            }
        }

        MODELO.PROVEEDOR BPROVEEDOR;
        private void button1_Click(object sender, EventArgs e)
        {
            frmPROVEEDORES frm = new frmPROVEEDORES("Buscar"); //DARLE DOBLE CLICK PARA QUE APAREZCA EN UN TEXTBOX DESDE UNA GRILLA
            DialogResult DR = frm.ShowDialog();
            if (DR == DialogResult.OK)
            {
                BPROVEEDOR = frm.ObtenerProveedor;
                txtBUSCAR.Text = BPROVEEDOR.nombre;
                txtBUSCAR.Enabled = false;
            }
        }

        private void dgvORDENES_DoubleClick(object sender, EventArgs e)
        {
            if (dgvORDENES.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una orden de compra");
                return;
            }
            frmORDENDECOMPRA frm = new frmORDENDECOMPRA((MODELO.ORDENDECOMPRA)dgvORDENES.CurrentRow.DataBoundItem, "C");
             frm.ShowDialog();          
        }

        private void btnALTAS_Click(object sender, EventArgs e)
        {
            frmORDENDECOMPRA frm = new frmORDENDECOMPRA(new MODELO.ORDENDECOMPRA(), "A");
            DialogResult respuesta = frm.ShowDialog();
            if (respuesta == DialogResult.OK)
            {
                ArmaGrilla("");
            }
        }

        private void btnBAJAS_Click(object sender, EventArgs e)
        {
            if (dgvORDENES.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una orden de compra");
                return;
            }
            MODELO.ORDENDECOMPRA oORDENES = (MODELO.ORDENDECOMPRA)dgvORDENES.CurrentRow.DataBoundItem;
            DialogResult respuesta = MessageBox.Show("Desea eliminar la orden de compra ", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (respuesta == DialogResult.Yes)
            {
                C_ODC.ELIMINAR_ORDENESDECOMPRAS(oORDENES);
                ArmaGrilla("");
            }
        }

        private void btnMODIFICACIONES_Click(object sender, EventArgs e)
        {
            if (dgvORDENES.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una orden de compra");
                return;
            }
            frmORDENDECOMPRA frm = new frmORDENDECOMPRA((MODELO.ORDENDECOMPRA)dgvORDENES.CurrentRow.DataBoundItem, "M");
            DialogResult respuesta = frm.ShowDialog();
            if (respuesta == DialogResult.OK)
            {
                ArmaGrilla("");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
            this.Close();
            
        }

        private void btnBUSCAR_Click(object sender, EventArgs e)
        {
            ArmaGrilla(txtBUSCAR.Text);

           
        }
    }
}
