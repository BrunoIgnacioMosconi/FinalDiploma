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

    [MODELO.MODELO_DE_SEGURIDAD.ESTRUCTURA.formulario(CLASE = "frmUSUARIOS", DESCRIPCION = "Usarios del sistema", MENU = true, MODULO = "Sistema", SEGURIDAD = true)]
    [MODELO.MODELO_DE_SEGURIDAD.ESTRUCTURA.accion(CONTROL = "btnELIMINAR", DESCRIPCION = "Eliminar usuarios del sistema", FORMULARIO = "frmUSUARIOS", FORMULARIO_DESCRIPCION = "Usarios del sistema", MODULO = "Sistema")]
    [MODELO.MODELO_DE_SEGURIDAD.ESTRUCTURA.accion(CONTROL = "btnMODIFICACIONES", DESCRIPCION = "Modificar datos del usuario", FORMULARIO = "frmUSUARIOS", FORMULARIO_DESCRIPCION = "Usarios del sistema", MODULO = "Sistema")]
    [MODELO.MODELO_DE_SEGURIDAD.ESTRUCTURA.accion(CONTROL = "btnAGREGAR", DESCRIPCION = "Agregar usuarios del sistema", FORMULARIO = "frmUSUARIOS", FORMULARIO_DESCRIPCION = "Usarios del sistema", MODULO = "Sistema")]
   
    public partial class frmUSUARIOS : Form
    {

      
        private static frmUSUARIOS instancia;
        public static frmUSUARIOS obtener_instancia(MODELO.USUARIO oUSUARIO)
        {
            if (instancia == null)
            {
                instancia = new frmUSUARIOS(oUSUARIO);
            }
            if (instancia.IsDisposed)
            {
                instancia = new frmUSUARIOS(oUSUARIO);
            }
            return instancia;
        }
        CONTROLADORA.USUARIOS cUSUARIOS;
     

        public frmUSUARIOS(MODELO.USUARIO oUSUARIO)
        {
            InitializeComponent();
            btnAGREGAR.Enabled = false;
            btnAGREGAR.Enabled = oUSUARIO.VALIDAR_ACCION("frmUSUARIOS", "btnAGREGAR");
            btnMODIFICACIONES.Enabled = oUSUARIO.VALIDAR_ACCION("frmUSUARIOS", "btnMODIFICACIONES");          
            btnELIMINAR.Enabled = oUSUARIO.VALIDAR_ACCION("frmUSUARIOS", "btnELIMINAR");

            cUSUARIOS = CONTROLADORA.USUARIOS.ObtenerInstancia();
            ArmaGrilla("");

        }
       
        
        private void ArmaGrilla(string mail)
        {
            dgvUSUARIO.DataSource = null;
            dgvUSUARIO.DataSource = cUSUARIOS.LISTAR_USUARIOS(mail);
            this.dgvUSUARIO.Columns["GRUPOs"].Visible = false;
            this.dgvUSUARIO.Columns["Contraseña"].Visible = false;
        }
       

        private void btnAGREGAR_Click_1(object sender, EventArgs e)
        {
            frmUSUARIO frmUSUARIO = new frmUSUARIO(new MODELO.USUARIO(),"A" );
            if (frmUSUARIO.ShowDialog() == DialogResult.OK)
                ArmaGrilla("");
        }

        private void btnMODIFICACIONES_Click(object sender, EventArgs e)
        {
            if (dgvUSUARIO.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un usuario");
                return;
            }
            frmUSUARIO frm = new frmUSUARIO(cUSUARIOS.ObtenerUsuario(Convert.ToInt32(dgvUSUARIO.CurrentRow.Cells[0].Value)), "M");
            DialogResult respuesta = frm.ShowDialog();
            if (respuesta == DialogResult.OK)
            {
                ArmaGrilla("");
            }
        }

        private void btnELIMINAR_Click(object sender, EventArgs e)
        {
            if (dgvUSUARIO.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un usuario");
                return;
            }
            MODELO.USUARIO oUSUARIO = cUSUARIOS.ObtenerUsuario(Convert.ToInt32(dgvUSUARIO.CurrentRow.Cells[0].Value));
            DialogResult respuesta = MessageBox.Show("Desea inhabilitar el usuario " + oUSUARIO.Nombre , "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (respuesta == DialogResult.Yes)
            {
                cUSUARIOS.ELIMINAR_USUARIOS(oUSUARIO);
                ArmaGrilla("");
            }
        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBUSCAR_Click(object sender, EventArgs e)
        {
            ArmaGrilla(txtMAIL.Text);
        }
    }
}
