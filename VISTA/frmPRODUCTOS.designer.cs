namespace VISTA
{
    partial class frmPRODUCTOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPRODUCTOS));
            this.dgvPRODUCTOS = new System.Windows.Forms.DataGridView();
            this.btnCANCELAR = new System.Windows.Forms.Button();
            this.btnAGREGAR = new System.Windows.Forms.Button();
            this.btnCONSULTAR = new System.Windows.Forms.Button();
            this.txtBUSCAR = new System.Windows.Forms.TextBox();
            this.btnBUSCAR = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMODIFICACIONES = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPRODUCTOS)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPRODUCTOS
            // 
            this.dgvPRODUCTOS.BackgroundColor = System.Drawing.Color.White;
            this.dgvPRODUCTOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPRODUCTOS.Location = new System.Drawing.Point(161, 93);
            this.dgvPRODUCTOS.Name = "dgvPRODUCTOS";
            this.dgvPRODUCTOS.Size = new System.Drawing.Size(1011, 395);
            this.dgvPRODUCTOS.TabIndex = 0;
            this.dgvPRODUCTOS.DoubleClick += new System.EventHandler(this.dgvPRODUCTOS_DoubleClick);
            // 
            // btnCANCELAR
            // 
            this.btnCANCELAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCANCELAR.Image = ((System.Drawing.Image)(resources.GetObject("btnCANCELAR.Image")));
            this.btnCANCELAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCANCELAR.Location = new System.Drawing.Point(1088, 511);
            this.btnCANCELAR.Name = "btnCANCELAR";
            this.btnCANCELAR.Size = new System.Drawing.Size(94, 60);
            this.btnCANCELAR.TabIndex = 104;
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
            this.btnAGREGAR.Location = new System.Drawing.Point(41, 95);
            this.btnAGREGAR.Name = "btnAGREGAR";
            this.btnAGREGAR.Size = new System.Drawing.Size(93, 60);
            this.btnAGREGAR.TabIndex = 102;
            this.btnAGREGAR.Text = "&Agregar";
            this.btnAGREGAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAGREGAR.UseVisualStyleBackColor = true;
            this.btnAGREGAR.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCONSULTAR
            // 
            this.btnCONSULTAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCONSULTAR.Image = ((System.Drawing.Image)(resources.GetObject("btnCONSULTAR.Image")));
            this.btnCONSULTAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCONSULTAR.Location = new System.Drawing.Point(43, 428);
            this.btnCONSULTAR.Name = "btnCONSULTAR";
            this.btnCONSULTAR.Size = new System.Drawing.Size(91, 60);
            this.btnCONSULTAR.TabIndex = 105;
            this.btnCONSULTAR.Text = "&Consultar";
            this.btnCONSULTAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCONSULTAR.UseVisualStyleBackColor = true;
            this.btnCONSULTAR.Click += new System.EventHandler(this.btnCONSULTAR_Click_1);
            // 
            // txtBUSCAR
            // 
            this.txtBUSCAR.Location = new System.Drawing.Point(974, 56);
            this.txtBUSCAR.Name = "txtBUSCAR";
            this.txtBUSCAR.Size = new System.Drawing.Size(100, 20);
            this.txtBUSCAR.TabIndex = 108;
            this.txtBUSCAR.TextChanged += new System.EventHandler(this.txtBUSCAR_TextChanged);
            // 
            // btnBUSCAR
            // 
            this.btnBUSCAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBUSCAR.Image = ((System.Drawing.Image)(resources.GetObject("btnBUSCAR.Image")));
            this.btnBUSCAR.Location = new System.Drawing.Point(1112, 49);
            this.btnBUSCAR.Name = "btnBUSCAR";
            this.btnBUSCAR.Size = new System.Drawing.Size(64, 38);
            this.btnBUSCAR.TabIndex = 107;
            this.btnBUSCAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBUSCAR.UseVisualStyleBackColor = true;
            this.btnBUSCAR.Click += new System.EventHandler(this.btnBUSCAR_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(928, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 106;
            this.label3.Text = "Codigo";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnMODIFICACIONES
            // 
            this.btnMODIFICACIONES.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMODIFICACIONES.Image = ((System.Drawing.Image)(resources.GetObject("btnMODIFICACIONES.Image")));
            this.btnMODIFICACIONES.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMODIFICACIONES.Location = new System.Drawing.Point(43, 259);
            this.btnMODIFICACIONES.Name = "btnMODIFICACIONES";
            this.btnMODIFICACIONES.Size = new System.Drawing.Size(91, 60);
            this.btnMODIFICACIONES.TabIndex = 109;
            this.btnMODIFICACIONES.Text = "&Modificar";
            this.btnMODIFICACIONES.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMODIFICACIONES.UseVisualStyleBackColor = true;
            this.btnMODIFICACIONES.Click += new System.EventHandler(this.BtnMODIFICACIONES_Click);
            // 
            // frmPRODUCTOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1196, 591);
            this.Controls.Add(this.btnMODIFICACIONES);
            this.Controls.Add(this.txtBUSCAR);
            this.Controls.Add(this.btnBUSCAR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCONSULTAR);
            this.Controls.Add(this.btnCANCELAR);
            this.Controls.Add(this.btnAGREGAR);
            this.Controls.Add(this.dgvPRODUCTOS);
            this.Name = "frmPRODUCTOS";
            this.Text = "Gestionar productos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPRODUCTOS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPRODUCTOS;
        private System.Windows.Forms.Button btnCANCELAR;
        private System.Windows.Forms.Button btnAGREGAR;
        private System.Windows.Forms.Button btnCONSULTAR;
        private System.Windows.Forms.TextBox txtBUSCAR;
        private System.Windows.Forms.Button btnBUSCAR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMODIFICACIONES;
    }
}