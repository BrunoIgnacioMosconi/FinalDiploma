namespace VISTA
{
    partial class frmVENTA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVENTA));
            this.dtpFECHA = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblVENDEDOR = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvPRODUCTO = new System.Windows.Forms.DataGridView();
            this.txtPRECIOTOTAL = new System.Windows.Forms.TextBox();
            this.rdA = new System.Windows.Forms.RadioButton();
            this.rdB = new System.Windows.Forms.RadioButton();
            this.btnAGREGAR = new System.Windows.Forms.Button();
            this.btnBUSCARPRODUCTO = new System.Windows.Forms.Button();
            this.txtPRODUCTO = new System.Windows.Forms.TextBox();
            this.txt_CANTIDAD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnELIMINARITEM = new System.Windows.Forms.Button();
            this.cmbEMPLEADO = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnGUARDAR = new System.Windows.Forms.Button();
            this.txtUNIDADES = new System.Windows.Forms.TextBox();
            this.Datos = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cmbCLIENTE = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Pagos = new System.Windows.Forms.TabPage();
            this.btnE = new System.Windows.Forms.Button();
            this.btnA = new System.Windows.Forms.Button();
            this.dgvPAGO = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPRODUCTO)).BeginInit();
            this.Datos.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.Pagos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPAGO)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFECHA
            // 
            this.dtpFECHA.Location = new System.Drawing.Point(88, 167);
            this.dtpFECHA.Name = "dtpFECHA";
            this.dtpFECHA.Size = new System.Drawing.Size(200, 20);
            this.dtpFECHA.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(80, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Producto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Fecha de venta";
            // 
            // lblVENDEDOR
            // 
            this.lblVENDEDOR.AutoSize = true;
            this.lblVENDEDOR.Location = new System.Drawing.Point(6, 67);
            this.lblVENDEDOR.Name = "lblVENDEDOR";
            this.lblVENDEDOR.Size = new System.Drawing.Size(53, 13);
            this.lblVENDEDOR.TabIndex = 22;
            this.lblVENDEDOR.Text = "Vendedor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Tipo de factura";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(95, 359);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 44;
            this.label9.Text = "Precio total";
            // 
            // dgvPRODUCTO
            // 
            this.dgvPRODUCTO.BackgroundColor = System.Drawing.Color.Linen;
            this.dgvPRODUCTO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPRODUCTO.Location = new System.Drawing.Point(83, 39);
            this.dgvPRODUCTO.Name = "dgvPRODUCTO";
            this.dgvPRODUCTO.Size = new System.Drawing.Size(1158, 296);
            this.dgvPRODUCTO.TabIndex = 46;
            // 
            // txtPRECIOTOTAL
            // 
            this.txtPRECIOTOTAL.Enabled = false;
            this.txtPRECIOTOTAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPRECIOTOTAL.Location = new System.Drawing.Point(206, 356);
            this.txtPRECIOTOTAL.Name = "txtPRECIOTOTAL";
            this.txtPRECIOTOTAL.Size = new System.Drawing.Size(114, 20);
            this.txtPRECIOTOTAL.TabIndex = 48;
            // 
            // rdA
            // 
            this.rdA.AutoSize = true;
            this.rdA.Checked = true;
            this.rdA.Location = new System.Drawing.Point(102, 116);
            this.rdA.Name = "rdA";
            this.rdA.Size = new System.Drawing.Size(32, 17);
            this.rdA.TabIndex = 51;
            this.rdA.TabStop = true;
            this.rdA.Text = "A";
            this.rdA.UseVisualStyleBackColor = true;
            // 
            // rdB
            // 
            this.rdB.AutoSize = true;
            this.rdB.Location = new System.Drawing.Point(140, 116);
            this.rdB.Name = "rdB";
            this.rdB.Size = new System.Drawing.Size(32, 17);
            this.rdB.TabIndex = 52;
            this.rdB.Text = "B";
            this.rdB.UseVisualStyleBackColor = true;
            // 
            // btnAGREGAR
            // 
            this.btnAGREGAR.Location = new System.Drawing.Point(1209, 11);
            this.btnAGREGAR.Name = "btnAGREGAR";
            this.btnAGREGAR.Size = new System.Drawing.Size(32, 23);
            this.btnAGREGAR.TabIndex = 60;
            this.btnAGREGAR.Text = "+";
            this.btnAGREGAR.UseVisualStyleBackColor = true;
            this.btnAGREGAR.Click += new System.EventHandler(this.btnAGREGAR_Click_1);
            // 
            // btnBUSCARPRODUCTO
            // 
            this.btnBUSCARPRODUCTO.Location = new System.Drawing.Point(326, 12);
            this.btnBUSCARPRODUCTO.Name = "btnBUSCARPRODUCTO";
            this.btnBUSCARPRODUCTO.Size = new System.Drawing.Size(52, 23);
            this.btnBUSCARPRODUCTO.TabIndex = 59;
            this.btnBUSCARPRODUCTO.Text = "+";
            this.btnBUSCARPRODUCTO.UseVisualStyleBackColor = true;
            this.btnBUSCARPRODUCTO.Click += new System.EventHandler(this.btnBUSCARPRODUCTO_Click_1);
            // 
            // txtPRODUCTO
            // 
            this.txtPRODUCTO.Enabled = false;
            this.txtPRODUCTO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPRODUCTO.Location = new System.Drawing.Point(136, 13);
            this.txtPRODUCTO.Name = "txtPRODUCTO";
            this.txtPRODUCTO.Size = new System.Drawing.Size(184, 20);
            this.txtPRODUCTO.TabIndex = 58;
            this.txtPRODUCTO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPRODUCTO_KeyPress);
            // 
            // txt_CANTIDAD
            // 
            this.txt_CANTIDAD.Location = new System.Drawing.Point(1076, 11);
            this.txt_CANTIDAD.Name = "txt_CANTIDAD";
            this.txt_CANTIDAD.Size = new System.Drawing.Size(127, 20);
            this.txt_CANTIDAD.TabIndex = 57;
            this.txt_CANTIDAD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CANTIDAD_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1018, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 56;
            this.label6.Text = "Cantidad ";
            // 
            // btnELIMINARITEM
            // 
            this.btnELIMINARITEM.Location = new System.Drawing.Point(10, 48);
            this.btnELIMINARITEM.Name = "btnELIMINARITEM";
            this.btnELIMINARITEM.Size = new System.Drawing.Size(32, 20);
            this.btnELIMINARITEM.TabIndex = 61;
            this.btnELIMINARITEM.Text = "-";
            this.btnELIMINARITEM.UseVisualStyleBackColor = true;
            this.btnELIMINARITEM.Click += new System.EventHandler(this.btnELIMINARITEM_Click);
            // 
            // cmbEMPLEADO
            // 
            this.cmbEMPLEADO.FormattingEnabled = true;
            this.cmbEMPLEADO.Location = new System.Drawing.Point(102, 64);
            this.cmbEMPLEADO.Name = "cmbEMPLEADO";
            this.cmbEMPLEADO.Size = new System.Drawing.Size(114, 21);
            this.cmbEMPLEADO.TabIndex = 63;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(1236, 488);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 62);
            this.button1.TabIndex = 107;
            this.button1.Text = "Cancelar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGUARDAR
            // 
            this.btnGUARDAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGUARDAR.Image = ((System.Drawing.Image)(resources.GetObject("btnGUARDAR.Image")));
            this.btnGUARDAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGUARDAR.Location = new System.Drawing.Point(16, 498);
            this.btnGUARDAR.Name = "btnGUARDAR";
            this.btnGUARDAR.Size = new System.Drawing.Size(67, 62);
            this.btnGUARDAR.TabIndex = 106;
            this.btnGUARDAR.Text = "Guardar";
            this.btnGUARDAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGUARDAR.UseVisualStyleBackColor = true;
            this.btnGUARDAR.Click += new System.EventHandler(this.btGUARDAR_Click);
            // 
            // txtUNIDADES
            // 
            this.txtUNIDADES.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUNIDADES.Location = new System.Drawing.Point(48, 48);
            this.txtUNIDADES.Name = "txtUNIDADES";
            this.txtUNIDADES.Size = new System.Drawing.Size(29, 20);
            this.txtUNIDADES.TabIndex = 108;
            // 
            // Datos
            // 
            this.Datos.Controls.Add(this.tabPage1);
            this.Datos.Controls.Add(this.tabPage2);
            this.Datos.Controls.Add(this.Pagos);
            this.Datos.Location = new System.Drawing.Point(12, 12);
            this.Datos.Name = "Datos";
            this.Datos.SelectedIndex = 0;
            this.Datos.Size = new System.Drawing.Size(1290, 456);
            this.Datos.TabIndex = 109;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cmbCLIENTE);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dtpFECHA);
            this.tabPage1.Controls.Add(this.lblVENDEDOR);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.cmbEMPLEADO);
            this.tabPage1.Controls.Add(this.rdA);
            this.tabPage1.Controls.Add(this.rdB);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1282, 430);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Datos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cmbCLIENTE
            // 
            this.cmbCLIENTE.FormattingEnabled = true;
            this.cmbCLIENTE.Location = new System.Drawing.Point(102, 9);
            this.cmbCLIENTE.Name = "cmbCLIENTE";
            this.cmbCLIENTE.Size = new System.Drawing.Size(114, 21);
            this.cmbCLIENTE.TabIndex = 65;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 64;
            this.label1.Text = "Cliente";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvPRODUCTO);
            this.tabPage2.Controls.Add(this.txtUNIDADES);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.txtPRECIOTOTAL);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txt_CANTIDAD);
            this.tabPage2.Controls.Add(this.btnELIMINARITEM);
            this.tabPage2.Controls.Add(this.txtPRODUCTO);
            this.tabPage2.Controls.Add(this.btnAGREGAR);
            this.tabPage2.Controls.Add(this.btnBUSCARPRODUCTO);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1282, 430);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Venta";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Pagos
            // 
            this.Pagos.Controls.Add(this.btnE);
            this.Pagos.Controls.Add(this.btnA);
            this.Pagos.Controls.Add(this.dgvPAGO);
            this.Pagos.Location = new System.Drawing.Point(4, 22);
            this.Pagos.Name = "Pagos";
            this.Pagos.Padding = new System.Windows.Forms.Padding(3);
            this.Pagos.Size = new System.Drawing.Size(1282, 430);
            this.Pagos.TabIndex = 2;
            this.Pagos.Text = "Pagos";
            this.Pagos.UseVisualStyleBackColor = true;
            // 
            // btnE
            // 
            this.btnE.Location = new System.Drawing.Point(21, 84);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(75, 42);
            this.btnE.TabIndex = 2;
            this.btnE.Text = "Eliminar";
            this.btnE.UseVisualStyleBackColor = true;
            this.btnE.Click += new System.EventHandler(this.btnE_Click);
            // 
            // btnA
            // 
            this.btnA.Location = new System.Drawing.Point(21, 20);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(75, 42);
            this.btnA.TabIndex = 1;
            this.btnA.Text = "Agregar";
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // dgvPAGO
            // 
            this.dgvPAGO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPAGO.Location = new System.Drawing.Point(113, 6);
            this.dgvPAGO.Name = "dgvPAGO";
            this.dgvPAGO.Size = new System.Drawing.Size(1163, 357);
            this.dgvPAGO.TabIndex = 0;
            // 
            // frmVENTA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1421, 572);
            this.Controls.Add(this.Datos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGUARDAR);
            this.Name = "frmVENTA";
            this.Text = "Venta";
            this.Load += new System.EventHandler(this.frmVENTA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPRODUCTO)).EndInit();
            this.Datos.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.Pagos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPAGO)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpFECHA;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblVENDEDOR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvPRODUCTO;
        private System.Windows.Forms.TextBox txtPRECIOTOTAL;
        private System.Windows.Forms.RadioButton rdA;
        private System.Windows.Forms.RadioButton rdB;
        private System.Windows.Forms.Button btnAGREGAR;
        private System.Windows.Forms.Button btnBUSCARPRODUCTO;
        private System.Windows.Forms.TextBox txtPRODUCTO;
        private System.Windows.Forms.TextBox txt_CANTIDAD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnELIMINARITEM;
        private System.Windows.Forms.ComboBox cmbEMPLEADO;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnGUARDAR;
        private System.Windows.Forms.TextBox txtUNIDADES;
        private System.Windows.Forms.TabControl Datos;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cmbCLIENTE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage Pagos;
        private System.Windows.Forms.Button btnE;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.DataGridView dgvPAGO;
    }
}