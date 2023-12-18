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
    [MODELO.MODELO_DE_SEGURIDAD.ESTRUCTURA.formulario(CLASE = "frmAUDITORIA_LOGIN", DESCRIPCION = "Vista de logins", MENU = true, MODULO = "Sistema", SEGURIDAD = true)]
    [MODELO.MODELO_DE_SEGURIDAD.ESTRUCTURA.accion(CONTROL = "btnBUSCAR", DESCRIPCION = "Buscar login", FORMULARIO = "frmAUDITORIA_LOGIN", FORMULARIO_DESCRIPCION = "Logins del sistema", MODULO = "Sistema")]
    public partial class frmAUDITORIA_LOGIN : Form
    {
        CONTROLADORA.MODELO_DE_SEGURIDAD.LOGIN cINGRESO;
        private static frmAUDITORIA_LOGIN instancia;
        public static frmAUDITORIA_LOGIN obtener_instancia(MODELO.USUARIO oUSUARIO)
        {
            if (instancia == null)
            {
                instancia = new frmAUDITORIA_LOGIN(oUSUARIO);
            }
            if (instancia.IsDisposed)
            {
                instancia = new frmAUDITORIA_LOGIN(oUSUARIO);
            }
            return instancia;
        }
        public frmAUDITORIA_LOGIN(MODELO.USUARIO oUSUARIO)
        {
            InitializeComponent();
            cINGRESO = CONTROLADORA.MODELO_DE_SEGURIDAD.LOGIN.ObtenerInstancia();
            ArmarGrilla("");
        }
        public void ArmarGrilla(string nombre)
        {
            dgvAUDITORIA.DataSource = null;
            dgvAUDITORIA.DataSource = cINGRESO.OBTENER_LOGINS(nombre);

            dgvAUDITORIA.Columns[0].HeaderText = "ID Login";
            dgvAUDITORIA.Columns[1].HeaderText = "Usuario";
            dgvAUDITORIA.Columns[2].HeaderText = "Fecha de login";
            dgvAUDITORIA.Columns[3].HeaderText = "Fecha de logout";

        }

        private void btnBUSCAR_Click(object sender, EventArgs e)
        {
            ArmarGrilla(txtBUSCAR.Text);
        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
