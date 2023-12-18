namespace VISTA
{
    partial class frmPROVEEDORES
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPROVEEDORES));
            this.btnSALIR = new System.Windows.Forms.Button();
            this.btnMODIFICAR = new System.Windows.Forms.Button();
            this.btnELIMINAR = new System.Windows.Forms.Button();
            this.btnAGREGAR = new System.Windows.Forms.Button();
            this.dgvPROVEEDOR = new System.Windows.Forms.DataGridView();
            this.btnCANCELAR = new System.Windows.Forms.Button();
            this.btnMODIFICACIONES = new System.Windows.Forms.Button();
            this.btnnELIMINAR = new System.Windows.Forms.Button();
            this.bntAGREGAR = new System.Windows.Forms.Button();
            this.txtBUSCAR = new System.Windows.Forms.TextBox();
            this.btnBUSCAR = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPROVEEDOR)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSALIR
            // 
            this.btnSALIR.Location = new System.Drawing.Point(-103, 247);
            this.btnSALIR.Name = "btnSALIR";
            this.btnSALIR.Size = new System.Drawing.Size(75, 23);
            this.btnSALIR.TabIndex = 9;
            this.btnSALIR.Text = "SALIR";
            this.btnSALIR.UseVisualStyleBackColor = true;
            // 
            // btnMODIFICAR
            // 
            this.btnMODIFICAR.Location = new System.Drawing.Point(-103, 189);
            this.btnMODIFICAR.Name = "btnMODIFICAR";
            this.btnMODIFICAR.Size = new System.Drawing.Size(75, 23);
            this.btnMODIFICAR.TabIndex = 8;
            this.btnMODIFICAR.Text = "MODIFICAR";
            this.btnMODIFICAR.UseVisualStyleBackColor = true;
            // 
            // btnELIMINAR
            // 
            this.btnELIMINAR.Location = new System.Drawing.Point(-103, 218);
            this.btnELIMINAR.Name = "btnELIMINAR";
            this.btnELIMINAR.Size = new System.Drawing.Size(75, 23);
            this.btnELIMINAR.TabIndex = 7;
            this.btnELIMINAR.Text = "ELIMINAR";
            this.btnELIMINAR.UseVisualStyleBackColor = true;
            // 
            // btnAGREGAR
            // 
            this.btnAGREGAR.Location = new System.Drawing.Point(-103, 160);
            this.btnAGREGAR.Name = "btnAGREGAR";
            this.btnAGREGAR.Size = new System.Drawing.Size(75, 23);
            this.btnAGREGAR.TabIndex = 6;
            this.btnAGREGAR.Text = "AGREGAR";
            this.btnAGREGAR.UseVisualStyleBackColor = true;
            // 
            // dgvPROVEEDOR
            // 
            this.dgvPROVEEDOR.BackgroundColor = System.Drawing.Color.White;
            this.dgvPROVEEDOR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPROVEEDOR.Location = new System.Drawing.Point(145, 107);
            this.dgvPROVEEDOR.Name = "dgvPROVEEDOR";
            this.dgvPROVEEDOR.Size = new System.Drawing.Size(1024, 377);
            this.dgvPROVEEDOR.TabIndex = 5;
            // 
            // btnCANCELAR
            // 
            this.btnCANCELAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCANCELAR.Image = ((System.Drawing.Image)(resources.GetObject("btnCANCELAR.Image")));
            this.btnCANCELAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCANCELAR.Location = new System.Drawing.Point(1075, 490);
            this.btnCANCELAR.Name = "btnCANCELAR";
            this.btnCANCELAR.Size = new System.Drawing.Size(94, 60);
            this.btnCANCELAR.TabIndex = 101;
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
            this.btnMODIFICACIONES.Location = new System.Drawing.Point(39, 251);
            this.btnMODIFICACIONES.Name = "btnMODIFICACIONES";
            this.btnMODIFICACIONES.Size = new System.Drawing.Size(91, 60);
            this.btnMODIFICACIONES.TabIndex = 100;
            this.btnMODIFICACIONES.Text = "&Modificar";
            this.btnMODIFICACIONES.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMODIFICACIONES.UseVisualStyleBackColor = true;
            this.btnMODIFICACIONES.Click += new System.EventHandler(this.btnMODIFICACIONES_Click);
            // 
            // btnnELIMINAR
            // 
            this.btnnELIMINAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnnELIMINAR.Image = ((System.Drawing.Image)(resources.GetObject("btnnELIMINAR.Image")));
            this.btnnELIMINAR.Location = new System.Drawing.Point(39, 424);
            this.btnnELIMINAR.Name = "btnnELIMINAR";
            this.btnnELIMINAR.Size = new System.Drawing.Size(91, 60);
            this.btnnELIMINAR.TabIndex = 99;
            this.btnnELIMINAR.Text = "&Eliminar";
            this.btnnELIMINAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnnELIMINAR.UseVisualStyleBackColor = true;
            this.btnnELIMINAR.Click += new System.EventHandler(this.button1_Click);
            // 
            // bntAGREGAR
            // 
            this.bntAGREGAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bntAGREGAR.Image = ((System.Drawing.Image)(resources.GetObject("bntAGREGAR.Image")));
            this.bntAGREGAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bntAGREGAR.Location = new System.Drawing.Point(37, 107);
            this.bntAGREGAR.Name = "bntAGREGAR";
            this.bntAGREGAR.Size = new System.Drawing.Size(93, 60);
            this.bntAGREGAR.TabIndex = 98;
            this.bntAGREGAR.Text = "&Agregar";
            this.bntAGREGAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bntAGREGAR.UseVisualStyleBackColor = true;
            this.bntAGREGAR.Click += new System.EventHandler(this.bntAGREGAR_Click);
            // 
            // txtBUSCAR
            // 
            this.txtBUSCAR.Location = new System.Drawing.Point(999, 77);
            this.txtBUSCAR.Name = "txtBUSCAR";
            this.txtBUSCAR.Size = new System.Drawing.Size(100, 20);
            this.txtBUSCAR.TabIndex = 107;
            // 
            // btnBUSCAR
            // 
            this.btnBUSCAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBUSCAR.Image = ((System.Drawing.Image)(resources.GetObject("btnBUSCAR.Image")));
            this.btnBUSCAR.Location = new System.Drawing.Point(1105, 63);
            this.btnBUSCAR.Name = "btnBUSCAR";
            this.btnBUSCAR.Size = new System.Drawing.Size(64, 38);
            this.btnBUSCAR.TabIndex = 106;
            this.btnBUSCAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBUSCAR.UseVisualStyleBackColor = true;
            this.btnBUSCAR.Click += new System.EventHandler(this.btnBUSCAR_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(934, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 105;
            this.label3.Text = "Nombre";
            // 
            // frmPROVEEDORES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1218, 589);
            this.Controls.Add(this.txtBUSCAR);
            this.Controls.Add(this.btnBUSCAR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCANCELAR);
            this.Controls.Add(this.btnMODIFICACIONES);
            this.Controls.Add(this.btnnELIMINAR);
            this.Controls.Add(this.bntAGREGAR);
            this.Controls.Add(this.btnSALIR);
            this.Controls.Add(this.btnMODIFICAR);
            this.Controls.Add(this.btnELIMINAR);
            this.Controls.Add(this.btnAGREGAR);
            this.Controls.Add(this.dgvPROVEEDOR);
            this.Name = "frmPROVEEDORES";
            this.Text = "Gestionar proveedores";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPROVEEDOR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSALIR;
        private System.Windows.Forms.Button btnMODIFICAR;
        private System.Windows.Forms.Button btnELIMINAR;
        private System.Windows.Forms.Button btnAGREGAR;
        private System.Windows.Forms.DataGridView dgvPROVEEDOR;
        private System.Windows.Forms.Button btnCANCELAR;
        private System.Windows.Forms.Button btnMODIFICACIONES;
        private System.Windows.Forms.Button btnnELIMINAR;
        private System.Windows.Forms.Button bntAGREGAR;
        private System.Windows.Forms.TextBox txtBUSCAR;
        private System.Windows.Forms.Button btnBUSCAR;
        private System.Windows.Forms.Label label3;
    }
}