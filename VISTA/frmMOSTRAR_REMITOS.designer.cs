namespace VISTA
{
    partial class frmMOSTRAR_REMITOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMOSTRAR_REMITOS));
            this.dgvREMITOS = new System.Windows.Forms.DataGridView();
            this.dtpFECHA = new System.Windows.Forms.DateTimePicker();
            this.btnBUSCAR = new System.Windows.Forms.Button();
            this.btn_CONSULTAR = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvREMITOS)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvREMITOS
            // 
            this.dgvREMITOS.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvREMITOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvREMITOS.Location = new System.Drawing.Point(12, 56);
            this.dgvREMITOS.Name = "dgvREMITOS";
            this.dgvREMITOS.Size = new System.Drawing.Size(1103, 357);
            this.dgvREMITOS.TabIndex = 0;
            // 
            // dtpFECHA
            // 
            this.dtpFECHA.Location = new System.Drawing.Point(13, 30);
            this.dtpFECHA.Name = "dtpFECHA";
            this.dtpFECHA.Size = new System.Drawing.Size(233, 20);
            this.dtpFECHA.TabIndex = 1;
            // 
            // btnBUSCAR
            // 
            this.btnBUSCAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBUSCAR.Image = ((System.Drawing.Image)(resources.GetObject("btnBUSCAR.Image")));
            this.btnBUSCAR.Location = new System.Drawing.Point(262, 15);
            this.btnBUSCAR.Name = "btnBUSCAR";
            this.btnBUSCAR.Size = new System.Drawing.Size(64, 38);
            this.btnBUSCAR.TabIndex = 99;
            this.btnBUSCAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBUSCAR.UseVisualStyleBackColor = true;
            this.btnBUSCAR.Click += new System.EventHandler(this.btnBUSCAR_Click);
            // 
            // btn_CONSULTAR
            // 
            this.btn_CONSULTAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_CONSULTAR.Image = ((System.Drawing.Image)(resources.GetObject("btn_CONSULTAR.Image")));
            this.btn_CONSULTAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_CONSULTAR.Location = new System.Drawing.Point(12, 419);
            this.btn_CONSULTAR.Name = "btn_CONSULTAR";
            this.btn_CONSULTAR.Size = new System.Drawing.Size(91, 60);
            this.btn_CONSULTAR.TabIndex = 103;
            this.btn_CONSULTAR.Text = "&Consultar";
            this.btn_CONSULTAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_CONSULTAR.UseVisualStyleBackColor = true;
            this.btn_CONSULTAR.Click += new System.EventHandler(this.btn_CONSULTAR_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(1006, 419);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 67);
            this.button1.TabIndex = 104;
            this.button1.Text = "Cancelar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMOSTRAR_REMITOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1136, 526);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_CONSULTAR);
            this.Controls.Add(this.btnBUSCAR);
            this.Controls.Add(this.dtpFECHA);
            this.Controls.Add(this.dgvREMITOS);
            this.Name = "frmMOSTRAR_REMITOS";
            this.Text = "Remitos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvREMITOS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvREMITOS;
        private System.Windows.Forms.DateTimePicker dtpFECHA;
        private System.Windows.Forms.Button btnBUSCAR;
        private System.Windows.Forms.Button btn_CONSULTAR;
        private System.Windows.Forms.Button button1;
    }
}