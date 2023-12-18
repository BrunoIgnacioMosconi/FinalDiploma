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
    [MODELO.MODELO_DE_SEGURIDAD.ESTRUCTURA.formulario(CLASE = "frmPLANILLA", DESCRIPCION = "Planillas del sistema", MENU = true, MODULO = "Sistema", SEGURIDAD = true)]
    [MODELO.MODELO_DE_SEGURIDAD.ESTRUCTURA.accion(CONTROL = "btnGENERAR", DESCRIPCION = "Generar planillas", FORMULARIO = "frmPLANILLA", FORMULARIO_DESCRIPCION = "Planillas del sistema", MODULO = "Sistema")]
    public partial class frmPLANILLA : Form
    {
        public static frmPLANILLA instancia;
        public static frmPLANILLA obtener_instancia(MODELO.USUARIO oUSUARIO)
        {
            if (instancia == null)
            {
                instancia = new frmPLANILLA(oUSUARIO);
            }
            if (instancia.IsDisposed)
            {
                instancia = new frmPLANILLA(oUSUARIO);
            }
            return instancia;
        }
        //MODELO.ORDENDECOMPRA oORDEN;
        CONTROLADORA.CLIENTES cCLIENTES;
        CONTROLADORA.VENTAS cVENTAS;
        CONTROLADORA.PROVEEDORES cPROVEEDORES;
        CONTROLADORA.ORDENESDECOMPRA cORDENESDECOMPRA;
        CONTROLADORA.EMPLEADOS cEMPLEADOS;
        CONTROLADORA.PRODUCTOS cPRODUCTOS;
        public frmPLANILLA(MODELO.USUARIO oUSUARIO)
        {
            InitializeComponent();
            cCLIENTES = CONTROLADORA.CLIENTES.ObtenerInstancia();
            cVENTAS = CONTROLADORA.VENTAS.ObtenerInstancia();
            cPROVEEDORES = CONTROLADORA.PROVEEDORES.ObtenerInstancia();
            cEMPLEADOS = CONTROLADORA.EMPLEADOS.ObtenerInstancia();
            cORDENESDECOMPRA = CONTROLADORA.ORDENESDECOMPRA.ObtenerInstancia();
            cPRODUCTOS = CONTROLADORA.PRODUCTOS.ObtenerInstancia();
            cmbORDEN.Items.Add("Todos");
            cmbORDEN.SelectedItem = "Todos";
            cmbORDEN.Items.Add("Pendiente");
            cmbORDEN.Items.Add("Entregado");
            
            ArmaGrillaVentas();
            ArmaGrillaClientes();
            ArmaGrillaProveedores("");
            ArmaGrillaOrdenesDeCompra(cmbORDEN.SelectedItem.ToString());
            ArmaGrillaEmpleados("");
            ArmaGrillaProductos("");
        }
        private void ArmaGrillaClientes()
        {
            dgvCLIENTES.DataSource = null;
            dgvCLIENTES.DataSource = cCLIENTES.LISTAR_CLIENTES();
        }
        private void ArmaGrillaVentas()
        {

            dgvVENTAS.DataSource = null;
            dgvVENTAS.DataSource = cVENTAS.LISTAR_VENTAS(Convert.ToDateTime("10/10/2050"));
        }
        private void ArmaGrillaProveedores(string nombre)
        {
            dgvPROVEEDORES.DataSource = null;
            dgvPROVEEDORES.DataSource = cPROVEEDORES.LISTAR_PROVEEDORES(nombre);

        }
        private void ArmaGrillaProductos(string codigo)
        {
            dgvPRODUCTOS.DataSource = null;
            dgvPRODUCTOS.DataSource = cPRODUCTOS.LISTAR_PRODUCTOS(codigo);

        }
        private void ArmaGrillaEmpleados(string nombre)
        {
            dgvEMPLEADOS.DataSource = null;
            dgvEMPLEADOS.DataSource = cEMPLEADOS.LISTAR_EMPLEADOS(nombre);

        }
        private void ArmaGrillaOrdenesDeCompra(string estado)
        {
            dgvORDENESDECOMPRA.DataSource = null;
            dgvORDENESDECOMPRA.DataSource = cORDENESDECOMPRA.LISTAR_ORDENDECOMPRA_ESTADO(estado);
           

        }

        public void GenerarPlanillaExcelCliente()
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Hoja1"];
            workbook.Sheets["Hoja1"].Range["A1:O1"].Font.Bold = true;
            


            worksheet = workbook.ActiveSheet;
            worksheet.Name = "CustomerDetail";

            for (int i = 1; i <dgvCLIENTES.Columns.Count + 1; i++)
            {
                worksheet.Cells[1,i] = dgvCLIENTES.Columns[i - 1].HeaderText;
                

            }
            for (int i = 0; i < dgvCLIENTES.Rows.Count; i++)
            {
                for (int j = 0; j < dgvCLIENTES.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dgvCLIENTES.Rows[i].Cells[j].Value.ToString();
                }
            }
            var saveFileDialoge = new SaveFileDialog();
            saveFileDialoge.FileName = "Output";
            saveFileDialoge.DefaultExt = ".xlsx";
            if (saveFileDialoge.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialoge.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }
            app.Quit();


        }
        public void GenerarPlanillaExcelVenta()
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Hoja1"];
            workbook.Sheets["Hoja1"].Range["A1:O1"].Font.Bold = true;
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "CustomerDetail";

            for (int i = 1; i < dgvVENTAS.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dgvVENTAS.Columns[i - 1].HeaderText;

            }
            for (int i = 0; i < dgvVENTAS.Rows.Count; i++)
            {
                for (int j = 0; j < dgvVENTAS.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dgvVENTAS.Rows[i].Cells[j].Value.ToString();
                }
            }
            var saveFileDialoge = new SaveFileDialog();
            saveFileDialoge.FileName = "Output";
            saveFileDialoge.DefaultExt = ".xlsx";
            if (saveFileDialoge.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialoge.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }
            app.Quit();
        }
        public void GenerarPlanillaExcelProveedor()
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Hoja1"];
            workbook.Sheets["Hoja1"].Range["A1:O1"].Font.Bold = true;
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "CustomerDetail";

            for (int i = 1; i < dgvPROVEEDORES.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dgvPROVEEDORES.Columns[i - 1].HeaderText;

            }
            for (int i = 0; i < dgvPROVEEDORES.Rows.Count; i++)
            {
                for (int j = 0; j < dgvPROVEEDORES.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dgvPROVEEDORES.Rows[i].Cells[j].Value.ToString();
                }
            }
            var saveFileDialoge = new SaveFileDialog();
            saveFileDialoge.FileName = "Output";
            saveFileDialoge.DefaultExt = ".xlsx";
            if (saveFileDialoge.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialoge.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }
            app.Quit();

        }
        public void GenerarPlanillaExcelOrdenDeCompra()
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Hoja1"];
            workbook.Sheets["Hoja1"].Range["A1:O1"].Font.Bold = true;
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "CustomerDetail";

           
            
                for (int i = 1; i < dgvORDENESDECOMPRA.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = dgvORDENESDECOMPRA.Columns[i - 1].HeaderText;

                }
                for (int i = 0; i < dgvORDENESDECOMPRA.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvORDENESDECOMPRA.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dgvORDENESDECOMPRA.Rows[i].Cells[j].Value.ToString();
                    }
                }

                var saveFileDialoge = new SaveFileDialog();
                saveFileDialoge.FileName = "Output";
                saveFileDialoge.DefaultExt = ".xlsx";
                if (saveFileDialoge.ShowDialog() == DialogResult.OK)
                {

                    workbook.SaveAs(saveFileDialoge.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

                }
            
            
            
            app.Quit();
        }
        public void GenerarPlanillaExcelProducto()
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Hoja1"];
            workbook.Sheets["Hoja1"].Range["A1:O1"].Font.Bold = true;
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "CustomerDetail";

            for (int i = 1; i < dgvPRODUCTOS.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dgvPRODUCTOS.Columns[i - 1].HeaderText;

            }
            for (int i = 0; i < dgvPRODUCTOS.Rows.Count; i++)
            {
                for (int j = 0; j < dgvPRODUCTOS.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dgvPRODUCTOS.Rows[i].Cells[j].Value.ToString();
                }
            }

            var saveFileDialoge = new SaveFileDialog();
            saveFileDialoge.FileName = "Output";
            saveFileDialoge.DefaultExt = ".xlsx";
            if (saveFileDialoge.ShowDialog() == DialogResult.OK)
            {

                workbook.SaveAs(saveFileDialoge.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

            }
            app.Quit();

        }
        public void GenerarPlanillaExcelEmpleado()
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Hoja1"];
            workbook.Sheets["Hoja1"].Range["A1:O1"].Font.Bold = true;
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "CustomerDetail";

            for (int i = 1; i < dgvEMPLEADOS.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dgvEMPLEADOS.Columns[i - 1].HeaderText;

            }
            for (int i = 0; i < dgvEMPLEADOS.Rows.Count; i++)
            {
                for (int j = 0; j < dgvEMPLEADOS.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dgvEMPLEADOS.Rows[i].Cells[j].Value.ToString();
                }
            }

            var saveFileDialoge = new SaveFileDialog();
            saveFileDialoge.FileName = "Output";
            saveFileDialoge.DefaultExt = ".xlsx";
            if (saveFileDialoge.ShowDialog() == DialogResult.OK)
            {

                workbook.SaveAs(saveFileDialoge.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

            }
            app.Quit();

        }
        private void BtnPLANILLA_Click(object sender, EventArgs e)
        {
            GenerarPlanillaExcelCliente();
        }

        private void BtnPLANILLAVENTA_Click(object sender, EventArgs e)
        {
            GenerarPlanillaExcelVenta();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            GenerarPlanillaExcelProveedor();
        }
        private void Button5_Click(object sender, EventArgs e)
        {
            GenerarPlanillaExcelOrdenDeCompra();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            GenerarPlanillaExcelEmpleado();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            GenerarPlanillaExcelProducto();
        }
        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CmbORDEN_SelectedValueChanged(object sender, EventArgs e)
        {
            ArmaGrillaOrdenesDeCompra(cmbORDEN.SelectedItem.ToString());
        }
    }
}
