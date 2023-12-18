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
    [MODELO.MODELO_DE_SEGURIDAD.ESTRUCTURA.formulario(CLASE = "frmSTOCK", DESCRIPCION = "Stock del sistema", MENU = true, MODULO = "Sistema", SEGURIDAD = true)]
    [MODELO.MODELO_DE_SEGURIDAD.ESTRUCTURA.accion(CONTROL = "btnAUMENTAR", DESCRIPCION = "Aumentar stock del sistema", FORMULARIO = "frmSTOCK", FORMULARIO_DESCRIPCION = "Stock del sistema", MODULO = "Sistema")]
    public partial class frmSTOCK : Form
    {
        private static frmSTOCK instancia;
        public static frmSTOCK obtener_instancia(MODELO.USUARIO oUSUARIO)
        {
            if (instancia == null)
            {
                instancia = new frmSTOCK(oUSUARIO);
            }
            if (instancia.IsDisposed)
            {
                instancia = new frmSTOCK(oUSUARIO);
            }
            return instancia;
        }
        CONTROLADORA.ORDENESDECOMPRA C_ODC;
        MODELO.ORDENDECOMPRA oORDENES;
        public frmSTOCK(MODELO.USUARIO oUSUARIO)
        {
            InitializeComponent();
            oORDENES = new MODELO.ORDENDECOMPRA();
            C_ODC = CONTROLADORA.ORDENESDECOMPRA.ObtenerInstancia();

            ArmaGrilla();
        }
        private void ArmaGrilla()
        {
            dgvSTOCK.DataSource = null;
            dgvSTOCK.DataSource = C_ODC.LISTAR_ORDENDECOMPRA("");

            dgvSTOCK.Columns[1].HeaderText = "Proveedor";
            this.dgvSTOCK.Columns["ITEMS"].Visible = false;
            this.dgvSTOCK.Columns["REMITOS"].Visible = false;

        }
        private void btnAUMENTAR_Click(object sender, EventArgs e)
        {

            MODELO.ORDENDECOMPRA oORDENES = (MODELO.ORDENDECOMPRA)dgvSTOCK.CurrentRow.DataBoundItem;
            if (oORDENES.Estado=="ENTREGADO" )
            {
                MessageBox.Show("Esta orden fue recibida");
                return;
            }
            frmREMITO frm =  new frmREMITO(oORDENES);
            DialogResult dr =  frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                              
                ArmaGrilla();
            }
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
