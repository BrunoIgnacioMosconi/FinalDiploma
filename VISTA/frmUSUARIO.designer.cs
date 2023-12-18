namespace VISTA
{
    partial class frmUSUARIO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUSUARIO));
            this.btnCANCELAR = new System.Windows.Forms.Button();
            this.btnGUARDAR = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chEstado = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUSUARIO = new System.Windows.Forms.TextBox();
            this.txtMAIL = new System.Windows.Forms.TextBox();
            this.txtNOMBRE = new System.Windows.Forms.TextBox();
            this.txtCONTRASEÑA = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.chkGRUPOS = new System.Windows.Forms.CheckedListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCANCELAR
            // 
            this.btnCANCELAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCANCELAR.Image = ((System.Drawing.Image)(resources.GetObject("btnCANCELAR.Image")));
            this.btnCANCELAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCANCELAR.Location = new System.Drawing.Point(380, 332);
            this.btnCANCELAR.Name = "btnCANCELAR";
            this.btnCANCELAR.Size = new System.Drawing.Size(66, 62);
            this.btnCANCELAR.TabIndex = 107;
            this.btnCANCELAR.Text = "Cancelar";
            this.btnCANCELAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCANCELAR.UseVisualStyleBackColor = true;
            this.btnCANCELAR.Click += new System.EventHandler(this.btnCANCELAR_Click);
            // 
            // btnGUARDAR
            // 
            this.btnGUARDAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGUARDAR.Image = ((System.Drawing.Image)(resources.GetObject("btnGUARDAR.Image")));
            this.btnGUARDAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGUARDAR.Location = new System.Drawing.Point(3, 332);
            this.btnGUARDAR.Name = "btnGUARDAR";
            this.btnGUARDAR.Size = new System.Drawing.Size(67, 62);
            this.btnGUARDAR.TabIndex = 106;
            this.btnGUARDAR.Text = "Guardar";
            this.btnGUARDAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGUARDAR.UseVisualStyleBackColor = true;
            this.btnGUARDAR.Click += new System.EventHandler(this.btnGUARDAR_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(420, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 109;
            this.label5.Text = "Mail";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 110;
            this.label6.Text = "Estado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Usuario";
            // 
            // chEstado
            // 
            this.chEstado.AutoSize = true;
            this.chEstado.Location = new System.Drawing.Point(83, 114);
            this.chEstado.Name = "chEstado";
            this.chEstado.Size = new System.Drawing.Size(56, 17);
            this.chEstado.TabIndex = 111;
            this.chEstado.Text = "Activo";
            this.chEstado.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nombre";
            // 
            // txtUSUARIO
            // 
            this.txtUSUARIO.Location = new System.Drawing.Point(83, 65);
            this.txtUSUARIO.Name = "txtUSUARIO";
            this.txtUSUARIO.Size = new System.Drawing.Size(238, 20);
            this.txtUSUARIO.TabIndex = 2;
            // 
            // txtMAIL
            // 
            this.txtMAIL.Location = new System.Drawing.Point(83, 191);
            this.txtMAIL.Name = "txtMAIL";
            this.txtMAIL.Size = new System.Drawing.Size(238, 20);
            this.txtMAIL.TabIndex = 108;
            this.txtMAIL.TextChanged += new System.EventHandler(this.txtMAIL_TextChanged);
            // 
            // txtNOMBRE
            // 
            this.txtNOMBRE.Location = new System.Drawing.Point(83, 16);
            this.txtNOMBRE.Name = "txtNOMBRE";
            this.txtNOMBRE.Size = new System.Drawing.Size(238, 20);
            this.txtNOMBRE.TabIndex = 1;
            this.txtNOMBRE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNOMBRE_KeyPress);
            // 
            // txtCONTRASEÑA
            // 
            this.txtCONTRASEÑA.Location = new System.Drawing.Point(83, 149);
            this.txtCONTRASEÑA.Name = "txtCONTRASEÑA";
            this.txtCONTRASEÑA.Size = new System.Drawing.Size(238, 20);
            this.txtCONTRASEÑA.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(443, 293);
            this.tabControl1.TabIndex = 112;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txtNOMBRE);
            this.tabPage1.Controls.Add(this.txtCONTRASEÑA);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtMAIL);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.chEstado);
            this.tabPage1.Controls.Add(this.txtUSUARIO);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(435, 267);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Datos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 112;
            this.label7.Text = "Mail";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.chkGRUPOS);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(435, 267);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Grupo";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Grupos";
            // 
            // chkGRUPOS
            // 
            this.chkGRUPOS.FormattingEnabled = true;
            this.chkGRUPOS.Location = new System.Drawing.Point(59, 4);
            this.chkGRUPOS.Name = "chkGRUPOS";
            this.chkGRUPOS.Size = new System.Drawing.Size(362, 259);
            this.chkGRUPOS.TabIndex = 9;
            this.chkGRUPOS.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chkGRUPOS_ItemCheck);
            this.chkGRUPOS.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chkGRUPOS_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, -27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Grupos:";
            // 
            // frmUSUARIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(505, 406);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnCANCELAR);
            this.Controls.Add(this.btnGUARDAR);
            this.Controls.Add(this.label5);
            this.Name = "frmUSUARIO";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.frmUSUARIO_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCANCELAR;
        private System.Windows.Forms.Button btnGUARDAR;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chEstado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUSUARIO;
        private System.Windows.Forms.TextBox txtMAIL;
        private System.Windows.Forms.TextBox txtNOMBRE;
        private System.Windows.Forms.TextBox txtCONTRASEÑA;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckedListBox chkGRUPOS;
        private System.Windows.Forms.Label label8;
    }
}