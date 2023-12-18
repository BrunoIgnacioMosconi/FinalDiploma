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
    public partial class frmPAGO : Form

       
    {
        MODELO.VENTA oVENTA;
        MODELO.PAGO oPAGO;
        CONTROLADORA.VENTAS cVENTA;


        public frmPAGO(MODELO.VENTA MiVenta)
        {

            InitializeComponent();
            cVENTA = CONTROLADORA.VENTAS.ObtenerInstancia();
            oVENTA = MiVenta;           
            btnCONFIRMAR.Enabled = false;
            

            Formatdepago();
            btnCONFIRMAR.Enabled = false;
            lblCANTIDAD.Visible = false;
            lblPRECIO.Visible = false;           
            lblTOTAL.Visible = false;         
           
           
           

            
           
        }
        public void Formatdepago()
        {
            cmbCUOTA.Items.Add("Seleccionar");
            cmbCUOTA.SelectedItem = "Seleccionar";
            cmbCUOTA.Items.Add("Efectivo");
            cmbCUOTA.Items.Add("Debito");
            cmbCUOTA.Items.Add("Credito 1 cuota");
            cmbCUOTA.Items.Add("Credito 3 cuotas");
            cmbCUOTA.Items.Add("Credito 6 cuotas");
            cmbCUOTA.Items.Add("Credito 12 cuotas");
        }


        private void btnPagar_Click(object sender, EventArgs e)
        {
            decimal total = Convert.ToDecimal(txtFP1.Text);
            
          

            string forma=cmbCUOTA.SelectedItem.ToString();
            MODELO.FORMAS_DE_PAGO oFORMA;
            oPAGO = new MODELO.PAGO();
            switch (forma)
            {
                case "Efectivo":

                    oFORMA = new MODELO.EFECTIVO();
                    oPAGO.Formas_de_pago = oFORMA;

                    break;
                case "Debito":
                    oFORMA = new MODELO.DEBITO();
                    oPAGO.Formas_de_pago = oFORMA;

                    break;
                case "Credito 1 cuota":
                    oFORMA = new MODELO.CREDITO1();
                    oPAGO.Formas_de_pago = oFORMA;


                    break;
                case "Credito 3 cuotas":
                    oFORMA = new MODELO.CREDITO3();
                    oPAGO.Formas_de_pago = oFORMA;

                    break;
                case   "Credito 6 cuotas":
                    oFORMA = new MODELO.CREDITO6();
                    oPAGO.Formas_de_pago = oFORMA;

                    break;
                case  "Credito 12 cuotas":
                    oFORMA = new MODELO.CREDITO12();
                    oPAGO.Formas_de_pago = oFORMA;

                    break;

                default:
                    oFORMA = null;
                    MessageBox.Show("Debe seleccionar una forma de pago"); break;
            }
            oPAGO.Cantidad_De_cuotas = oPAGO.Formas_de_pago.Cantidad_cuotas();
            oPAGO.Total = oPAGO.Formas_de_pago.Calcular_total(Convert.ToDecimal(txtFP1.Text));
            oPAGO.Precio_de_cuota = oPAGO.Formas_de_pago.Calcular_precio_cuota(oPAGO.Total, oPAGO.Cantidad_De_cuotas);
           

            lblCANTIDAD.Text = oPAGO.Cantidad_De_cuotas.ToString();    
            lblPRECIO.Text = oPAGO.Precio_de_cuota.ToString();
            lblTOTAL.Text = oPAGO.Total.ToString();

           

            btnCONFIRMAR.Enabled = true;
            lblCANTIDAD.Visible = true;
            lblPRECIO.Visible = true;                      
            lblTOTAL.Visible = true;
           
          

        }

        private void btnCONFIRMAR_Click(object sender, EventArgs e)
        {
            oPAGO.Monto_seleccionado = Convert.ToDecimal(txtFP1.Text);
            cVENTA.AGREGAR_PAGOS(oPAGO);
            oVENTA.PAGOS.Add(oPAGO);
           
            this.DialogResult = DialogResult.OK;
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
           
    }
}
