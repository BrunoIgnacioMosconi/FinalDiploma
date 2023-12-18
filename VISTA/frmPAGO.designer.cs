namespace VISTA
{
    partial class frmPAGO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPAGO));
            this.btnAPLICAR = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCUOTA = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPRECIOXCUOTA = new System.Windows.Forms.Label();
            this.lblCANTIDAD = new System.Windows.Forms.Label();
            this.lblPRECIO = new System.Windows.Forms.Label();
            this.btnCONFIRMAR = new System.Windows.Forms.Button();
            this.txtFP1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTOTAL = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAPLICAR
            // 
            this.btnAPLICAR.Location = new System.Drawing.Point(8, 218);
            this.btnAPLICAR.Name = "btnAPLICAR";
            this.btnAPLICAR.Size = new System.Drawing.Size(89, 23);
            this.btnAPLICAR.TabIndex = 1;
            this.btnAPLICAR.Text = "Aplicar";
            this.btnAPLICAR.UseVisualStyleBackColor = true;
            this.btnAPLICAR.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Formas de pago 1";
            // 
            // cmbCUOTA
            // 
            this.cmbCUOTA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCUOTA.FormattingEnabled = true;
            this.cmbCUOTA.Location = new System.Drawing.Point(11, 29);
            this.cmbCUOTA.Name = "cmbCUOTA";
            this.cmbCUOTA.Size = new System.Drawing.Size(89, 21);
            this.cmbCUOTA.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "Cantidad de cuotas:";
            // 
            // lblPRECIOXCUOTA
            // 
            this.lblPRECIOXCUOTA.AutoSize = true;
            this.lblPRECIOXCUOTA.Location = new System.Drawing.Point(11, 104);
            this.lblPRECIOXCUOTA.Name = "lblPRECIOXCUOTA";
            this.lblPRECIOXCUOTA.Size = new System.Drawing.Size(88, 13);
            this.lblPRECIOXCUOTA.TabIndex = 50;
            this.lblPRECIOXCUOTA.Text = "Precio por cuota:";
            // 
            // lblCANTIDAD
            // 
            this.lblCANTIDAD.AutoSize = true;
            this.lblCANTIDAD.Location = new System.Drawing.Point(125, 72);
            this.lblCANTIDAD.Name = "lblCANTIDAD";
            this.lblCANTIDAD.Size = new System.Drawing.Size(35, 13);
            this.lblCANTIDAD.TabIndex = 51;
            this.lblCANTIDAD.Text = "label1";
            // 
            // lblPRECIO
            // 
            this.lblPRECIO.AutoSize = true;
            this.lblPRECIO.Location = new System.Drawing.Point(125, 104);
            this.lblPRECIO.Name = "lblPRECIO";
            this.lblPRECIO.Size = new System.Drawing.Size(35, 13);
            this.lblPRECIO.TabIndex = 52;
            this.lblPRECIO.Text = "label1";
            // 
            // btnCONFIRMAR
            // 
            this.btnCONFIRMAR.Location = new System.Drawing.Point(113, 218);
            this.btnCONFIRMAR.Name = "btnCONFIRMAR";
            this.btnCONFIRMAR.Size = new System.Drawing.Size(89, 23);
            this.btnCONFIRMAR.TabIndex = 53;
            this.btnCONFIRMAR.Text = "Confirmar";
            this.btnCONFIRMAR.UseVisualStyleBackColor = true;
            this.btnCONFIRMAR.Click += new System.EventHandler(this.btnCONFIRMAR_Click);
            // 
            // txtFP1
            // 
            this.txtFP1.Location = new System.Drawing.Point(141, 29);
            this.txtFP1.Name = "txtFP1";
            this.txtFP1.Size = new System.Drawing.Size(61, 20);
            this.txtFP1.TabIndex = 62;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 64;
            this.label3.Text = "Total:";
            // 
            // lblTOTAL
            // 
            this.lblTOTAL.AutoSize = true;
            this.lblTOTAL.Location = new System.Drawing.Point(62, 155);
            this.lblTOTAL.Name = "lblTOTAL";
            this.lblTOTAL.Size = new System.Drawing.Size(35, 13);
            this.lblTOTAL.TabIndex = 63;
            this.lblTOTAL.Text = "label1";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(555, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 52);
            this.button1.TabIndex = 108;
            this.button1.Text = "Cancelar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(138, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 110;
            this.label7.Text = "Monto";
            // 
            // frmPAGO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(633, 300);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTOTAL);
            this.Controls.Add(this.txtFP1);
            this.Controls.Add(this.btnCONFIRMAR);
            this.Controls.Add(this.lblPRECIO);
            this.Controls.Add(this.lblCANTIDAD);
            this.Controls.Add(this.lblPRECIOXCUOTA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbCUOTA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAPLICAR);
            this.Name = "frmPAGO";
            this.Text = "Pago";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAPLICAR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCUOTA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPRECIOXCUOTA;
        private System.Windows.Forms.Label lblCANTIDAD;
        private System.Windows.Forms.Label lblPRECIO;
        private System.Windows.Forms.Button btnCONFIRMAR;
        private System.Windows.Forms.TextBox txtFP1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTOTAL;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
    }
}