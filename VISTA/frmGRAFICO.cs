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
    [MODELO.MODELO_DE_SEGURIDAD.ESTRUCTURA.formulario(CLASE = "frmGRAFICO", DESCRIPCION = "Reportes del sistema", MENU = true, MODULO = "Sistema", SEGURIDAD = true)]
    [MODELO.MODELO_DE_SEGURIDAD.ESTRUCTURA.accion(CONTROL = "btnGENERAR", DESCRIPCION = "Generar reporte", FORMULARIO = "frmGRAFICO", FORMULARIO_DESCRIPCION = "Reportes del sistema", MODULO = "Sistema")]
    public partial class frmGRAFICO : Form
    {
        private static frmGRAFICO instancia;
        public static frmGRAFICO obtener_instancia(MODELO.USUARIO oUSUARIO)

        {
            if (instancia == null)
            {
                instancia = new frmGRAFICO(oUSUARIO);
            }
            if (instancia.IsDisposed)
            {
                instancia = new frmGRAFICO(oUSUARIO);
            }
            return instancia;
        }
        CONTROLADORA.REPORTES CREPORTES;
        public frmGRAFICO(MODELO.USUARIO oUSUARIO)
        {
            InitializeComponent();
            CREPORTES = CONTROLADORA.REPORTES.ObtenerInstancia();
            rdEmpleado.Checked = true;

           
            btnGENERAR.Enabled = oUSUARIO.VALIDAR_ACCION("frmGRAFICO", "btnGENERAR");
        }
        public void CargarGrilla()
        {
            dataGridView1.DataSource = null;


            if (rdCliente.Checked)
            {
                this.dataGridView1.DataSource = null;
                this.dataGridView1.DataSource = CREPORTES.LISTAR_CLIENTES(Convert.ToDateTime(dtpDESDE.Value), Convert.ToDateTime(dtpHASTA.Value));
                var monto = from row in this.dataGridView1.Rows.Cast<DataGridViewRow>()
                            group row by row.Cells["Cod_cliente"].Value into v
                            select new { Cliente = v.Key, Monto = v.Sum(m => Convert.ToDecimal(m.Cells["Total"].Value)) };


                dataGridView1.DataSource = monto.ToList();
            }

            else if (rdEmpleado.Checked )
            {
                this.dataGridView1.DataSource = null;
                this.dataGridView1.DataSource = CREPORTES.LISTAR_EMPLEADOS(Convert.ToDateTime(dtpDESDE.Value), Convert.ToDateTime(dtpHASTA.Value));
                var monto = from row in this.dataGridView1.Rows.Cast<DataGridViewRow>()
                            group row by row.Cells["Cod_empleado"].Value into v
                            select new { Empleado = v.Key, Monto = v.Sum(m => Convert.ToDecimal(m.Cells["total"].Value)) };


                dataGridView1.DataSource = monto.ToList();
            }

            else if (rdProducto.Checked)
            {
                this.dataGridView1.DataSource = null;
                this.dataGridView1.DataSource = CREPORTES.LISTAR_PRODUCTOS(Convert.ToDateTime(dtpDESDE.Value), Convert.ToDateTime(dtpHASTA.Value));
                var cantidad = from row in this.dataGridView1.Rows.Cast<DataGridViewRow>()
                            group row by row.Cells["Producto"].Value into v
                            select new { Producto = v.Key, Cantidad_total = v.Sum(m => Convert.ToDecimal(m.Cells["cantidad"].Value)) };


                dataGridView1.DataSource = cantidad.ToList();
            }
            else if (rdProveedor.Checked)
            {
                this.dataGridView1.DataSource = null;
                this.dataGridView1.DataSource = CREPORTES.LISTAR_PROVEEDORES(Convert.ToDateTime(dtpDESDE.Value), Convert.ToDateTime(dtpHASTA.Value));
                var monto = from row in this.dataGridView1.Rows.Cast<DataGridViewRow>()
                            group row by row.Cells["cod_proveedor"].Value into v
                            select new { Proveedor = v.Key, Monto = v.Sum(m => Convert.ToDecimal(m.Cells["Total"].Value)) };


                dataGridView1.DataSource = monto.ToList();
            }

        }

        

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void rdEmpleado_CheckedChanged(object sender, EventArgs e)
        {
            if (rdEmpleado.Checked)
            {
                CargarGrilla();
            }

        }   

        private void rdProveedor_CheckedChanged(object sender, EventArgs e)
        {
            if (rdProveedor.Checked)
            {
                CargarGrilla();
            }
           
        }

        private void rdCliente_CheckedChanged(object sender, EventArgs e)
        {
            if (rdCliente.Checked)
            {
                CargarGrilla();
            }
            
        }

        private void rdProducto_CheckedChanged(object sender, EventArgs e)
        {
            if (rdProducto.Checked)
            {
                CargarGrilla();
            }
            
        }

        private void btnGENERAR_Click(object sender, EventArgs e)
        {
            foreach (var series  in this.chart1.Series)
            {
                series.Points.Clear();
            }
            foreach (var series in this.chart2.Series)
            {
                series.Points.Clear();
            }
          
            if (rdEmpleado.Checked)
              {
                   
                 

                    labelXXX.Text = "Empleados";
                    btnGENERAR.Enabled = true;
                    dtpDESDE.Enabled = true;
                    dtpHASTA.Enabled = true;

                  
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        this.chart1.Series["EMPLEADOS QUE MAS VENDIERON"].Points.AddXY(dataGridView1.Rows[i].Cells[0].Value.ToString(), Convert.ToDecimal(dataGridView1.Rows[i].Cells[1].Value.ToString()));//VER

                    }

                    
                    this.chart1.Series["EMPLEADOS QUE MAS VENDIERON"].XValueMember = "Empleados";
                    this.chart1.Series["EMPLEADOS QUE MAS VENDIERON"].YValueMembers = "Monto";

                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        this.chart2.Series["EMPLEADOS QUE MAS VENDIERON"].Points.AddXY(dataGridView1.Rows[i].Cells[0].Value.ToString(), Convert.ToDecimal(dataGridView1.Rows[i].Cells[1].Value.ToString()));

                    }
                this.chart1.Series["EMPLEADOS QUE MAS VENDIERON"].XValueMember = "Empleados";
                this.chart1.Series["EMPLEADOS QUE MAS VENDIERON"].YValueMembers = "Monto";
              

                chart1.Series[0]["PieLabelStyle"] = "Outside";
                    chart1.ChartAreas[0].Area3DStyle.Enable3D = true;
                    chart1.ChartAreas[0].Area3DStyle.Inclination = 0;
                    chart1.ChartAreas[0].Area3DStyle.Rotation = 0;
                    
              }

            else if (rdProveedor.Checked)
            {
                


                labelXXX.Text = "Proveedores";
                btnGENERAR.Enabled = true;
                dtpDESDE.Enabled = true;
                dtpHASTA.Enabled = true;

            
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    this.chart1.Series["PROVEEDORES A LOS QUE MAS LES COMPRE "].Points.AddXY(dataGridView1.Rows[i].Cells[0].Value.ToString(), Convert.ToDecimal(dataGridView1.Rows[i].Cells[1].Value.ToString()));//VER

                }

                
                this.chart1.Series["PROVEEDORES A LOS QUE MAS LES COMPRE "].XValueMember = "Proveedores";
                this.chart1.Series["PROVEEDORES A LOS QUE MAS LES COMPRE "].YValueMembers = "Monto";

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    this.chart2.Series["PROVEEDORES A LOS QUE MAS LES COMPRE"].Points.AddXY(dataGridView1.Rows[i].Cells[0].Value.ToString(), Convert.ToDecimal(dataGridView1.Rows[i].Cells[1].Value.ToString()));

                }
                
            

                chart1.Series[0]["PieLabelStyle"] = "Outside";
                chart1.ChartAreas[0].Area3DStyle.Enable3D = true;
                chart1.ChartAreas[0].Area3DStyle.Inclination = 0;
                chart1.ChartAreas[0].Area3DStyle.Rotation = 0;
            }
            else if (rdProducto.Checked)
            {
                labelXXX.Text = "Productos";
                btnGENERAR.Enabled = true;
                dtpDESDE.Enabled = true;
                dtpHASTA.Enabled = true;


                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    this.chart1.Series["PRODUCTOS QUE MAS SE VENDIERON"].Points.AddXY(dataGridView1.Rows[i].Cells[0].Value.ToString(), Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value.ToString()));//VER

                }


                this.chart1.Series["PRODUCTOS QUE MAS SE VENDIERON"].XValueMember = "Productos";
                this.chart1.Series["PRODUCTOS QUE MAS SE VENDIERON"].YValueMembers = "Cantidad";

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    this.chart2.Series["PRODUCTOS QUE MAS SE VENDIERON"].Points.AddXY(dataGridView1.Rows[i].Cells[0].Value.ToString(), Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value.ToString()));

                }
               
             

                chart1.Series[0]["PieLabelStyle"] = "Outside";
                chart1.ChartAreas[0].Area3DStyle.Enable3D = true;
                chart1.ChartAreas[0].Area3DStyle.Inclination = 0;
                chart1.ChartAreas[0].Area3DStyle.Rotation = 0;
            }
            else if (rdCliente.Checked)
            {
                labelXXX.Text = "Clientes";
                btnGENERAR.Enabled = true;
                dtpDESDE.Enabled = true;
                dtpHASTA.Enabled = true;


                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    this.chart1.Series["CLIENTES QUE MAS COMPRARON"].Points.AddXY(dataGridView1.Rows[i].Cells[0].Value.ToString(), Convert.ToDecimal(dataGridView1.Rows[i].Cells[1].Value.ToString()));//VER

                }


                this.chart1.Series["CLIENTES QUE MAS COMPRARON"].XValueMember = "Clientes";
                this.chart1.Series["CLIENTES QUE MAS COMPRARON"].YValueMembers = "Monto";

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    this.chart2.Series["CLIENTES QUE MAS COMPRARON"].Points.AddXY(dataGridView1.Rows[i].Cells[0].Value.ToString(), Convert.ToDecimal(dataGridView1.Rows[i].Cells[1].Value.ToString()));

                }
              
              
                chart1.Series[0]["PieLabelStyle"] = "Outside";
                chart1.ChartAreas[0].Area3DStyle.Enable3D = true;
                chart1.ChartAreas[0].Area3DStyle.Inclination = 0;
                chart1.ChartAreas[0].Area3DStyle.Rotation = 0;
            }
        }
    }
}

