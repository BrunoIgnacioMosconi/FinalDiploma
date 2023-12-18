namespace VISTA
{
    partial class frmSTOCK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSTOCK));
            this.dgvSTOCK = new System.Windows.Forms.DataGridView();
            this.btnAUMENTAR = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSTOCK)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSTOCK
            // 
            this.dgvSTOCK.BackgroundColor = System.Drawing.Color.White;
            this.dgvSTOCK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSTOCK.Location = new System.Drawing.Point(122, 52);
            this.dgvSTOCK.Name = "dgvSTOCK";
            this.dgvSTOCK.Size = new System.Drawing.Size(1042, 415);
            this.dgvSTOCK.TabIndex = 0;
            // 
            // btnAUMENTAR
            // 
            this.btnAUMENTAR.Location = new System.Drawing.Point(12, 52);
            this.btnAUMENTAR.Name = "btnAUMENTAR";
            this.btnAUMENTAR.Size = new System.Drawing.Size(85, 58);
            this.btnAUMENTAR.TabIndex = 1;
            this.btnAUMENTAR.Text = "Aplicar";
            this.btnAUMENTAR.UseVisualStyleBackColor = true;
            this.btnAUMENTAR.Click += new System.EventHandler(this.btnAUMENTAR_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(12, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 62);
            this.button1.TabIndex = 42;
            this.button1.Text = "Cancelar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmSTOCK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1212, 536);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAUMENTAR);
            this.Controls.Add(this.dgvSTOCK);
            this.Name = "frmSTOCK";
            this.Text = "Stock";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSTOCK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSTOCK;
        private System.Windows.Forms.Button btnAUMENTAR;
        private System.Windows.Forms.Button button1;
    }
}