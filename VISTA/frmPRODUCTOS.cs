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
    [MODELO.MODELO_DE_SEGURIDAD.ESTRUCTURA.formulario(CLASE = "frmPRODUCTOS", DESCRIPCION = "Productos del sistema", MENU = true, MODULO = "Sistema", SEGURIDAD = true)]
    [MODELO.MODELO_DE_SEGURIDAD.ESTRUCTURA.accion(CONTROL = "btnCONSULTAR", DESCRIPCION = "Consultar datos del producto", FORMULARIO = "frmPRODUCTOS", FORMULARIO_DESCRIPCION = "Productos del sistema", MODULO = "Sistema")]
    [MODELO.MODELO_DE_SEGURIDAD.ESTRUCTURA.accion(CONTROL = "btnAGREGAR", DESCRIPCION = "Agregar productos del sistema", FORMULARIO = "frmPRODUCTOS", FORMULARIO_DESCRIPCION = "Prdocutos del sistema", MODULO = "Sistema")]
    public partial class frmPRODUCTOS : Form
    {
        CONTROLADORA.PRODUCTOS cPRODUCTOS;
        MODELO.USUARIO oUSUARIOS;
        MODELO.PRODUCTO oPRODUCTO;
        private static frmPRODUCTOS instancia;
        public static frmPRODUCTOS obtener_instancia(MODELO.USUARIO oUSUARIO)

        {

            if (instancia == null)
            {
                instancia = new frmPRODUCTOS(oUSUARIO);
            }
            if (instancia.IsDisposed)
            {
                instancia = new frmPRODUCTOS(oUSUARIO);
            }
            return instancia;
        }
        public frmPRODUCTOS(MODELO.USUARIO oUSUARIO)
        {
           
          
            InitializeComponent();
            oUSUARIOS = oUSUARIO;
            btnAGREGAR.Enabled = false;
            btnAGREGAR.Enabled = oUSUARIO.VALIDAR_ACCION("frmPRODUCTOS", "btnAGREGAR");
            btnCONSULTAR.Enabled = oUSUARIO.VALIDAR_ACCION("frmPRODUCTOS", "btnCONSULTAR");

            cPRODUCTOS = CONTROLADORA.PRODUCTOS.ObtenerInstancia();           
            ARMA_GRILLA("");
        }
        string accion;
        public frmPRODUCTOS(string MiAccion)
        {

            InitializeComponent();         
            cPRODUCTOS = CONTROLADORA.PRODUCTOS.ObtenerInstancia();
            accion = MiAccion;
            ARMA_GRILLA("");
        }
        public MODELO.PRODUCTO ObteneroProducto
        {
            get { return oPRODUCTO; }

        }

        public void ARMA_GRILLA(string codigo)
        {
            dgvPRODUCTOS.DataSource = null;
            dgvPRODUCTOS.DataSource = cPRODUCTOS.LISTAR_PRODUCTOS(codigo);
            this.dgvPRODUCTOS.Columns[1].Visible = false;
            this.dgvPRODUCTOS.Columns[11].Visible = false;
            this.dgvPRODUCTOS.Columns[12].Visible = false;
            dgvPRODUCTOS.Columns[0].HeaderText = "ID Producto";
            dgvPRODUCTOS.Columns[2].HeaderText = "Descripcion";
            dgvPRODUCTOS.Columns[3].HeaderText = "Talle";
            dgvPRODUCTOS.Columns[5].HeaderText = "Precio unitario";
            dgvPRODUCTOS.Columns[6].HeaderText = "Tipo de producto";
            dgvPRODUCTOS.Columns[7].HeaderText = "Color";
            dgvPRODUCTOS.Columns[8].HeaderText = "Cantidad actual";
            dgvPRODUCTOS.Columns[9].HeaderText = "Codigo";

           

        }



        private void dgvPRODUCTOS_DoubleClick(object sender, EventArgs e)
        {
            if (accion == "Buscar")
            {
                oPRODUCTO = cPRODUCTOS.BUSCAR_PRODUCTO((Convert.ToInt32(dgvPRODUCTOS.CurrentRow.Cells[0].Value)));
                this.DialogResult = DialogResult.OK;
            }
        }
        private void btnSALIR_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmPRODUCTO frm = new frmPRODUCTO(new MODELO.PRODUCTO(), "A",oUSUARIOS );
            frm.ShowDialog();
            ARMA_GRILLA("");
        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCONSULTAR_Click(object sender, EventArgs e)
        {
           
        }

        private void btnCONSULTAR_Click_1(object sender, EventArgs e)
        {
            if (dgvPRODUCTOS.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un producto");
                return;
            }
            frmPRODUCTO frm = new frmPRODUCTO((MODELO.PRODUCTO)dgvPRODUCTOS.CurrentRow.DataBoundItem, "C", oUSUARIOS);
            DialogResult respuesta = frm.ShowDialog();
            if (respuesta == DialogResult.OK)
            {
                
                ARMA_GRILLA("");
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnBUSCAR_Click(object sender, EventArgs e)
        {
            ARMA_GRILLA(txtBUSCAR.Text);
        }

        private void txtBUSCAR_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnMODIFICACIONES_Click(object sender, EventArgs e)
        {
            if (dgvPRODUCTOS.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un producto");
                return;
            }
            frmPRODUCTO frm = new frmPRODUCTO((MODELO.PRODUCTO)dgvPRODUCTOS.CurrentRow.DataBoundItem,"M", oUSUARIOS);
            DialogResult respuesta = frm.ShowDialog();
            if (respuesta == DialogResult.OK)
            {
                ARMA_GRILLA("");
            }
        }
    }
}
