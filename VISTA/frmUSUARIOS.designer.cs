namespace VISTA
{
    partial class frmUSUARIOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUSUARIOS));
            this.btnCANCELAR = new System.Windows.Forms.Button();
            this.btnMODIFICACIONES = new System.Windows.Forms.Button();
            this.btnAGREGAR = new System.Windows.Forms.Button();
            this.dgvUSUARIO = new System.Windows.Forms.DataGridView();
            this.btnELIMINAR = new System.Windows.Forms.Button();
            this.txtMAIL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBUSCAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUSUARIO)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCANCELAR
            // 
            this.btnCANCELAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCANCELAR.Image = ((System.Drawing.Image)(resources.GetObject("btnCANCELAR.Image")));
            this.btnCANCELAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCANCELAR.Location = new System.Drawing.Point(1200, 503);
            this.btnCANCELAR.Name = "btnCANCELAR";
            this.btnCANCELAR.Size = new System.Drawing.Size(94, 60);
            this.btnCANCELAR.TabIndex = 106;
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
            this.btnMODIFICACIONES.Location = new System.Drawing.Point(29, 228);
            this.btnMODIFICACIONES.Name = "btnMODIFICACIONES";
            this.btnMODIFICACIONES.Size = new System.Drawing.Size(91, 60);
            this.btnMODIFICACIONES.TabIndex = 105;
            this.btnMODIFICACIONES.Text = "&Modificar";
            this.btnMODIFICACIONES.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMODIFICACIONES.UseVisualStyleBackColor = true;
            this.btnMODIFICACIONES.Click += new System.EventHandler(this.btnMODIFICACIONES_Click);
            // 
            // btnAGREGAR
            // 
            this.btnAGREGAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAGREGAR.Image = ((System.Drawing.Image)(resources.GetObject("btnAGREGAR.Image")));
            this.btnAGREGAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAGREGAR.Location = new System.Drawing.Point(29, 78);
            this.btnAGREGAR.Name = "btnAGREGAR";
            this.btnAGREGAR.Size = new System.Drawing.Size(93, 60);
            this.btnAGREGAR.TabIndex = 103;
            this.btnAGREGAR.Text = "&Agregar";
            this.btnAGREGAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAGREGAR.UseVisualStyleBackColor = true;
            this.btnAGREGAR.Click += new System.EventHandler(this.btnAGREGAR_Click_1);
            // 
            // dgvUSUARIO
            // 
            this.dgvUSUARIO.BackgroundColor = System.Drawing.Color.White;
            this.dgvUSUARIO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUSUARIO.Location = new System.Drawing.Point(137, 78);
            this.dgvUSUARIO.Name = "dgvUSUARIO";
            this.dgvUSUARIO.Size = new System.Drawing.Size(1173, 372);
            this.dgvUSUARIO.TabIndex = 102;
            // 
            // btnELIMINAR
            // 
            this.btnELIMINAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnELIMINAR.Image = ((System.Drawing.Image)(resources.GetObject("btnELIMINAR.Image")));
            this.btnELIMINAR.Location = new System.Drawing.Point(29, 390);
            this.btnELIMINAR.Name = "btnELIMINAR";
            this.btnELIMINAR.Size = new System.Drawing.Size(91, 60);
            this.btnELIMINAR.TabIndex = 104;
            this.btnELIMINAR.Text = "&Desactivar";
            this.btnELIMINAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnELIMINAR.UseVisualStyleBackColor = true;
            this.btnELIMINAR.Click += new System.EventHandler(this.btnELIMINAR_Click);
            // 
            // txtMAIL
            // 
            this.txtMAIL.Location = new System.Drawing.Point(1052, 52);
            this.txtMAIL.Name = "txtMAIL";
            this.txtMAIL.Size = new System.Drawing.Size(100, 20);
            this.txtMAIL.TabIndex = 107;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1009, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 108;
            this.label1.Text = "Mail";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnBUSCAR
            // 
            this.btnBUSCAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBUSCAR.Image = ((System.Drawing.Image)(resources.GetObject("btnBUSCAR.Image")));
            this.btnBUSCAR.Location = new System.Drawing.Point(1178, 34);
            this.btnBUSCAR.Name = "btnBUSCAR";
            this.btnBUSCAR.Size = new System.Drawing.Size(64, 38);
            this.btnBUSCAR.TabIndex = 109;
            this.btnBUSCAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBUSCAR.UseVisualStyleBackColor = true;
            this.btnBUSCAR.Click += new System.EventHandler(this.btnBUSCAR_Click);
            // 
            // frmUSUARIOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1341, 575);
            this.Controls.Add(this.btnBUSCAR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMAIL);
            this.Controls.Add(this.btnCANCELAR);
            this.Controls.Add(this.btnMODIFICACIONES);
            this.Controls.Add(this.btnELIMINAR);
            this.Controls.Add(this.btnAGREGAR);
            this.Controls.Add(this.dgvUSUARIO);
            this.Name = "frmUSUARIOS";
            this.Text = "Gestionar Usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUSUARIO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCANCELAR;
        private System.Windows.Forms.Button btnMODIFICACIONES;
        private System.Windows.Forms.Button btnAGREGAR;
        private System.Windows.Forms.DataGridView dgvUSUARIO;
        private System.Windows.Forms.Button btnELIMINAR;
        private System.Windows.Forms.TextBox txtMAIL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBUSCAR;
    }
}