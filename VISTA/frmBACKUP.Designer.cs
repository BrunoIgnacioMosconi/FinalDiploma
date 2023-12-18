namespace VISTA
{
    partial class frmBACKUP
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
            this.btnGENERAR = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRESTAURAR = new System.Windows.Forms.Button();
            this.OpenFileRestaurarCopia = new System.Windows.Forms.OpenFileDialog();
            this.btnSALIR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGENERAR
            // 
            this.btnGENERAR.Location = new System.Drawing.Point(121, 63);
            this.btnGENERAR.Name = "btnGENERAR";
            this.btnGENERAR.Size = new System.Drawing.Size(91, 23);
            this.btnGENERAR.TabIndex = 0;
            this.btnGENERAR.Text = "Generar";
            this.btnGENERAR.UseVisualStyleBackColor = true;
            this.btnGENERAR.Click += new System.EventHandler(this.gtnGENERAR_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "BACK UP";
            // 
            // btnRESTAURAR
            // 
            this.btnRESTAURAR.Location = new System.Drawing.Point(121, 92);
            this.btnRESTAURAR.Name = "btnRESTAURAR";
            this.btnRESTAURAR.Size = new System.Drawing.Size(91, 23);
            this.btnRESTAURAR.TabIndex = 2;
            this.btnRESTAURAR.Text = "Restaurar";
            this.btnRESTAURAR.UseVisualStyleBackColor = true;
            this.btnRESTAURAR.Click += new System.EventHandler(this.btnRESTAURAR_Click);
            // 
            // OpenFileRestaurarCopia
            // 
            this.OpenFileRestaurarCopia.FileName = "openFileDialog1";
            // 
            // btnSALIR
            // 
            this.btnSALIR.Location = new System.Drawing.Point(121, 177);
            this.btnSALIR.Name = "btnSALIR";
            this.btnSALIR.Size = new System.Drawing.Size(91, 23);
            this.btnSALIR.TabIndex = 3;
            this.btnSALIR.Text = "Salir";
            this.btnSALIR.UseVisualStyleBackColor = true;
            this.btnSALIR.Click += new System.EventHandler(this.btnSALIR_Click);
            // 
            // frmBACKUP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(341, 212);
            this.Controls.Add(this.btnSALIR);
            this.Controls.Add(this.btnRESTAURAR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGENERAR);
            this.Name = "frmBACKUP";
            this.Text = "Generar Back Up";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGENERAR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRESTAURAR;
        private System.Windows.Forms.OpenFileDialog OpenFileRestaurarCopia;
        private System.Windows.Forms.Button btnSALIR;
    }
}