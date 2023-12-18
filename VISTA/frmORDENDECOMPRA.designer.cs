namespace VISTA
{
    partial class frmORDENDECOMPRA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmORDENDECOMPRA));
            this.txt_CANTIDAD = new System.Windows.Forms.TextBox();
            this.dtpFECHA = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvORDENESDECOMPRAS = new System.Windows.Forms.DataGridView();
            this.txtPRODUCTO = new System.Windows.Forms.TextBox();
            this.btnAGREGAR = new System.Windows.Forms.Button();
            this.btnELIMINAR = new System.Windows.Forms.Button();
            this.lblTOTAL = new System.Windows.Forms.Label();
            this.txtTOTAL = new System.Windows.Forms.TextBox();
            this.cmbPROVEEDOR = new System.Windows.Forms.ComboBox();
            this.btnBUSCARPRODUCTO = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnGUARDAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvORDENESDECOMPRAS)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_CANTIDAD
            // 
            this.txt_CANTIDAD.Location = new System.Drawing.Point(972, 68);
            this.txt_CANTIDAD.Name = "txt_CANTIDAD";
            this.txt_CANTIDAD.Size = new System.Drawing.Size(127, 20);
            this.txt_CANTIDAD.TabIndex = 37;
            this.txt_CANTIDAD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CANTIDAD_KeyPress);
            // 
            // dtpFECHA
            // 
            this.dtpFECHA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFECHA.Location = new System.Drawing.Point(945, 11);
            this.dtpFECHA.Name = "dtpFECHA";
            this.dtpFECHA.Size = new System.Drawing.Size(200, 20);
            this.dtpFECHA.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(902, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(914, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Cantidad ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Proveedor";
            // 
            // dgvORDENESDECOMPRAS
            // 
            this.dgvORDENESDECOMPRAS.BackgroundColor = System.Drawing.Color.White;
            this.dgvORDENESDECOMPRAS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvORDENESDECOMPRAS.Location = new System.Drawing.Point(23, 103);
            this.dgvORDENESDECOMPRAS.Name = "dgvORDENESDECOMPRAS";
            this.dgvORDENESDECOMPRAS.Size = new System.Drawing.Size(1122, 353);
            this.dgvORDENESDECOMPRAS.TabIndex = 49;
            // 
            // txtPRODUCTO
            // 
            this.txtPRODUCTO.Enabled = false;
            this.txtPRODUCTO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPRODUCTO.Location = new System.Drawing.Point(76, 61);
            this.txtPRODUCTO.Name = "txtPRODUCTO";
            this.txtPRODUCTO.Size = new System.Drawing.Size(207, 20);
            this.txtPRODUCTO.TabIndex = 50;
            // 
            // btnAGREGAR
            // 
            this.btnAGREGAR.Location = new System.Drawing.Point(1105, 68);
            this.btnAGREGAR.Name = "btnAGREGAR";
            this.btnAGREGAR.Size = new System.Drawing.Size(32, 23);
            this.btnAGREGAR.TabIndex = 53;
            this.btnAGREGAR.Text = "+";
            this.btnAGREGAR.UseVisualStyleBackColor = true;
            this.btnAGREGAR.Click += new System.EventHandler(this.btnAGREGAR_Click_1);
            // 
            // btnELIMINAR
            // 
            this.btnELIMINAR.Location = new System.Drawing.Point(1151, 103);
            this.btnELIMINAR.Name = "btnELIMINAR";
            this.btnELIMINAR.Size = new System.Drawing.Size(32, 23);
            this.btnELIMINAR.TabIndex = 54;
            this.btnELIMINAR.Text = "-";
            this.btnELIMINAR.UseVisualStyleBackColor = true;
            this.btnELIMINAR.Click += new System.EventHandler(this.btnELIMINAR_Click_1);
            // 
            // lblTOTAL
            // 
            this.lblTOTAL.AutoSize = true;
            this.lblTOTAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTOTAL.Location = new System.Drawing.Point(994, 465);
            this.lblTOTAL.Name = "lblTOTAL";
            this.lblTOTAL.Size = new System.Drawing.Size(51, 13);
            this.lblTOTAL.TabIndex = 55;
            this.lblTOTAL.Text = "TOTAL:";
            // 
            // txtTOTAL
            // 
            this.txtTOTAL.Enabled = false;
            this.txtTOTAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTOTAL.Location = new System.Drawing.Point(1045, 462);
            this.txtTOTAL.Name = "txtTOTAL";
            this.txtTOTAL.Size = new System.Drawing.Size(100, 20);
            this.txtTOTAL.TabIndex = 56;
            // 
            // cmbPROVEEDOR
            // 
            this.cmbPROVEEDOR.FormattingEnabled = true;
            this.cmbPROVEEDOR.Location = new System.Drawing.Point(76, 15);
            this.cmbPROVEEDOR.Name = "cmbPROVEEDOR";
            this.cmbPROVEEDOR.Size = new System.Drawing.Size(121, 21);
            this.cmbPROVEEDOR.TabIndex = 57;
            // 
            // btnBUSCARPRODUCTO
            // 
            this.btnBUSCARPRODUCTO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBUSCARPRODUCTO.Image = ((System.Drawing.Image)(resources.GetObject("btnBUSCARPRODUCTO.Image")));
            this.btnBUSCARPRODUCTO.Location = new System.Drawing.Point(316, 52);
            this.btnBUSCARPRODUCTO.Name = "btnBUSCARPRODUCTO";
            this.btnBUSCARPRODUCTO.Size = new System.Drawing.Size(37, 33);
            this.btnBUSCARPRODUCTO.TabIndex = 103;
            this.btnBUSCARPRODUCTO.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBUSCARPRODUCTO.UseVisualStyleBackColor = true;
            this.btnBUSCARPRODUCTO.Click += new System.EventHandler(this.btnBUSCARPRODUCTO_Click_1);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(1079, 511);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 62);
            this.button1.TabIndex = 105;
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
            this.btnGUARDAR.Location = new System.Drawing.Point(23, 511);
            this.btnGUARDAR.Name = "btnGUARDAR";
            this.btnGUARDAR.Size = new System.Drawing.Size(67, 62);
            this.btnGUARDAR.TabIndex = 104;
            this.btnGUARDAR.Text = "Guardar";
            this.btnGUARDAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGUARDAR.UseVisualStyleBackColor = true;
            this.btnGUARDAR.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmORDENDECOMPRA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1269, 585);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGUARDAR);
            this.Controls.Add(this.btnBUSCARPRODUCTO);
            this.Controls.Add(this.cmbPROVEEDOR);
            this.Controls.Add(this.txtTOTAL);
            this.Controls.Add(this.lblTOTAL);
            this.Controls.Add(this.btnELIMINAR);
            this.Controls.Add(this.btnAGREGAR);
            this.Controls.Add(this.txtPRODUCTO);
            this.Controls.Add(this.dgvORDENESDECOMPRAS);
            this.Controls.Add(this.txt_CANTIDAD);
            this.Controls.Add(this.dtpFECHA);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "frmORDENDECOMPRA";
            this.Text = "Orden de compra";
            ((System.ComponentModel.ISupportInitialize)(this.dgvORDENESDECOMPRAS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_CANTIDAD;
        private System.Windows.Forms.DateTimePicker dtpFECHA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvORDENESDECOMPRAS;
        private System.Windows.Forms.TextBox txtPRODUCTO;
        private System.Windows.Forms.Button btnAGREGAR;
        private System.Windows.Forms.Button btnELIMINAR;
        private System.Windows.Forms.Label lblTOTAL;
        private System.Windows.Forms.TextBox txtTOTAL;
        private System.Windows.Forms.ComboBox cmbPROVEEDOR;
        private System.Windows.Forms.Button btnBUSCARPRODUCTO;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnGUARDAR;
    }
}