namespace VISTA
{
    partial class frmGRUPOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGRUPOS));
            this.btnCANCELAR = new System.Windows.Forms.Button();
            this.btnMODIFICACIONES = new System.Windows.Forms.Button();
            this.btnELIMINAR = new System.Windows.Forms.Button();
            this.btnAGREGAR = new System.Windows.Forms.Button();
            this.dgvGRUPOS = new System.Windows.Forms.DataGridView();
            this.txtBUSCAR = new System.Windows.Forms.TextBox();
            this.btnBUSCAR = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGRUPOS)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCANCELAR
            // 
            this.btnCANCELAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCANCELAR.Image = ((System.Drawing.Image)(resources.GetObject("btnCANCELAR.Image")));
            this.btnCANCELAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCANCELAR.Location = new System.Drawing.Point(971, 404);
            this.btnCANCELAR.Name = "btnCANCELAR";
            this.btnCANCELAR.Size = new System.Drawing.Size(94, 60);
            this.btnCANCELAR.TabIndex = 111;
            this.btnCANCELAR.Text = "&Cerrar";
            this.btnCANCELAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCANCELAR.UseVisualStyleBackColor = true;
            this.btnCANCELAR.Click += new System.EventHandler(this.btnCANCELAR_Click);
            // 
            // btnMODIFICACIONES
            // 
            this.btnMODIFICACIONES.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMODIFICACIONES.Image = ((System.Drawing.Image)(resources.GetObject("btnMODIFICACIONES.Image")));
            this.btnMODIFICACIONES.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMODIFICACIONES.Location = new System.Drawing.Point(2, 195);
            this.btnMODIFICACIONES.Name = "btnMODIFICACIONES";
            this.btnMODIFICACIONES.Size = new System.Drawing.Size(91, 60);
            this.btnMODIFICACIONES.TabIndex = 110;
            this.btnMODIFICACIONES.Text = "&Modificar";
            this.btnMODIFICACIONES.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMODIFICACIONES.UseVisualStyleBackColor = true;
            this.btnMODIFICACIONES.Click += new System.EventHandler(this.btnMODIFICACIONES_Click);
            // 
            // btnELIMINAR
            // 
            this.btnELIMINAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnELIMINAR.Image = ((System.Drawing.Image)(resources.GetObject("btnELIMINAR.Image")));
            this.btnELIMINAR.Location = new System.Drawing.Point(4, 329);
            this.btnELIMINAR.Name = "btnELIMINAR";
            this.btnELIMINAR.Size = new System.Drawing.Size(91, 60);
            this.btnELIMINAR.TabIndex = 109;
            this.btnELIMINAR.Text = "&Eliminar";
            this.btnELIMINAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnELIMINAR.UseVisualStyleBackColor = true;
            this.btnELIMINAR.Click += new System.EventHandler(this.btnELIMINAR_Click);
            // 
            // btnAGREGAR
            // 
            this.btnAGREGAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAGREGAR.Image = ((System.Drawing.Image)(resources.GetObject("btnAGREGAR.Image")));
            this.btnAGREGAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAGREGAR.Location = new System.Drawing.Point(2, 70);
            this.btnAGREGAR.Name = "btnAGREGAR";
            this.btnAGREGAR.Size = new System.Drawing.Size(93, 60);
            this.btnAGREGAR.TabIndex = 108;
            this.btnAGREGAR.Text = "&Agregar";
            this.btnAGREGAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAGREGAR.UseVisualStyleBackColor = true;
            this.btnAGREGAR.Click += new System.EventHandler(this.btnAGREGAR_Click);
            // 
            // dgvGRUPOS
            // 
            this.dgvGRUPOS.BackgroundColor = System.Drawing.Color.Linen;
            this.dgvGRUPOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGRUPOS.Location = new System.Drawing.Point(110, 70);
            this.dgvGRUPOS.Name = "dgvGRUPOS";
            this.dgvGRUPOS.Size = new System.Drawing.Size(955, 319);
            this.dgvGRUPOS.TabIndex = 107;
            // 
            // txtBUSCAR
            // 
            this.txtBUSCAR.Location = new System.Drawing.Point(887, 44);
            this.txtBUSCAR.Name = "txtBUSCAR";
            this.txtBUSCAR.Size = new System.Drawing.Size(100, 20);
            this.txtBUSCAR.TabIndex = 114;
            // 
            // btnBUSCAR
            // 
            this.btnBUSCAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBUSCAR.Image = ((System.Drawing.Image)(resources.GetObject("btnBUSCAR.Image")));
            this.btnBUSCAR.Location = new System.Drawing.Point(993, 30);
            this.btnBUSCAR.Name = "btnBUSCAR";
            this.btnBUSCAR.Size = new System.Drawing.Size(64, 38);
            this.btnBUSCAR.TabIndex = 113;
            this.btnBUSCAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBUSCAR.UseVisualStyleBackColor = true;
            this.btnBUSCAR.Click += new System.EventHandler(this.btnBUSCAR_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(837, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 112;
            this.label3.Text = "Nombre";
            // 
            // frmGRUPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1108, 499);
            this.Controls.Add(this.txtBUSCAR);
            this.Controls.Add(this.btnBUSCAR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCANCELAR);
            this.Controls.Add(this.btnMODIFICACIONES);
            this.Controls.Add(this.btnELIMINAR);
            this.Controls.Add(this.btnAGREGAR);
            this.Controls.Add(this.dgvGRUPOS);
            this.Name = "frmGRUPOS";
            this.Text = "Gestionar Grupos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGRUPOS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCANCELAR;
        private System.Windows.Forms.Button btnMODIFICACIONES;
        private System.Windows.Forms.Button btnELIMINAR;
        private System.Windows.Forms.Button btnAGREGAR;
        private System.Windows.Forms.DataGridView dgvGRUPOS;
        private System.Windows.Forms.TextBox txtBUSCAR;
        private System.Windows.Forms.Button btnBUSCAR;
        private System.Windows.Forms.Label label3;
    }
}