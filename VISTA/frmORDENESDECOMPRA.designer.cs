namespace VISTA
{
    partial class frmORDENESDECOMPRA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmORDENESDECOMPRA));
            this.dgvORDENES = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAGREGAR = new System.Windows.Forms.Button();
            this.btnELIMINAR = new System.Windows.Forms.Button();
            this.btnCONSULTAR = new System.Windows.Forms.Button();
            this.btnCANCELAR = new System.Windows.Forms.Button();
            this.btnBUSCAR = new System.Windows.Forms.Button();
            this.txtBUSCAR = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvORDENES)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvORDENES
            // 
            this.dgvORDENES.AllowUserToAddRows = false;
            this.dgvORDENES.AllowUserToDeleteRows = false;
            this.dgvORDENES.AllowUserToOrderColumns = true;
            this.dgvORDENES.BackgroundColor = System.Drawing.Color.Linen;
            this.dgvORDENES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvORDENES.Location = new System.Drawing.Point(188, 88);
            this.dgvORDENES.Name = "dgvORDENES";
            this.dgvORDENES.ReadOnly = true;
            this.dgvORDENES.Size = new System.Drawing.Size(1065, 383);
            this.dgvORDENES.TabIndex = 26;
            this.dgvORDENES.DoubleClick += new System.EventHandler(this.dgvORDENES_DoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(971, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 80;
            this.label3.Text = "Nombre proveedor";
            // 
            // btnAGREGAR
            // 
            this.btnAGREGAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAGREGAR.Image = ((System.Drawing.Image)(resources.GetObject("btnAGREGAR.Image")));
            this.btnAGREGAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAGREGAR.Location = new System.Drawing.Point(58, 88);
            this.btnAGREGAR.Name = "btnAGREGAR";
            this.btnAGREGAR.Size = new System.Drawing.Size(93, 60);
            this.btnAGREGAR.TabIndex = 94;
            this.btnAGREGAR.Text = "&Agregar";
            this.btnAGREGAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAGREGAR.UseVisualStyleBackColor = true;
            this.btnAGREGAR.Click += new System.EventHandler(this.btnALTAS_Click);
            // 
            // btnELIMINAR
            // 
            this.btnELIMINAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnELIMINAR.Image = ((System.Drawing.Image)(resources.GetObject("btnELIMINAR.Image")));
            this.btnELIMINAR.Location = new System.Drawing.Point(60, 409);
            this.btnELIMINAR.Name = "btnELIMINAR";
            this.btnELIMINAR.Size = new System.Drawing.Size(91, 62);
            this.btnELIMINAR.TabIndex = 95;
            this.btnELIMINAR.Text = "&Eliminar";
            this.btnELIMINAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnELIMINAR.UseVisualStyleBackColor = true;
            this.btnELIMINAR.Visible = false;
            this.btnELIMINAR.Click += new System.EventHandler(this.btnBAJAS_Click);
            // 
            // btnCONSULTAR
            // 
            this.btnCONSULTAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCONSULTAR.Image = ((System.Drawing.Image)(resources.GetObject("btnCONSULTAR.Image")));
            this.btnCONSULTAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCONSULTAR.Location = new System.Drawing.Point(60, 247);
            this.btnCONSULTAR.Name = "btnCONSULTAR";
            this.btnCONSULTAR.Size = new System.Drawing.Size(91, 60);
            this.btnCONSULTAR.TabIndex = 96;
            this.btnCONSULTAR.Text = "&Consultar";
            this.btnCONSULTAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCONSULTAR.UseVisualStyleBackColor = true;
            this.btnCONSULTAR.Click += new System.EventHandler(this.btnMODIFICACIONES_Click);
            // 
            // btnCANCELAR
            // 
            this.btnCANCELAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCANCELAR.Image = ((System.Drawing.Image)(resources.GetObject("btnCANCELAR.Image")));
            this.btnCANCELAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCANCELAR.Location = new System.Drawing.Point(1159, 495);
            this.btnCANCELAR.Name = "btnCANCELAR";
            this.btnCANCELAR.Size = new System.Drawing.Size(94, 62);
            this.btnCANCELAR.TabIndex = 97;
            this.btnCANCELAR.Text = "&Cerrar";
            this.btnCANCELAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCANCELAR.UseVisualStyleBackColor = true;
            this.btnCANCELAR.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnBUSCAR
            // 
            this.btnBUSCAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBUSCAR.Image = ((System.Drawing.Image)(resources.GetObject("btnBUSCAR.Image")));
            this.btnBUSCAR.Location = new System.Drawing.Point(1178, 27);
            this.btnBUSCAR.Name = "btnBUSCAR";
            this.btnBUSCAR.Size = new System.Drawing.Size(64, 38);
            this.btnBUSCAR.TabIndex = 98;
            this.btnBUSCAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBUSCAR.UseVisualStyleBackColor = true;
            this.btnBUSCAR.Click += new System.EventHandler(this.btnBUSCAR_Click);
            // 
            // txtBUSCAR
            // 
            this.txtBUSCAR.Location = new System.Drawing.Point(1072, 36);
            this.txtBUSCAR.Name = "txtBUSCAR";
            this.txtBUSCAR.Size = new System.Drawing.Size(100, 20);
            this.txtBUSCAR.TabIndex = 99;
            // 
            // frmORDENESDECOMPRA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1384, 569);
            this.Controls.Add(this.txtBUSCAR);
            this.Controls.Add(this.btnBUSCAR);
            this.Controls.Add(this.btnCANCELAR);
            this.Controls.Add(this.btnCONSULTAR);
            this.Controls.Add(this.btnELIMINAR);
            this.Controls.Add(this.btnAGREGAR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvORDENES);
            this.Name = "frmORDENESDECOMPRA";
            this.Text = " Gestionar Ordenes de compra";
            ((System.ComponentModel.ISupportInitialize)(this.dgvORDENES)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvORDENES;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAGREGAR;
        private System.Windows.Forms.Button btnELIMINAR;
        private System.Windows.Forms.Button btnCONSULTAR;
        private System.Windows.Forms.Button btnCANCELAR;
        private System.Windows.Forms.Button btnBUSCAR;
        private System.Windows.Forms.TextBox txtBUSCAR;
    }
}