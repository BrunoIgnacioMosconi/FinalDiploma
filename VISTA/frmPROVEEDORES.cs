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
    [MODELO.MODELO_DE_SEGURIDAD.ESTRUCTURA.formulario(CLASE = "frmPROVEEDORES", DESCRIPCION = "Proveedores del sistema", MENU = true, MODULO = "Sistema", SEGURIDAD = true)]
    [MODELO.MODELO_DE_SEGURIDAD.ESTRUCTURA.accion(CONTROL = "btnnELIMINAR", DESCRIPCION = "Eliminar proveedores del sistema", FORMULARIO = "frmPROVEEDORES", FORMULARIO_DESCRIPCION = "Proveedores del sistema", MODULO = "Sistema")]
    [MODELO.MODELO_DE_SEGURIDAD.ESTRUCTURA.accion(CONTROL = "btnMODIFICACIONES", DESCRIPCION = "Modificar datos del proveedor", FORMULARIO = "frmPROVEEDORES", FORMULARIO_DESCRIPCION = "Proveedores del sistema", MODULO = "Sistema")]
    [MODELO.MODELO_DE_SEGURIDAD.ESTRUCTURA.accion(CONTROL = "btnAGREGAR", DESCRIPCION = "Agregar proveedores del sistema", FORMULARIO = "frmPROVEEDORES", FORMULARIO_DESCRIPCION = "Proveedores del sistema", MODULO = "Sistema")]
    public partial class frmPROVEEDORES : Form
    {
        private static frmPROVEEDORES instancia;
        public static frmPROVEEDORES obtener_instancia(MODELO.USUARIO oUSUARIO)
        {
            if (instancia == null)
            {
                instancia = new frmPROVEEDORES( oUSUARIO);
            }
            if (instancia.IsDisposed)
            {
                instancia = new frmPROVEEDORES( oUSUARIO);
            }
            return instancia;
        }
        CONTROLADORA.PROVEEDORES cPROVEEDORES;
        MODELO.PROVEEDOR oPROVEEDOR;
        public frmPROVEEDORES(MODELO.USUARIO oUSUARIO)
        {
            InitializeComponent();
            btnAGREGAR.Enabled = false;
            btnAGREGAR.Enabled = oUSUARIO.VALIDAR_ACCION("frmPROVEEDORES", "btnAGREGAR");
            btnMODIFICACIONES.Enabled = oUSUARIO.VALIDAR_ACCION("frmPROVEEDORES", "btnMODIFICACIONES");
            btnELIMINAR.Enabled = oUSUARIO.VALIDAR_ACCION("frmPROVEEDORES", "btnELIMINAR");

            cPROVEEDORES = CONTROLADORA.PROVEEDORES.ObtenerInstancia();
            ArmaGrilla("");
        }
        string accion;
        public frmPROVEEDORES(string miAccion)
        {
            InitializeComponent();
            cPROVEEDORES = CONTROLADORA.PROVEEDORES.ObtenerInstancia();
            accion = miAccion;

            ArmaGrilla("");

        }
        public MODELO.PROVEEDOR ObtenerProveedor
        {
            get { return oPROVEEDOR; }

        }

        public void ArmaGrilla(string nombre)
        {
            dgvPROVEEDOR.DataSource = null;
            dgvPROVEEDOR.DataSource = cPROVEEDORES.LISTAR_PROVEEDORES(nombre);
            dgvPROVEEDOR.Columns[0].HeaderText = "ID Proveedor";
            dgvPROVEEDOR.Columns[1].HeaderText = "Nombre";
            dgvPROVEEDOR.Columns[2].HeaderText = "Apellido";
            dgvPROVEEDOR.Columns[3].HeaderText = "Direccion";
            dgvPROVEEDOR.Columns[4].HeaderText = "Localidad";
            dgvPROVEEDOR.Columns[5].HeaderText = "Email";
            dgvPROVEEDOR.Columns[6].HeaderText = "Telefono";

          
        }


        private void bntAGREGAR_Click(object sender, EventArgs e)
        {
            frmPROVEEDOR frmPROVEEDOR = new frmPROVEEDOR("A", new MODELO.PROVEEDOR());
            if (frmPROVEEDOR.ShowDialog() == DialogResult.OK)
                ArmaGrilla("");

        }

        private void btnMODIFICACIONES_Click(object sender, EventArgs e)
        {
            if (dgvPROVEEDOR.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un proveedor");
                return;
            }
            frmPROVEEDOR frm = new frmPROVEEDOR("M", (MODELO.PROVEEDOR)dgvPROVEEDOR.CurrentRow.DataBoundItem);
            DialogResult respuesta = frm.ShowDialog();
            if (respuesta == DialogResult.OK)
            {
                ArmaGrilla("");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvPROVEEDOR.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un proveedor");
                return;
            }
            MODELO.PROVEEDOR oPROVEEDOR = (MODELO.PROVEEDOR)dgvPROVEEDOR.CurrentRow.DataBoundItem;
            DialogResult respuesta = MessageBox.Show("Desea eliminar el cliente " + oPROVEEDOR.nombre, "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (respuesta == DialogResult.Yes)
            {
                cPROVEEDORES.ELIMINAR_PROVEEDORES(oPROVEEDOR);
                ArmaGrilla("");
            }
        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBUSCAR_Click(object sender, EventArgs e)
        {
            ArmaGrilla(txtBUSCAR.Text);
        }
    }
}
