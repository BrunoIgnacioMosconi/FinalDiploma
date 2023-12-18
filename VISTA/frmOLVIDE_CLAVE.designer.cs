namespace VISTA.MODELO_DE_SEGURIDAD
{
    partial class frmOLVIDE_CLAVE
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtMAIL = new System.Windows.Forms.TextBox();
            this.btnRECUPERAR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mail";
            // 
            // txtMAIL
            // 
            this.txtMAIL.Location = new System.Drawing.Point(110, 28);
            this.txtMAIL.Name = "txtMAIL";
            this.txtMAIL.Size = new System.Drawing.Size(122, 20);
            this.txtMAIL.TabIndex = 2;
            // 
            // btnRECUPERAR
            // 
            this.btnRECUPERAR.Location = new System.Drawing.Point(110, 64);
            this.btnRECUPERAR.Name = "btnRECUPERAR";
            this.btnRECUPERAR.Size = new System.Drawing.Size(122, 23);
            this.btnRECUPERAR.TabIndex = 3;
            this.btnRECUPERAR.Text = "Recuperar clave";
            this.btnRECUPERAR.UseVisualStyleBackColor = true;
            this.btnRECUPERAR.Click += new System.EventHandler(this.btnRECUPERAR_Click);
            // 
            // frmOLVIDE_CLAVE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(335, 135);
            this.Controls.Add(this.btnRECUPERAR);
            this.Controls.Add(this.txtMAIL);
            this.Controls.Add(this.label2);
            this.Name = "frmOLVIDE_CLAVE";
            this.Text = "Recuperar Clave";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMAIL;
        private System.Windows.Forms.Button btnRECUPERAR;
    }
}