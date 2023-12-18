namespace VISTA
{
    partial class frmEMPLEADO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEMPLEADO));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNOMBRE = new System.Windows.Forms.TextBox();
            this.txtTELEFONO = new System.Windows.Forms.TextBox();
            this.txtDIRECCION = new System.Windows.Forms.TextBox();
            this.txtAPELLIDO = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "DNI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Direccion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Apellido";
            // 
            // txtNOMBRE
            // 
            this.txtNOMBRE.Location = new System.Drawing.Point(77, 39);
            this.txtNOMBRE.Name = "txtNOMBRE";
            this.txtNOMBRE.Size = new System.Drawing.Size(209, 20);
            this.txtNOMBRE.TabIndex = 5;
            this.txtNOMBRE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNOMBRE_KeyPress);
            // 
            // txtTELEFONO
            // 
            this.txtTELEFONO.Location = new System.Drawing.Point(77, 171);
            this.txtTELEFONO.Name = "txtTELEFONO";
            this.txtTELEFONO.Size = new System.Drawing.Size(209, 20);
            this.txtTELEFONO.TabIndex = 6;
            this.txtTELEFONO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTELEFONO_KeyPress);
            // 
            // txtDIRECCION
            // 
            this.txtDIRECCION.Location = new System.Drawing.Point(77, 130);
            this.txtDIRECCION.Name = "txtDIRECCION";
            this.txtDIRECCION.Size = new System.Drawing.Size(209, 20);
            this.txtDIRECCION.TabIndex = 7;
            // 
            // txtAPELLIDO
            // 
            this.txtAPELLIDO.Location = new System.Drawing.Point(77, 85);
            this.txtAPELLIDO.Name = "txtAPELLIDO";
            this.txtAPELLIDO.Size = new System.Drawing.Size(209, 20);
            this.txtAPELLIDO.TabIndex = 8;
            this.txtAPELLIDO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAPELLIDO_KeyPress);
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(77, 217);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(209, 20);
            this.txtDNI.TabIndex = 9;
            this.txtDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNI_KeyPress);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(220, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 62);
            this.button1.TabIndex = 43;
            this.button1.Text = "Cancelar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(18, 267);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 62);
            this.button2.TabIndex = 42;
            this.button2.Text = "Guardar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmEMPLEADO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(379, 363);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.txtAPELLIDO);
            this.Controls.Add(this.txtDIRECCION);
            this.Controls.Add(this.txtTELEFONO);
            this.Controls.Add(this.txtNOMBRE);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmEMPLEADO";
            this.Text = "Empleado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNOMBRE;
        private System.Windows.Forms.TextBox txtTELEFONO;
        private System.Windows.Forms.TextBox txtDIRECCION;
        private System.Windows.Forms.TextBox txtAPELLIDO;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}