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
    [MODELO.MODELO_DE_SEGURIDAD.ESTRUCTURA.formulario(CLASE = "frmGRUPOS", DESCRIPCION = "Grupos del sistema", MENU = true, MODULO = "Sistema", SEGURIDAD = true)]
    [MODELO.MODELO_DE_SEGURIDAD.ESTRUCTURA.accion(CONTROL = "btnELIMINAR", DESCRIPCION = "Eliminar grupos del sistema", FORMULARIO = "frmGRUPOS", FORMULARIO_DESCRIPCION = "Grupos del sistema", MODULO = "Sistema")]
    [MODELO.MODELO_DE_SEGURIDAD.ESTRUCTURA.accion(CONTROL = "btnMODIFICACIONES", DESCRIPCION = "Modificar datos del grupo", FORMULARIO = "frmGRUPOS", FORMULARIO_DESCRIPCION = "Grupos del sistema", MODULO = "Sistema")]
    [MODELO.MODELO_DE_SEGURIDAD.ESTRUCTURA.accion(CONTROL = "btnAGREGAR", DESCRIPCION = "Agregar grupos del sistema", FORMULARIO = "frmGRUPOS", FORMULARIO_DESCRIPCION = "Grupos del sistema", MODULO = "Sistema")]

    public partial class frmGRUPOS : Form
    {
        private static frmGRUPOS instancia;
        public static frmGRUPOS obtener_instancia(MODELO.USUARIO oUSUARIO)
        {
            if (instancia == null)
            {
                instancia = new frmGRUPOS(oUSUARIO);
            }
            if (instancia.IsDisposed)
            {
                instancia = new frmGRUPOS(oUSUARIO);
            }
            return instancia;
        }
        CONTROLADORA.GRUPOS cGRUPOS;
        //MODELO.GRUPO oGRUPOS;
        private frmGRUPOS(MODELO.USUARIO oUSUARIO)
        {
            InitializeComponent();
            btnAGREGAR.Enabled = false;
            btnAGREGAR.Enabled = oUSUARIO.VALIDAR_ACCION("frmGRUPOS", "btnAGREGAR");
            btnELIMINAR.Enabled = oUSUARIO.VALIDAR_ACCION("frmGRUPOS", "btnELIMINAR");
            btnMODIFICACIONES.Enabled = oUSUARIO.VALIDAR_ACCION("frmGRUPOS", "btnMODIFICACIONES");

            cGRUPOS = CONTROLADORA.GRUPOS.ObtenerInstancia();
            ArmaGrilla("");
        }
        private void ArmaGrilla(string nombre)
        {
            dgvGRUPOS.DataSource = null;
            dgvGRUPOS.DataSource = cGRUPOS.LISTAR_GRUPOS(nombre);
            this.dgvGRUPOS.Columns["USUARIOS"].Visible = false;
            this.dgvGRUPOS.Columns["ACCIONES"].Visible = false;
        }

        private void btnAGREGAR_Click(object sender, EventArgs e)
        {
            frmGRUPO frmGRUPO = new frmGRUPO(new MODELO.GRUPO(), "A");
            if (frmGRUPO.ShowDialog() == DialogResult.OK)
                ArmaGrilla("");
        }

        private void btnMODIFICACIONES_Click(object sender, EventArgs e)
        {
            if (dgvGRUPOS.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un grupo");
                return;
            }
            frmGRUPO frm = new frmGRUPO((MODELO.GRUPO)dgvGRUPOS.CurrentRow.DataBoundItem, "M");
            DialogResult respuesta = frm.ShowDialog();
            if (respuesta == DialogResult.OK)
            {
                ArmaGrilla("");
            }
        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnELIMINAR_Click(object sender, EventArgs e)
        {
            if (dgvGRUPOS.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un grupo");
                return;
            }
            MODELO.GRUPO oGRUPO = (MODELO.GRUPO)dgvGRUPOS.CurrentRow.DataBoundItem;
            if (oGRUPO.USUARIOS.Count < 0)
            {
                MessageBox.Show("El grupo ya posee usuarios asignados");
                return;
            }
            DialogResult respuesta = MessageBox.Show("Desea eliminar un grupo " + oGRUPO.NOMBRE , "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);



            if (respuesta == DialogResult.Yes)
            {
                cGRUPOS.ELIMINAR_GRUPOS(oGRUPO);
                ArmaGrilla("");
            }
        }

        private void btnBUSCAR_Click(object sender, EventArgs e)
        {
            ArmaGrilla(txtBUSCAR.Text);
        }
    }
}
