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
    [MODELO.MODELO_DE_SEGURIDAD.ESTRUCTURA.formulario(CLASE = "frmCLIENTES", DESCRIPCION = "Clientes del sistema", MENU = true, MODULO = "Sistema", SEGURIDAD = true)]
    [MODELO.MODELO_DE_SEGURIDAD.ESTRUCTURA.accion(CONTROL = "btnELIMINAR", DESCRIPCION = "Eliminar Clientes del sistema", FORMULARIO = "frmCLIENTES", FORMULARIO_DESCRIPCION = "Clientes del sistema", MODULO = "Sistema")]
    [MODELO.MODELO_DE_SEGURIDAD.ESTRUCTURA.accion(CONTROL = "btnMODIFICACIONES", DESCRIPCION = "Modificar datos del cliente", FORMULARIO = "frmCLIENTES", FORMULARIO_DESCRIPCION = "Clientes del sistema", MODULO = "Sistema")]
    [MODELO.MODELO_DE_SEGURIDAD.ESTRUCTURA.accion(CONTROL = "btnAGREGAR", DESCRIPCION = "Agregar clientes del sistema", FORMULARIO = "frmCLIENTES", FORMULARIO_DESCRIPCION = "Clientes del sistema", MODULO = "Sistema")]
    public partial class frmCLIENTES : Form
    {
        private static frmCLIENTES instancia;
        public static frmCLIENTES obtener_instancia(MODELO.USUARIO oUSUARIO)
        {
            if (instancia == null)
            {
                instancia = new frmCLIENTES(oUSUARIO);
            }
            if (instancia.IsDisposed)
            {
                instancia = new frmCLIENTES(oUSUARIO);
            }
            return instancia;
        }
        CONTROLADORA.CLIENTES cCLIENTES;
        MODELO.CLIENTE oCLIENTE;
        public frmCLIENTES(MODELO.USUARIO oUSUARIO)
        {
            InitializeComponent();
                
            btnELIMINAR.Enabled = oUSUARIO.VALIDAR_ACCION("frmCLIENTES", "btnELIMINAR");
            btnMODIFICACIONES.Enabled = oUSUARIO.VALIDAR_ACCION("frmCLIENTES", "btnMODIFICACIONES");
            btnAGREGAR.Enabled = false;
            btnAGREGAR.Enabled = oUSUARIO.VALIDAR_ACCION("frmCLIENTES", "btnAGREGAR");


            cCLIENTES = CONTROLADORA.CLIENTES.ObtenerInstancia();
            ArmaGrilla();
        }
        string accion;
        public frmCLIENTES(string MiAccion)
        {
            InitializeComponent();
            cCLIENTES = CONTROLADORA.CLIENTES.ObtenerInstancia();
            accion = MiAccion;
            ArmaGrilla();
        }
        public MODELO.CLIENTE ObtenerCliente
        {
            get { return oCLIENTE; }

        }
        private void ArmaGrilla()
        {
            dgvCLIENTE.DataSource = null;
            dgvCLIENTE.DataSource = cCLIENTES.LISTAR_CLIENTES();
            dgvCLIENTE.Columns[0].HeaderText = "ID Cliente";
            dgvCLIENTE.Columns[1].HeaderText = "Nombre";
            dgvCLIENTE.Columns[2].HeaderText = "Apellido";
            dgvCLIENTE.Columns[3].HeaderText = "Localidad";
            dgvCLIENTE.Columns[4].HeaderText = "Direccion";
            dgvCLIENTE.Columns[5].HeaderText = "Telefono";

        }


        private void txtBUSCAR_CLIENTE_KeyPress(object sender, KeyPressEventArgs e)
        {
            dgvCLIENTE.DataSource = null;
            dgvCLIENTE.DataSource = cCLIENTES.BUSCAR_CLIENTE(txtBUSCAR_CLIENTE.Text);
            if (txtBUSCAR_CLIENTE.Text == "")
            {
                ArmaGrilla();
            }
        }

        private void dgvCLIENTE_DoubleClick(object sender, EventArgs e)
        {
            if (accion == "Buscar")
            {
                oCLIENTE = cCLIENTES.BUSCAR_CLIEN((Convert.ToInt32(dgvCLIENTE.CurrentRow.Cells[0].Value))); ;
                this.DialogResult = DialogResult.OK;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmCLIENTE frmCLIENTE = new frmCLIENTE("A", new MODELO.CLIENTE());
            if (frmCLIENTE.ShowDialog() == DialogResult.OK)
                ArmaGrilla();
        }

        private void btnMODIFICACIONES_Click(object sender, EventArgs e)
        {
            if (dgvCLIENTE.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un cliente");
                return;
            }
            frmCLIENTE frm = new frmCLIENTE("M", (MODELO.CLIENTE)dgvCLIENTE.CurrentRow.DataBoundItem);
            DialogResult respuesta = frm.ShowDialog();
            if (respuesta == DialogResult.OK)
            {
                ArmaGrilla();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvCLIENTE.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un cliente");
                return;
            }
            MODELO.CLIENTE oCLIENTE = (MODELO.CLIENTE)dgvCLIENTE.CurrentRow.DataBoundItem;
            DialogResult respuesta = MessageBox.Show("Desea eliminar el cliente " + oCLIENTE.nombre + oCLIENTE.apellido, "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (respuesta == DialogResult.Yes)
            {
                cCLIENTES.ELIMINAR_CLIENTES(oCLIENTE);
                ArmaGrilla();
            }
        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        private void ARMA_GRILLA2()
        {
            dgvCLIENTE.DataSource = null;
            dgvCLIENTE.DataSource = cCLIENTES.BUSCAR_CLIENTE(txtBUSCAR_CLIENTE.Text);
            if (dgvCLIENTE.Rows.Count > 1)
            {
                dgvCLIENTE.Focus();
            }
        }

        private void btnBUSCAR_Click_1(object sender, EventArgs e)
        {
            ARMA_GRILLA2();
        }
    }
}
