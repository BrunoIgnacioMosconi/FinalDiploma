using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Drawing;

namespace VISTA
{
    public partial class frmFACTURA : Form
    {
        Bitmap bmp;
        //MODELO.VENTA oVENTA;
        //MODELO.PRODUCTO oPRODUCTO;
        //MODELO.PAGO oPAGO;
        CONTROLADORA.VENTAS cVENTAS;
        public frmFACTURA(MODELO.VENTA oVENTA)
        {
            InitializeComponent();
            cVENTAS = CONTROLADORA.VENTAS.ObtenerInstancia();



            lblCLIENTE.Text += oVENTA.Cod_cliente.nombre + " " + oVENTA.Cod_cliente.apellido;
            lblEMPLEADO.Text += oVENTA.Cod_empleado.nombre;
            lblFECHA.Text = oVENTA.fecha_De_Venta.ToString();
            
            lblTIPO.Text = oVENTA.Tipo_factura;
            lblFACTURA.Text = oVENTA.Nro_Factura.ToString();

            lblPRODUCTOO.Text = "";
            foreach (MODELO.ITEM_VENTA oITEM in cVENTAS.LISTAR_PRODUCTO(oVENTA))
            {

                lblPRODUCTOO.Text +="Descripcion: " +oITEM.Producto.descripcion +"           Cantidad: "+ oITEM.cantidad.ToString() +"            Subtotal: "+ oITEM.subtotal_venta.ToString()+"\n";
            }
            lblPAGO.Text = "";
            foreach (MODELO.PAGO oPAGO in cVENTAS.LISTAR_PAGO_FACTURA(oVENTA))
            {
                lblPAGO.Text += "Metodo de pago: " + oPAGO +"\n";    
            }
            lblTOTAL.Text = oVENTA.TotalConDescuento.ToString();
            
            
        }

      

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void btnIMPRIMIR_Click(object sender, EventArgs e)
        {
            btnIMPRIMIR.Visible = false;
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 25, 50, this.Size);
            

            printPreviewDialog1.ShowDialog();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
