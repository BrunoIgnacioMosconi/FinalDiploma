namespace VISTA
{
    partial class frmPRODUCTO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPRODUCTO));
            this.Descripcion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbPROVEEDOR = new System.Windows.Forms.ComboBox();
            this.txtTIPODEPRODUCTO = new System.Windows.Forms.TextBox();
            this.txtPRECIOUNITARIO = new System.Windows.Forms.TextBox();
            this.rdXS = new System.Windows.Forms.RadioButton();
            this.rdS = new System.Windows.Forms.RadioButton();
            this.rdl = new System.Windows.Forms.RadioButton();
            this.rdXL = new System.Windows.Forms.RadioButton();
            this.rdM = new System.Windows.Forms.RadioButton();
            this.rdXXL = new System.Windows.Forms.RadioButton();
            this.cmbCOLOR = new System.Windows.Forms.ComboBox();
            this.lblCODIGO = new System.Windows.Forms.Label();
            this.txtCODBARRA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMARCA = new System.Windows.Forms.ComboBox();
            this.txtDESCRIPCION = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCANCELAR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSize = true;
            this.Descripcion.Location = new System.Drawing.Point(36, 100);
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Size = new System.Drawing.Size(63, 13);
            this.Descripcion.TabIndex = 0;
            this.Descripcion.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 405);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo de producto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Color";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Precio unitario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Talle";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Proveedor";
            // 
            // cmbPROVEEDOR
            // 
            this.cmbPROVEEDOR.FormattingEnabled = true;
            this.cmbPROVEEDOR.Location = new System.Drawing.Point(138, 40);
            this.cmbPROVEEDOR.Name = "cmbPROVEEDOR";
            this.cmbPROVEEDOR.Size = new System.Drawing.Size(248, 21);
            this.cmbPROVEEDOR.TabIndex = 7;
            // 
            // txtTIPODEPRODUCTO
            // 
            this.txtTIPODEPRODUCTO.Location = new System.Drawing.Point(138, 405);
            this.txtTIPODEPRODUCTO.Name = "txtTIPODEPRODUCTO";
            this.txtTIPODEPRODUCTO.Size = new System.Drawing.Size(248, 20);
            this.txtTIPODEPRODUCTO.TabIndex = 9;
            // 
            // txtPRECIOUNITARIO
            // 
            this.txtPRECIOUNITARIO.Location = new System.Drawing.Point(138, 307);
            this.txtPRECIOUNITARIO.Name = "txtPRECIOUNITARIO";
            this.txtPRECIOUNITARIO.Size = new System.Drawing.Size(248, 20);
            this.txtPRECIOUNITARIO.TabIndex = 11;
            this.txtPRECIOUNITARIO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPRECIOUNITARIO_KeyPress);
            // 
            // rdXS
            // 
            this.rdXS.AutoSize = true;
            this.rdXS.Location = new System.Drawing.Point(121, 211);
            this.rdXS.Name = "rdXS";
            this.rdXS.Size = new System.Drawing.Size(39, 17);
            this.rdXS.TabIndex = 12;
            this.rdXS.TabStop = true;
            this.rdXS.Text = "XS";
            this.rdXS.UseVisualStyleBackColor = true;
            // 
            // rdS
            // 
            this.rdS.AutoSize = true;
            this.rdS.Location = new System.Drawing.Point(221, 211);
            this.rdS.Name = "rdS";
            this.rdS.Size = new System.Drawing.Size(32, 17);
            this.rdS.TabIndex = 13;
            this.rdS.TabStop = true;
            this.rdS.Text = "S";
            this.rdS.UseVisualStyleBackColor = true;
            // 
            // rdl
            // 
            this.rdl.AutoSize = true;
            this.rdl.Location = new System.Drawing.Point(121, 234);
            this.rdl.Name = "rdl";
            this.rdl.Size = new System.Drawing.Size(31, 17);
            this.rdl.TabIndex = 14;
            this.rdl.TabStop = true;
            this.rdl.Text = "L";
            this.rdl.UseVisualStyleBackColor = true;
            // 
            // rdXL
            // 
            this.rdXL.AutoSize = true;
            this.rdXL.Location = new System.Drawing.Point(221, 234);
            this.rdXL.Name = "rdXL";
            this.rdXL.Size = new System.Drawing.Size(38, 17);
            this.rdXL.TabIndex = 15;
            this.rdXL.TabStop = true;
            this.rdXL.Text = "XL";
            this.rdXL.UseVisualStyleBackColor = true;
            // 
            // rdM
            // 
            this.rdM.AutoSize = true;
            this.rdM.Location = new System.Drawing.Point(121, 256);
            this.rdM.Name = "rdM";
            this.rdM.Size = new System.Drawing.Size(34, 17);
            this.rdM.TabIndex = 16;
            this.rdM.TabStop = true;
            this.rdM.Text = "M";
            this.rdM.UseVisualStyleBackColor = true;
            // 
            // rdXXL
            // 
            this.rdXXL.AutoSize = true;
            this.rdXXL.Location = new System.Drawing.Point(221, 257);
            this.rdXXL.Name = "rdXXL";
            this.rdXXL.Size = new System.Drawing.Size(45, 17);
            this.rdXXL.TabIndex = 17;
            this.rdXXL.TabStop = true;
            this.rdXXL.Text = "XXL";
            this.rdXXL.UseVisualStyleBackColor = true;
            // 
            // cmbCOLOR
            // 
            this.cmbCOLOR.FormattingEnabled = true;
            this.cmbCOLOR.Location = new System.Drawing.Point(138, 356);
            this.cmbCOLOR.Name = "cmbCOLOR";
            this.cmbCOLOR.Size = new System.Drawing.Size(248, 21);
            this.cmbCOLOR.TabIndex = 20;
            // 
            // lblCODIGO
            // 
            this.lblCODIGO.AutoSize = true;
            this.lblCODIGO.Location = new System.Drawing.Point(37, 463);
            this.lblCODIGO.Name = "lblCODIGO";
            this.lblCODIGO.Size = new System.Drawing.Size(40, 13);
            this.lblCODIGO.TabIndex = 21;
            this.lblCODIGO.Text = "Codigo";
            // 
            // txtCODBARRA
            // 
            this.txtCODBARRA.Location = new System.Drawing.Point(138, 456);
            this.txtCODBARRA.Name = "txtCODBARRA";
            this.txtCODBARRA.Size = new System.Drawing.Size(248, 20);
            this.txtCODBARRA.TabIndex = 22;
            this.txtCODBARRA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCODBARRA_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Marca";
            // 
            // cmbMARCA
            // 
            this.cmbMARCA.FormattingEnabled = true;
            this.cmbMARCA.Location = new System.Drawing.Point(138, 152);
            this.cmbMARCA.Name = "cmbMARCA";
            this.cmbMARCA.Size = new System.Drawing.Size(248, 21);
            this.cmbMARCA.TabIndex = 25;
            // 
            // txtDESCRIPCION
            // 
            this.txtDESCRIPCION.Location = new System.Drawing.Point(138, 97);
            this.txtDESCRIPCION.Name = "txtDESCRIPCION";
            this.txtDESCRIPCION.Size = new System.Drawing.Size(248, 20);
            this.txtDESCRIPCION.TabIndex = 8;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardar.Location = new System.Drawing.Point(23, 517);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(107, 62);
            this.btnGuardar.TabIndex = 26;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // btnCANCELAR
            // 
            this.btnCANCELAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCANCELAR.Image = ((System.Drawing.Image)(resources.GetObject("btnCANCELAR.Image")));
            this.btnCANCELAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCANCELAR.Location = new System.Drawing.Point(273, 517);
            this.btnCANCELAR.Name = "btnCANCELAR";
            this.btnCANCELAR.Size = new System.Drawing.Size(101, 62);
            this.btnCANCELAR.TabIndex = 27;
            this.btnCANCELAR.Text = "Cancelar";
            this.btnCANCELAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCANCELAR.UseVisualStyleBackColor = true;
            this.btnCANCELAR.Click += new System.EventHandler(this.btnCANCELAR_Click);
            // 
            // frmPRODUCTO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(518, 591);
            this.Controls.Add(this.btnCANCELAR);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cmbMARCA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCODBARRA);
            this.Controls.Add(this.lblCODIGO);
            this.Controls.Add(this.cmbCOLOR);
            this.Controls.Add(this.rdXXL);
            this.Controls.Add(this.rdM);
            this.Controls.Add(this.rdXL);
            this.Controls.Add(this.rdl);
            this.Controls.Add(this.rdS);
            this.Controls.Add(this.rdXS);
            this.Controls.Add(this.txtPRECIOUNITARIO);
            this.Controls.Add(this.txtTIPODEPRODUCTO);
            this.Controls.Add(this.txtDESCRIPCION);
            this.Controls.Add(this.cmbPROVEEDOR);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Descripcion);
            this.Name = "frmPRODUCTO";
            this.Text = "Producto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Descripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbPROVEEDOR;
        private System.Windows.Forms.TextBox txtTIPODEPRODUCTO;
        private System.Windows.Forms.TextBox txtPRECIOUNITARIO;
        private System.Windows.Forms.RadioButton rdXS;
        private System.Windows.Forms.RadioButton rdS;
        private System.Windows.Forms.RadioButton rdl;
        private System.Windows.Forms.RadioButton rdXL;
        private System.Windows.Forms.RadioButton rdM;
        private System.Windows.Forms.RadioButton rdXXL;
        private System.Windows.Forms.ComboBox cmbCOLOR;
        private System.Windows.Forms.Label lblCODIGO;
        private System.Windows.Forms.TextBox txtCODBARRA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMARCA;
        private System.Windows.Forms.TextBox txtDESCRIPCION;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCANCELAR;
    }
}