namespace VISTA
{
    partial class frmAUDITORIA_LOGIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAUDITORIA_LOGIN));
            this.dgvAUDITORIA = new System.Windows.Forms.DataGridView();
            this.btnCANCELAR = new System.Windows.Forms.Button();
            this.btnBUSCAR = new System.Windows.Forms.Button();
            this.txtBUSCAR = new System.Windows.Forms.TextBox();
            this.Usuario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAUDITORIA)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAUDITORIA
            // 
            this.dgvAUDITORIA.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvAUDITORIA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAUDITORIA.Location = new System.Drawing.Point(12, 56);
            this.dgvAUDITORIA.Name = "dgvAUDITORIA";
            this.dgvAUDITORIA.Size = new System.Drawing.Size(1141, 353);
            this.dgvAUDITORIA.TabIndex = 0;
            // 
            // btnCANCELAR
            // 
            this.btnCANCELAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCANCELAR.Image = ((System.Drawing.Image)(resources.GetObject("btnCANCELAR.Image")));
            this.btnCANCELAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCANCELAR.Location = new System.Drawing.Point(26, 429);
            this.btnCANCELAR.Name = "btnCANCELAR";
            this.btnCANCELAR.Size = new System.Drawing.Size(94, 60);
            this.btnCANCELAR.TabIndex = 102;
            this.btnCANCELAR.Text = "&Cerrar";
            this.btnCANCELAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCANCELAR.UseVisualStyleBackColor = true;
            this.btnCANCELAR.Click += new System.EventHandler(this.btnCANCELAR_Click);
            // 
            // btnBUSCAR
            // 
            this.btnBUSCAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBUSCAR.Image = ((System.Drawing.Image)(resources.GetObject("btnBUSCAR.Image")));
            this.btnBUSCAR.Location = new System.Drawing.Point(189, 12);
            this.btnBUSCAR.Name = "btnBUSCAR";
            this.btnBUSCAR.Size = new System.Drawing.Size(64, 38);
            this.btnBUSCAR.TabIndex = 105;
            this.btnBUSCAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBUSCAR.UseVisualStyleBackColor = true;
            this.btnBUSCAR.Click += new System.EventHandler(this.btnBUSCAR_Click);
            // 
            // txtBUSCAR
            // 
            this.txtBUSCAR.Location = new System.Drawing.Point(61, 17);
            this.txtBUSCAR.Name = "txtBUSCAR";
            this.txtBUSCAR.Size = new System.Drawing.Size(100, 20);
            this.txtBUSCAR.TabIndex = 106;
            // 
            // Usuario
            // 
            this.Usuario.AutoSize = true;
            this.Usuario.Location = new System.Drawing.Point(12, 20);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(43, 13);
            this.Usuario.TabIndex = 107;
            this.Usuario.Text = "Usuario";
            // 
            // frmAUDITORIA_LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1211, 536);
            this.Controls.Add(this.Usuario);
            this.Controls.Add(this.txtBUSCAR);
            this.Controls.Add(this.btnBUSCAR);
            this.Controls.Add(this.btnCANCELAR);
            this.Controls.Add(this.dgvAUDITORIA);
            this.Name = "frmAUDITORIA_LOGIN";
            this.Text = "Auditoria LogIn";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAUDITORIA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAUDITORIA;
        private System.Windows.Forms.Button btnCANCELAR;
        private System.Windows.Forms.Button btnBUSCAR;
        private System.Windows.Forms.TextBox txtBUSCAR;
        private System.Windows.Forms.Label Usuario;
    }
}