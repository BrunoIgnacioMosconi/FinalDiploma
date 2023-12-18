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
    [MODELO.MODELO_DE_SEGURIDAD.ESTRUCTURA.formulario(CLASE = "frmEMPLEADOS", DESCRIPCION = "Empleados del sistema", MENU = true, MODULO = "Sistema", SEGURIDAD = true)]
    [MODELO.MODELO_DE_SEGURIDAD.ESTRUCTURA.accion(CONTROL = "btnELIMINAR", DESCRIPCION = "Eliminar empleados del sistema", FORMULARIO = "frmEMPLEADOS", FORMULARIO_DESCRIPCION = "Empleados del sistema", MODULO = "Sistema")]
    [MODELO.MODELO_DE_SEGURIDAD.ESTRUCTURA.accion(CONTROL = "btnMODIFICACIONES", DESCRIPCION = "Modificar datos del empleado", FORMULARIO = "frmEMPLEADOS", FORMULARIO_DESCRIPCION = "Empleados del sistema", MODULO = "Sistema")]
    [MODELO.MODELO_DE_SEGURIDAD.ESTRUCTURA.accion(CONTROL = "btnAGREGAR", DESCRIPCION = "Agregar empleados del sistema", FORMULARIO = "frmEMPLEADOS", FORMULARIO_DESCRIPCION = "Empleados del sistema", MODULO = "Sistema")]
    public partial class frmEMPLEADOS : Form
    {
        private static frmEMPLEADOS instancia;
        public static frmEMPLEADOS obtener_instancia(MODELO.USUARIO oUSUARIOS)
        {
            if (instancia == null)
            {
                instancia = new frmEMPLEADOS(oUSUARIOS);
            }
            if (instancia.IsDisposed)
            {
                instancia = new frmEMPLEADOS(oUSUARIOS);
            }
            return instancia;
        }
        CONTROLADORA.EMPLEADOS cEMPLEADOS;
        MODELO.EMPLEADO oEMPLEADO;
        public frmEMPLEADOS(MODELO.USUARIO oUSUARIO)
        {
            InitializeComponent();

            btnAGREGAR.Enabled = false;
            btnAGREGAR.Enabled = oUSUARIO.VALIDAR_ACCION("frmEMPLEADOS", "btnAGREGAR");
            btnELIMINAR.Enabled = oUSUARIO.VALIDAR_ACCION("frmEMPLEADOS", "btnELIMINAR");
            btnMODIFICACIONES.Enabled = oUSUARIO.VALIDAR_ACCION("frmEMPLEADOS", "btnMODIFICACIONES");
            cEMPLEADOS = CONTROLADORA.EMPLEADOS.ObtenerInstancia();
            ArmaGrilla("");
        }
        string accion;
        public frmEMPLEADOS(string MiAccion)
        {
            InitializeComponent();
            cEMPLEADOS = CONTROLADORA.EMPLEADOS.ObtenerInstancia();
            accion = MiAccion;
            ArmaGrilla("");
        }
         void ArmaGrilla(string nombre)
        {
            dgvEMPLEADO.DataSource = null;
            dgvEMPLEADO.DataSource = cEMPLEADOS.LISTAR_EMPLEADOS(nombre);
            dgvEMPLEADO.Columns[0].HeaderText = "ID Empleado";
            dgvEMPLEADO.Columns[1].HeaderText = "Nombre";
            dgvEMPLEADO.Columns[2].HeaderText = "Apellido";
            dgvEMPLEADO.Columns[3].HeaderText = "DNI";
            dgvEMPLEADO.Columns[4].HeaderText = "Direccion";
            dgvEMPLEADO.Columns[5].HeaderText = "Telefono";   
        }
        public MODELO.EMPLEADO ObtenerEmpleado
        {
            get { return oEMPLEADO; }

        }
        

        private void dgvEMPLEADO_DoubleClick(object sender, EventArgs e)
        {
            if (accion == "Buscar")
            {
                oEMPLEADO = cEMPLEADOS.BUSCAR_EMPLEADO((Convert.ToInt32(dgvEMPLEADO.CurrentRow.Cells[0].Value)));
                this.DialogResult = DialogResult.OK;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmEMPLEADO frm = new frmEMPLEADO(new MODELO.EMPLEADO(), "A");
            DialogResult respuesta = frm.ShowDialog();
            if (respuesta == DialogResult.OK)
            {
                ArmaGrilla("");
            }
        }

        private void btnMODIFICACIONES_Click(object sender, EventArgs e)
        {
            if (dgvEMPLEADO.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un empleado");
                return;
            }
            frmEMPLEADO frm = new frmEMPLEADO((MODELO.EMPLEADO)dgvEMPLEADO.CurrentRow.DataBoundItem, "M");
            DialogResult respuesta = frm.ShowDialog();
            if (respuesta == DialogResult.OK)
            {
                ArmaGrilla("");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvEMPLEADO.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un empleado");
                return;
            }
            MODELO.EMPLEADO oEMPLEADO = (MODELO.EMPLEADO)dgvEMPLEADO.CurrentRow.DataBoundItem;
            DialogResult respuesta = MessageBox.Show("Desea eliminar el empleado " + oEMPLEADO.nombre + oEMPLEADO.apellido, "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (respuesta == DialogResult.Yes)
            {
                cEMPLEADOS.ELIMINAR_EMPLEADOS(oEMPLEADO);
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

        private void frmEMPLEADOS_Load(object sender, EventArgs e)
        {

        }
    }
}
