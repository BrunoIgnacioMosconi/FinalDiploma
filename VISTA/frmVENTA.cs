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
    public partial class frmVENTA : Form
    {
        MODELO.ITEM_VENTA oITEM;
        MODELO.PRODUCTO oPRODUCTO { get; set; }
        MODELO.VENTA oVENTA;
        CONTROLADORA.VENTAS cVENTAS;
       
        //CONTROLADORA.PRODUCTOS cPRODUCTOS;
        MODELO.EMPLEADO BEMPLEADO { get; set; }
        string accion;
        
        public frmVENTA(string MiAccion)
        {

            InitializeComponent();
            accion = MiAccion;
            cVENTAS = CONTROLADORA.VENTAS.ObtenerInstancia();
            
            //txtNROFACTURA.Text = factura.ToString();
            

        }
        public frmVENTA(MODELO.VENTA MiVenta, string MiAccion)
        {
            
            InitializeComponent();
            
            oVENTA = MiVenta;
            accion = MiAccion;
            cVENTAS = CONTROLADORA.VENTAS.ObtenerInstancia();
            txtPRECIOTOTAL.Text = 0.ToString();
            cmbEMPLEADO.DataSource = cVENTAS.ObtenerEmpleado();
            cmbCLIENTE.DataSource = cVENTAS.ObtenerCliente();
           
            dgvPAGO.Columns.Add("Forma de pago", "Forma de pago");
            this.dgvPAGO.Columns["Forma de pago"].Visible = false;



            if (accion != "A")
            {
                ARMA_GRILLA_PAGOS();
                ARMA_GRILLA(oVENTA);
                
                if (accion == "C")
                {
                    
                    cmbEMPLEADO.SelectedItem = oVENTA.Cod_empleado;
                    cmbCLIENTE.SelectedItem = oVENTA.Cod_cliente;
                    btnGUARDAR.Enabled = false;

                    txtPRECIOTOTAL.Text = oVENTA.total.ToString();
                    dtpFECHA.Value = oVENTA.fecha_De_Venta;
                    if (oVENTA.Tipo_factura.ToString()=="Factura A")
                    {
                        rdA.Checked = true;
                        rdB.Checked = false;
                    }
                    else
                    {
                        rdA.Checked = false;
                        rdB.Checked = true;
                    }
                    cmbEMPLEADO.SelectedItem = oVENTA.Cod_empleado;
                    btnA.Enabled = false;
                    btnE.Enabled = false;
                    txtPRECIOTOTAL.Enabled = false;
                    txt_CANTIDAD.Enabled = false;
                    txtPRODUCTO.Enabled = false;
                    btnBUSCARPRODUCTO.Enabled = false;
                    btnELIMINARITEM.Enabled = false;
                    txtUNIDADES.Enabled = false;
                    
                    
                    rdA.Enabled = false;
                    rdB.Enabled = false;
                    dtpFECHA.Enabled = false;
                    cmbCLIENTE.Enabled = false;
                    cmbEMPLEADO.Enabled = false;

                   

                    
                }
            }
            
            
        }
        public void ARMA_GRILLA(MODELO.VENTA oVENTA)
        {
            dgvPRODUCTO.DataSource = null;
            dgvPRODUCTO.DataSource = cVENTAS.LISTAR_PRODUCTO(oVENTA);
            dgvPRODUCTO.Columns[0].HeaderText = "ID Item";
            dgvPRODUCTO.Columns[1].HeaderText = "Venta";
            dgvPRODUCTO.Columns[5].HeaderText = "Precio unitario";
           


        }

        public decimal calcularTotal()
        {
            decimal total = 0;
            foreach (var item in oVENTA.ITEMS)
            {
                total += item.subtotal_venta;
            }
            return total;
        }
        public void ARMA_GRILLA()
        {
            dgvPRODUCTO.DataSource = null;
            dgvPRODUCTO.DataSource = oVENTA.ITEMS.ToList();
            txtPRECIOTOTAL.Text = calcularTotal().ToString();
          
            this.dgvPRODUCTO.Columns["oVenta"].Visible = false;



        }
        public void ARMA_GRILLA_PAGOS()
        {
            
            
            if (accion == "A")
            {
               
                dgvPAGO.DataSource = null;
                dgvPAGO.DataSource = oVENTA.PAGOS.ToList();
                
                for (int i = 0; i < dgvPAGO.Rows.Count; i++)
                {
                    #region formas de pago
                    switch (dgvPAGO.Rows[i].Cells["Formas_de_pago"].Value.ToString())
                    {
                        case "MODELO.EFECTIVO":

                            dgvPAGO.Rows[i].Cells["Forma de pago"].Value = "Efectivo";

                            break;
                        case "MODELO.DEBITO":
                            dgvPAGO.Rows[i].Cells["Forma de pago"].Value = "Debito";

                            break;
                        case "MODELO.CREDITO1":

                            dgvPAGO.Rows[i].Cells["Forma de pago"].Value = "Credito";

                            break;
                        case "MODELO.CREDITO3":

                            dgvPAGO.Rows[i].Cells["Forma de pago"].Value = "Credito";
                            break;
                        case "MODELO.CREDITO6":

                            dgvPAGO.Rows[i].Cells["Forma de pago"].Value = "Credito";
                            break;
                        case "MODELO.CREDITO12":
                            dgvPAGO.Rows[i].Cells["Forma de pago"].Value = "Credito";

                            break;

                        default:
                            dgvPAGO.Rows[i].Cells["Forma de pago"].Value = "";break;
                    }
                    #endregion

                }
              
                this.dgvPAGO.Columns["oVenta"].Visible = false;
                this.dgvPAGO.Columns["Formas_de_pago"].Visible = false;
                this.dgvPAGO.Columns["Forma de pago"].Visible = true;
            }

            else
            {
                this.dgvPAGO.Columns["Forma de pago"].Visible = false;
                dgvPAGO.DataSource = null;
                dgvPAGO.DataSource = cVENTAS.LISTAR_PAGOS(oVENTA);
            }

        }
       

        private void txtPRODUCTO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                btnBUSCARPRODUCTO_Click(sender, e);
            }
        }

        private void btnELIMINARITEM_Click(object sender, EventArgs e)
        {
            MODELO.ITEM_VENTA oITEM = (MODELO.ITEM_VENTA)dgvPRODUCTO.CurrentRow.DataBoundItem;
            if (oITEM.cantidad < Convert.ToInt32(txtUNIDADES.Text))
            {
                MessageBox.Show("No se puede disminuir esa cantidad");
                return;
            }
            else if (oITEM.cantidad == Convert.ToInt32(txtUNIDADES.Text))
            {
                oVENTA.ITEMS.Remove(oITEM);
            }
            else
            {

                oITEM.cantidad -= Convert.ToInt32(txtUNIDADES.Text);


            }

            ARMA_GRILLA();

                       
        }

        

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnAGREGARCLIENTE_Click(object sender, EventArgs e)
        {
            frmEMPLEADOS frm = new frmEMPLEADOS("Buscar"); //DARLE DOBLE CLICK PARA QUE APAREZCA EN UN TEXTBOX DESDE UNA GRILLA
            DialogResult DR = frm.ShowDialog();
            if (DR == DialogResult.OK)
            {
                BEMPLEADO = frm.ObtenerEmpleado;
                cmbEMPLEADO.SelectedItem = BEMPLEADO.nombre;
                cmbEMPLEADO.Enabled = false;
            }
        }

      

        private void btnBUSCARPRODUCTO_Click(object sender, EventArgs e)
        {
          
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btGUARDAR_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbEMPLEADO.Text))
            {
                MessageBox.Show("Debe seleccionar un vendedor", "Seleccionar vendedor", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrWhiteSpace(cmbCLIENTE.Text))
            {
                MessageBox.Show("Debe seleccionar un cliente", "Seleccionar cliente", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }

            if (dgvPRODUCTO == null)
            {
                MessageBox.Show("Debe seleccionar un producto", "Seleccionar producto", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }
           
          
            if (rdA.Checked == false && rdB.Checked == false)
            {
                MessageBox.Show("Debe seleccionar un tipo de factura", "Seleccionar tipo de factura", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }
            
            decimal total = 0;
            
            foreach (var PAGO in oVENTA.PAGOS)
            {
                total += PAGO.Monto_seleccionado;
                

            }
           
            oVENTA.total = Convert.ToDecimal(txtPRECIOTOTAL.Text);
            if (oVENTA.total == 0)
            {
                MessageBox.Show("Debe ingresar al menos 1 producto");
                return;
            }
            if (total != oVENTA.total)
            {
               // MessageBox.Show(oVENTA.total + " " + total);
                MessageBox.Show("El total del pago debe ser igual que el total de la factura", "Error pago", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }
            decimal totalcondescuento = 0;

            foreach (var PAGO in oVENTA.PAGOS)
            {
                totalcondescuento += PAGO.Total;


            }
            oVENTA.TotalConDescuento = totalcondescuento;




            oVENTA.fecha_De_Venta = dtpFECHA.Value;
            oVENTA.Cod_empleado = (MODELO.EMPLEADO)cmbEMPLEADO.SelectedItem;
            oVENTA.Cod_cliente = (MODELO.CLIENTE)cmbCLIENTE.SelectedItem;

            if (rdA.Checked == true)
            {
                oVENTA.Tipo_factura = "Factura A";
            }
            else
            {
                oVENTA.Tipo_factura = "Factura B";
            }
            
                     
            

            if (accion == "A")
            {
                oVENTA.Nro_Factura = cVENTAS.ObtenerFactura();
                cVENTAS.AGREGAR_VENTAS(oVENTA);
                cVENTAS.DescontarUnidadesStock(oVENTA);

                frmFACTURA frm = new frmFACTURA(oVENTA);
                frm.ShowDialog();

            }
            
            this.DialogResult = DialogResult.OK;
        }

        private void btnBUSCARPRODUCTO_Click_1(object sender, EventArgs e)
        {
           
                frmPRODUCTOS frm = new frmPRODUCTOS("Buscar"); //DARLE DOBLE CLICK PARA QUE APAREZCA EN UN TEXTBOX DESDE UNA GRILLA
                DialogResult DR = frm.ShowDialog();
                if (DR == DialogResult.OK)
                {
                    oPRODUCTO = frm.ObteneroProducto;
                    txtPRODUCTO.Text = oPRODUCTO.descripcion + " " + oPRODUCTO.Marca;
                }
            
           
                           
        }

        private void btnAGREGAR_Click_1(object sender, EventArgs e)
        {
            int CANTIDAD;
            if (!int.TryParse(txt_CANTIDAD.Text, out CANTIDAD))
            {
                MessageBox.Show("Debe ingresar una cantidad");
                return;
            }
            if (oPRODUCTO == null)
            {

                MessageBox.Show("Debe ingresar un producto");
                return;
            }
            if (CANTIDAD > oPRODUCTO.cantidad_Actual)
            {
                MessageBox.Show("No hay suficientes unidades");
                return;
            }
            if (CANTIDAD <= 0)
            {
                MessageBox.Show("Ingrese una cantidad mayor a 0");
                return;
            }
            oITEM = new MODELO.ITEM_VENTA();
            oITEM.Producto = oPRODUCTO;
            oITEM.Observador = oPRODUCTO.Estado;
            oITEM.cantidad = CANTIDAD;
            oITEM.precio_unitario_venta = oPRODUCTO.precio_unitario;
            cVENTAS.AGREGAR_ITEMS(oITEM);
            
            oVENTA.ITEMS.Add(oITEM);
            ARMA_GRILLA();
            txtPRODUCTO.Clear();
            
        }

       
      

        private void txt_CANTIDAD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtDESCUENTO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            frmPAGO frm = new frmPAGO(oVENTA);
            DialogResult respuesta = frm.ShowDialog();
            if (respuesta == DialogResult.OK)
            {
                ARMA_GRILLA_PAGOS();
            }
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            if (dgvPAGO.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un pago");
                return;
            }
            MODELO.PAGO oPAGO =(MODELO.PAGO)dgvPAGO.CurrentRow.DataBoundItem;
            
            oVENTA.PAGOS.Remove(oPAGO);
            cVENTAS.ELIMINAR_PAGOS(oPAGO);
            ARMA_GRILLA_PAGOS();
        }

        private void frmVENTA_Load(object sender, EventArgs e)
        {

        }
    }
}
