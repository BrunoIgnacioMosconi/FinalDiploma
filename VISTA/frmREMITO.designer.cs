namespace VISTA
{
    partial class frmREMITO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmREMITO));
            this.button1 = new System.Windows.Forms.Button();
            this.btnGUARDAR = new System.Windows.Forms.Button();
            this.btnELIMINAR = new System.Windows.Forms.Button();
            this.dgvPRODUCTO_ORDEN = new System.Windows.Forms.DataGridView();
            this.dtpFECHA = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTOTAL = new System.Windows.Forms.TextBox();
            this.lblTOTAL = new System.Windows.Forms.Label();
            this.txtUNIDAD = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPRODUCTO_ORDEN)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(887, 440);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 62);
            this.button1.TabIndex = 121;
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
            this.btnGUARDAR.Location = new System.Drawing.Point(22, 440);
            this.btnGUARDAR.Name = "btnGUARDAR";
            this.btnGUARDAR.Size = new System.Drawing.Size(67, 62);
            this.btnGUARDAR.TabIndex = 120;
            this.btnGUARDAR.Text = "Guardar";
            this.btnGUARDAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGUARDAR.UseVisualStyleBackColor = true;
            this.btnGUARDAR.Click += new System.EventHandler(this.btnGUARDAR_Click);
            // 
            // btnELIMINAR
            // 
            this.btnELIMINAR.Location = new System.Drawing.Point(1017, 55);
            this.btnELIMINAR.Name = "btnELIMINAR";
            this.btnELIMINAR.Size = new System.Drawing.Size(32, 23);
            this.btnELIMINAR.TabIndex = 115;
            this.btnELIMINAR.Text = "-";
            this.btnELIMINAR.UseVisualStyleBackColor = true;
            this.btnELIMINAR.Click += new System.EventHandler(this.btnELIMINAR_Click);
            // 
            // dgvPRODUCTO_ORDEN
            // 
            this.dgvPRODUCTO_ORDEN.BackgroundColor = System.Drawing.Color.White;
            this.dgvPRODUCTO_ORDEN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPRODUCTO_ORDEN.Location = new System.Drawing.Point(19, 57);
            this.dgvPRODUCTO_ORDEN.Name = "dgvPRODUCTO_ORDEN";
            this.dgvPRODUCTO_ORDEN.Size = new System.Drawing.Size(934, 321);
            this.dgvPRODUCTO_ORDEN.TabIndex = 112;
            // 
            // dtpFECHA
            // 
            this.dtpFECHA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFECHA.Location = new System.Drawing.Point(62, 22);
            this.dtpFECHA.Name = "dtpFECHA";
            this.dtpFECHA.Size = new System.Drawing.Size(200, 20);
            this.dtpFECHA.TabIndex = 110;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 109;
            this.label6.Text = "Fecha";
            // 
            // txtTOTAL
            // 
            this.txtTOTAL.Enabled = false;
            this.txtTOTAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTOTAL.Location = new System.Drawing.Point(853, 384);
            this.txtTOTAL.Name = "txtTOTAL";
            this.txtTOTAL.Size = new System.Drawing.Size(100, 20);
            this.txtTOTAL.TabIndex = 123;
            // 
            // lblTOTAL
            // 
            this.lblTOTAL.AutoSize = true;
            this.lblTOTAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTOTAL.Location = new System.Drawing.Point(802, 387);
            this.lblTOTAL.Name = "lblTOTAL";
            this.lblTOTAL.Size = new System.Drawing.Size(51, 13);
            this.lblTOTAL.TabIndex = 122;
            this.lblTOTAL.Text = "TOTAL:";
            // 
            // txtUNIDAD
            // 
            this.txtUNIDAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUNIDAD.Location = new System.Drawing.Point(981, 57);
            this.txtUNIDAD.Name = "txtUNIDAD";
            this.txtUNIDAD.Size = new System.Drawing.Size(30, 20);
            this.txtUNIDAD.TabIndex = 124;
            this.txtUNIDAD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUNIDAD_KeyPress);
            // 
            // frmREMITO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1061, 537);
            this.Controls.Add(this.txtUNIDAD);
            this.Controls.Add(this.txtTOTAL);
            this.Controls.Add(this.lblTOTAL);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGUARDAR);
            this.Controls.Add(this.btnELIMINAR);
            this.Controls.Add(this.dgvPRODUCTO_ORDEN);
            this.Controls.Add(this.dtpFECHA);
            this.Controls.Add(this.label6);
            this.Name = "frmREMITO";
            this.Text = "Producto-Orden";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPRODUCTO_ORDEN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnGUARDAR;
        private System.Windows.Forms.Button btnELIMINAR;
        private System.Windows.Forms.DataGridView dgvPRODUCTO_ORDEN;
        private System.Windows.Forms.DateTimePicker dtpFECHA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTOTAL;
        private System.Windows.Forms.Label lblTOTAL;
        private System.Windows.Forms.TextBox txtUNIDAD;
    }
}