namespace VISTA.MODELO_DE_SEGURIDAD
{
    partial class frmCAMBIAR_CLAVE
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCVIEJA = new System.Windows.Forms.TextBox();
            this.txtNCONTRASEÑA = new System.Windows.Forms.TextBox();
            this.txtRCONTRASEÑA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGUARDAR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nueva contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña actual";
            // 
            // txtCVIEJA
            // 
            this.txtCVIEJA.Location = new System.Drawing.Point(125, 32);
            this.txtCVIEJA.Name = "txtCVIEJA";
            this.txtCVIEJA.PasswordChar = '*';
            this.txtCVIEJA.Size = new System.Drawing.Size(100, 20);
            this.txtCVIEJA.TabIndex = 2;
            this.txtCVIEJA.Enter += new System.EventHandler(this.txtCVIEJA_Enter);
            this.txtCVIEJA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCVIEJA_KeyDown);
            // 
            // txtNCONTRASEÑA
            // 
            this.txtNCONTRASEÑA.Location = new System.Drawing.Point(125, 63);
            this.txtNCONTRASEÑA.Name = "txtNCONTRASEÑA";
            this.txtNCONTRASEÑA.PasswordChar = '*';
            this.txtNCONTRASEÑA.Size = new System.Drawing.Size(100, 20);
            this.txtNCONTRASEÑA.TabIndex = 3;
            this.txtNCONTRASEÑA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNCONTRASEÑA_KeyDown);
            // 
            // txtRCONTRASEÑA
            // 
            this.txtRCONTRASEÑA.Location = new System.Drawing.Point(125, 99);
            this.txtRCONTRASEÑA.Name = "txtRCONTRASEÑA";
            this.txtRCONTRASEÑA.PasswordChar = '*';
            this.txtRCONTRASEÑA.Size = new System.Drawing.Size(100, 20);
            this.txtRCONTRASEÑA.TabIndex = 4;
            this.txtRCONTRASEÑA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRCONTRASEÑA_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Repetir contraseña";
            // 
            // btnGUARDAR
            // 
            this.btnGUARDAR.Location = new System.Drawing.Point(100, 150);
            this.btnGUARDAR.Name = "btnGUARDAR";
            this.btnGUARDAR.Size = new System.Drawing.Size(75, 23);
            this.btnGUARDAR.TabIndex = 6;
            this.btnGUARDAR.Text = "Cambiar";
            this.btnGUARDAR.UseVisualStyleBackColor = true;
            this.btnGUARDAR.Click += new System.EventHandler(this.btnGUARDAR_Click);
            // 
            // frmCAMBIAR_CLAVE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(293, 215);
            this.Controls.Add(this.btnGUARDAR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRCONTRASEÑA);
            this.Controls.Add(this.txtNCONTRASEÑA);
            this.Controls.Add(this.txtCVIEJA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCAMBIAR_CLAVE";
            this.Text = "Cambiar clave";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCVIEJA;
        private System.Windows.Forms.TextBox txtNCONTRASEÑA;
        private System.Windows.Forms.TextBox txtRCONTRASEÑA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGUARDAR;
    }
}