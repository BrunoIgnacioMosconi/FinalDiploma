namespace VISTA
{
    partial class frmGRAFICO
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.rdEmpleado = new System.Windows.Forms.RadioButton();
            this.rdProveedor = new System.Windows.Forms.RadioButton();
            this.rdCliente = new System.Windows.Forms.RadioButton();
            this.rdProducto = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDESDE = new System.Windows.Forms.DateTimePicker();
            this.dtpHASTA = new System.Windows.Forms.DateTimePicker();
            this.btnGENERAR = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelXXX = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // rdEmpleado
            // 
            this.rdEmpleado.AutoSize = true;
            this.rdEmpleado.Location = new System.Drawing.Point(26, 25);
            this.rdEmpleado.Name = "rdEmpleado";
            this.rdEmpleado.Size = new System.Drawing.Size(72, 17);
            this.rdEmpleado.TabIndex = 0;
            this.rdEmpleado.TabStop = true;
            this.rdEmpleado.Text = "Empleado";
            this.rdEmpleado.UseVisualStyleBackColor = true;
            this.rdEmpleado.CheckedChanged += new System.EventHandler(this.rdEmpleado_CheckedChanged);
            // 
            // rdProveedor
            // 
            this.rdProveedor.AutoSize = true;
            this.rdProveedor.Location = new System.Drawing.Point(26, 48);
            this.rdProveedor.Name = "rdProveedor";
            this.rdProveedor.Size = new System.Drawing.Size(74, 17);
            this.rdProveedor.TabIndex = 1;
            this.rdProveedor.TabStop = true;
            this.rdProveedor.Text = "Proveedor";
            this.rdProveedor.UseVisualStyleBackColor = true;
            this.rdProveedor.CheckedChanged += new System.EventHandler(this.rdProveedor_CheckedChanged);
            // 
            // rdCliente
            // 
            this.rdCliente.AutoSize = true;
            this.rdCliente.Location = new System.Drawing.Point(26, 71);
            this.rdCliente.Name = "rdCliente";
            this.rdCliente.Size = new System.Drawing.Size(57, 17);
            this.rdCliente.TabIndex = 2;
            this.rdCliente.TabStop = true;
            this.rdCliente.Text = "Cliente";
            this.rdCliente.UseVisualStyleBackColor = true;
            this.rdCliente.CheckedChanged += new System.EventHandler(this.rdCliente_CheckedChanged);
            // 
            // rdProducto
            // 
            this.rdProducto.AutoSize = true;
            this.rdProducto.Location = new System.Drawing.Point(26, 94);
            this.rdProducto.Name = "rdProducto";
            this.rdProducto.Size = new System.Drawing.Size(68, 17);
            this.rdProducto.TabIndex = 3;
            this.rdProducto.TabStop = true;
            this.rdProducto.Text = "Producto";
            this.rdProducto.UseVisualStyleBackColor = true;
            this.rdProducto.CheckedChanged += new System.EventHandler(this.rdProducto_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 448);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Fecha desde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 486);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fecha hasta";
            // 
            // dtpDESDE
            // 
            this.dtpDESDE.Location = new System.Drawing.Point(90, 448);
            this.dtpDESDE.Name = "dtpDESDE";
            this.dtpDESDE.Size = new System.Drawing.Size(200, 20);
            this.dtpDESDE.TabIndex = 6;
            // 
            // dtpHASTA
            // 
            this.dtpHASTA.Location = new System.Drawing.Point(90, 486);
            this.dtpHASTA.Name = "dtpHASTA";
            this.dtpHASTA.Size = new System.Drawing.Size(200, 20);
            this.dtpHASTA.TabIndex = 7;
            // 
            // btnGENERAR
            // 
            this.btnGENERAR.Location = new System.Drawing.Point(26, 512);
            this.btnGENERAR.Name = "btnGENERAR";
            this.btnGENERAR.Size = new System.Drawing.Size(263, 44);
            this.btnGENERAR.TabIndex = 8;
            this.btnGENERAR.Text = "Generar";
            this.btnGENERAR.UseVisualStyleBackColor = true;
            this.btnGENERAR.Click += new System.EventHandler(this.btnGENERAR_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(320, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "PROVEEDORES A LOS QUE MAS LES COMPRE ";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "CLIENTES QUE MAS COMPRARON";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "PRODUCTOS QUE MAS SE VENDIERON";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "EMPLEADOS QUE MAS VENDIERON";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(1010, 255);
            this.chart1.TabIndex = 11;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(320, 273);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series5.Legend = "Legend1";
            series5.Name = "PROVEEDORES A LOS QUE MAS LES COMPRE";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series6.Legend = "Legend1";
            series6.Name = "CLIENTES QUE MAS COMPRARON";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series7.Legend = "Legend1";
            series7.Name = "PRODUCTOS QUE MAS SE VENDIERON";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series8.Legend = "Legend1";
            series8.Name = "EMPLEADOS QUE MAS VENDIERON";
            series8.YValuesPerPoint = 2;
            this.chart2.Series.Add(series5);
            this.chart2.Series.Add(series6);
            this.chart2.Series.Add(series7);
            this.chart2.Series.Add(series8);
            this.chart2.Size = new System.Drawing.Size(1010, 283);
            this.chart2.TabIndex = 12;
            this.chart2.Text = "chart2";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 161);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(278, 268);
            this.dataGridView1.TabIndex = 13;
            // 
            // labelXXX
            // 
            this.labelXXX.AutoSize = true;
            this.labelXXX.Location = new System.Drawing.Point(15, 136);
            this.labelXXX.Name = "labelXXX";
            this.labelXXX.Size = new System.Drawing.Size(28, 13);
            this.labelXXX.TabIndex = 14;
            this.labelXXX.Text = "XXX";
            // 
            // frmGRAFICO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1349, 606);
            this.Controls.Add(this.labelXXX);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btnGENERAR);
            this.Controls.Add(this.dtpHASTA);
            this.Controls.Add(this.dtpDESDE);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdProducto);
            this.Controls.Add(this.rdCliente);
            this.Controls.Add(this.rdProveedor);
            this.Controls.Add(this.rdEmpleado);
            this.Name = "frmGRAFICO";
            this.Text = "Grafico";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdEmpleado;
        private System.Windows.Forms.RadioButton rdProveedor;
        private System.Windows.Forms.RadioButton rdCliente;
        private System.Windows.Forms.RadioButton rdProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDESDE;
        private System.Windows.Forms.DateTimePicker dtpHASTA;
        private System.Windows.Forms.Button btnGENERAR;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelXXX;
    }
}