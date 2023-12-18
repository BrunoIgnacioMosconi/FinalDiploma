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
    [MODELO.MODELO_DE_SEGURIDAD.ESTRUCTURA.formulario(CLASE = "frmMOSTRAR_REMITOS", DESCRIPCION = "Remitos del sistema", MENU = true, MODULO = "Sistema", SEGURIDAD = true)]
    [MODELO.MODELO_DE_SEGURIDAD.ESTRUCTURA.accion(CONTROL = "btnCONSULTAR", DESCRIPCION = " Consultar remito detallado", FORMULARIO = "frmMOSTRAR_REMITOS", FORMULARIO_DESCRIPCION = "Remitos del sistema", MODULO = "Sistema")]
    public partial class frmMOSTRAR_REMITOS : Form
    {
        private static frmMOSTRAR_REMITOS instancia;
        public static frmMOSTRAR_REMITOS obtener_instancia(MODELO.USUARIO oUSUARIO)
        {
            if (instancia == null)
            {
                instancia = new frmMOSTRAR_REMITOS(oUSUARIO);
            }
            if (instancia.IsDisposed)
            {
                instancia = new frmMOSTRAR_REMITOS(oUSUARIO);
            }
            return instancia;
        }
        CONTROLADORA.REMITOS C_REMITOS;
        public frmMOSTRAR_REMITOS(MODELO.USUARIO oUSUARIO)
        {
            InitializeComponent();
            C_REMITOS = CONTROLADORA.REMITOS.ObtenerInstancia();
            ArmaGrilla(Convert.ToDateTime("10/10/2050"));
        }

        public void ArmaGrilla(DateTime Fecha)
        {
            dgvREMITOS.DataSource = null;
            dgvREMITOS.DataSource = C_REMITOS.ObtenerRemitos(Fecha);

            dgvREMITOS.Columns[0].HeaderText = "ID remito";
            dgvREMITOS.Columns[1].HeaderText = "Fecha";
            dgvREMITOS.Columns[2].HeaderText = ".";
            
        }

        private void btn_CONSULTAR_Click(object sender, EventArgs e)
        {
            if (dgvREMITOS.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un remito");
                return;
            }
            frmREMITO frm = new frmREMITO((MODELO.REMITO)dgvREMITOS.CurrentRow.DataBoundItem);
            frm.ShowDialog();
        }

        private void btnBUSCAR_Click(object sender, EventArgs e)
        {
            ArmaGrilla(dtpFECHA.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
