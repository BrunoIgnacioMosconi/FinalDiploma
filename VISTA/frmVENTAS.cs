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
    [MODELO.MODELO_DE_SEGURIDAD.ESTRUCTURA.formulario(CLASE = "frmVENTAS", DESCRIPCION = "Venta del sistema", MENU = true, MODULO = "Sistema", SEGURIDAD = true)]
   
    [MODELO.MODELO_DE_SEGURIDAD.ESTRUCTURA.accion(CONTROL = "btnCONSULTAR", DESCRIPCION = "Consultar datos de la venta", FORMULARIO = "frmVENTAS", FORMULARIO_DESCRIPCION = "Venta del sistema", MODULO = "Sistema")]
    [MODELO.MODELO_DE_SEGURIDAD.ESTRUCTURA.accion(CONTROL = "btnAGREGAR", DESCRIPCION = "Agregar venta del sistema", FORMULARIO = "frmVENTAS", FORMULARIO_DESCRIPCION = "Venta del sistema", MODULO = "Sistema")]
    public partial class frmVENTAS : Form
    {
        public static frmVENTAS instancia;
        public static frmVENTAS obtener_instancia(MODELO.USUARIO oUSUARIO)
        {
            if (instancia == null)
            {
                instancia = new frmVENTAS(oUSUARIO);
            }
            if (instancia.IsDisposed)
            {
                instancia = new frmVENTAS(oUSUARIO);
            }
            return instancia;
        }
        CONTROLADORA.VENTAS C_VENTAS;
       
        public frmVENTAS(MODELO.USUARIO oUSUARIO)
        {

            InitializeComponent();
            
            btnAGREGAR.Enabled = false;
            btnAGREGAR.Enabled = oUSUARIO.VALIDAR_ACCION("frmVENTAS", "btnAGREGAR");           
            btnCONSULTAR.Enabled = oUSUARIO.VALIDAR_ACCION("frmVENTAS", "btnCONSULTAR");


            C_VENTAS = CONTROLADORA.VENTAS.ObtenerInstancia();
            ArmaGrilla(Convert.ToDateTime("10/10/2050"));

        }

        private void ArmaGrilla(DateTime Fecha)
        {
            dgvVENTAS.DataSource = null;
            dgvVENTAS.DataSource = C_VENTAS.LISTAR_VENTAS(Fecha);
            dgvVENTAS.Columns[1].HeaderText = "Numero de factura";
            dgvVENTAS.Columns[0].HeaderText = "ID Venta";

          
        }

        private void btnAGREGAR_Click(object sender, EventArgs e)
        {
            frmVENTA frm = new frmVENTA(new MODELO.VENTA(), "A");
            DialogResult respuesta = frm.ShowDialog();
            if (respuesta == DialogResult.OK)
            {
                ArmaGrilla(dtpFECHA.Value);
            }
        }

      

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_CONSULTAR_Click(object sender, EventArgs e)
        {
            if (dgvVENTAS.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una venta");
                return;
            }
            MODELO.VENTA oVENTA = C_VENTAS.ObtenerVenta(Convert.ToInt32(dgvVENTAS.CurrentRow.Cells[0].Value));
            frmVENTA frm = new frmVENTA(oVENTA,"C");
            DialogResult respuesta = frm.ShowDialog();
            if (respuesta == DialogResult.OK)
            {
                ArmaGrilla(dtpFECHA.Value);
            }
        }

        private void btnBUSCAR_Click(object sender, EventArgs e)
        {
            ArmaGrilla(dtpFECHA.Value);
        }

        
    }
}
