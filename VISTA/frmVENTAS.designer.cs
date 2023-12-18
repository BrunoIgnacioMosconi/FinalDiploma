namespace VISTA
{
    partial class frmVENTAS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVENTAS));
            this.dgvVENTAS = new System.Windows.Forms.DataGridView();
            this.btnCANCELAR = new System.Windows.Forms.Button();
            this.btnAGREGAR = new System.Windows.Forms.Button();
            this.btnCONSULTAR = new System.Windows.Forms.Button();
            this.btnBUSCAR = new System.Windows.Forms.Button();
            this.dtpFECHA = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVENTAS)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVENTAS
            // 
            this.dgvVENTAS.BackgroundColor = System.Drawing.Color.Linen;
            this.dgvVENTAS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVENTAS.Location = new System.Drawing.Point(154, 73);
            this.dgvVENTAS.Name = "dgvVENTAS";
            this.dgvVENTAS.Size = new System.Drawing.Size(1140, 402);
            this.dgvVENTAS.TabIndex = 12;
            // 
            // btnCANCELAR
            // 
            this.btnCANCELAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCANCELAR.Image = ((System.Drawing.Image)(resources.GetObject("btnCANCELAR.Image")));
            this.btnCANCELAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCANCELAR.Location = new System.Drawing.Point(1200, 504);
            this.btnCANCELAR.Name = "btnCANCELAR";
            this.btnCANCELAR.Size = new System.Drawing.Size(94, 60);
            this.btnCANCELAR.TabIndex = 101;
            this.btnCANCELAR.Text = "&Cerrar";
            this.btnCANCELAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCANCELAR.UseVisualStyleBackColor = true;
            this.btnCANCELAR.Click += new System.EventHandler(this.btnCANCELAR_Click);
            // 
            // btnAGREGAR
            // 
            this.btnAGREGAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAGREGAR.Image = ((System.Drawing.Image)(resources.GetObject("btnAGREGAR.Image")));
            this.btnAGREGAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAGREGAR.Location = new System.Drawing.Point(55, 73);
            this.btnAGREGAR.Name = "btnAGREGAR";
            this.btnAGREGAR.Size = new System.Drawing.Size(93, 60);
            this.btnAGREGAR.TabIndex = 98;
            this.btnAGREGAR.Text = "&Agregar";
            this.btnAGREGAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAGREGAR.UseVisualStyleBackColor = true;
            this.btnAGREGAR.Click += new System.EventHandler(this.btnAGREGAR_Click);
            // 
            // btnCONSULTAR
            // 
            this.btnCONSULTAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCONSULTAR.Image = ((System.Drawing.Image)(resources.GetObject("btnCONSULTAR.Image")));
            this.btnCONSULTAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCONSULTAR.Location = new System.Drawing.Point(55, 405);
            this.btnCONSULTAR.Name = "btnCONSULTAR";
            this.btnCONSULTAR.Size = new System.Drawing.Size(91, 60);
            this.btnCONSULTAR.TabIndex = 102;
            this.btnCONSULTAR.Text = "&Consultar";
            this.btnCONSULTAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCONSULTAR.UseVisualStyleBackColor = true;
            this.btnCONSULTAR.Click += new System.EventHandler(this.btn_CONSULTAR_Click);
            // 
            // btnBUSCAR
            // 
            this.btnBUSCAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBUSCAR.Image = ((System.Drawing.Image)(resources.GetObject("btnBUSCAR.Image")));
            this.btnBUSCAR.Location = new System.Drawing.Point(1230, 29);
            this.btnBUSCAR.Name = "btnBUSCAR";
            this.btnBUSCAR.Size = new System.Drawing.Size(64, 38);
            this.btnBUSCAR.TabIndex = 104;
            this.btnBUSCAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBUSCAR.UseVisualStyleBackColor = true;
            this.btnBUSCAR.Click += new System.EventHandler(this.btnBUSCAR_Click);
            // 
            // dtpFECHA
            // 
            this.dtpFECHA.Location = new System.Drawing.Point(1024, 44);
            this.dtpFECHA.Name = "dtpFECHA";
            this.dtpFECHA.Size = new System.Drawing.Size(200, 20);
            this.dtpFECHA.TabIndex = 103;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(981, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 105;
            this.label1.Text = "Fecha";
            // 
            // frmVENTAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1382, 564);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBUSCAR);
            this.Controls.Add(this.dtpFECHA);
            this.Controls.Add(this.btnCONSULTAR);
            this.Controls.Add(this.btnCANCELAR);
            this.Controls.Add(this.btnAGREGAR);
            this.Controls.Add(this.dgvVENTAS);
            this.Name = "frmVENTAS";
            this.Text = "Gestionar ventas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVENTAS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvVENTAS;
        private System.Windows.Forms.Button btnCANCELAR;
        private System.Windows.Forms.Button btnAGREGAR;
        private System.Windows.Forms.Button btnCONSULTAR;
        private System.Windows.Forms.Button btnBUSCAR;
        private System.Windows.Forms.DateTimePicker dtpFECHA;
        private System.Windows.Forms.Label label1;
    }
}