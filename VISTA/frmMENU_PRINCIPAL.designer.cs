namespace VISTA
{
    partial class frmMENU_PRINCIPAL
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMENU_PRINCIPAL));
            this.dfdf = new System.Windows.Forms.Label();
            this.tvMENU = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCERRAR_SESION = new System.Windows.Forms.Button();
            this.btnCAMBIAR = new System.Windows.Forms.Button();
            this.lblEMAIL = new System.Windows.Forms.Label();
            this.lblCUENTA = new System.Windows.Forms.Label();
            this.lblNOMBRE = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dfdf
            // 
            this.dfdf.AutoSize = true;
            this.dfdf.Font = new System.Drawing.Font("Constantia", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dfdf.Location = new System.Drawing.Point(1128, 327);
            this.dfdf.Name = "dfdf";
            this.dfdf.Size = new System.Drawing.Size(100, 15);
            this.dfdf.TabIndex = 4;
            this.dfdf.Text = "Bruno Mosconi";
            // 
            // tvMENU
            // 
            this.tvMENU.Location = new System.Drawing.Point(12, 25);
            this.tvMENU.Name = "tvMENU";
            this.tvMENU.Size = new System.Drawing.Size(778, 313);
            this.tvMENU.TabIndex = 6;
            this.tvMENU.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvMENU_NodeMouseDoubleClick);
            this.tvMENU.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tvMENU_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Menu";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnCERRAR_SESION);
            this.groupBox2.Controls.Add(this.btnCAMBIAR);
            this.groupBox2.Controls.Add(this.lblEMAIL);
            this.groupBox2.Controls.Add(this.lblCUENTA);
            this.groupBox2.Controls.Add(this.lblNOMBRE);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(890, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(442, 256);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mis Datos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cuenta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nombre:";
            // 
            // btnCERRAR_SESION
            // 
            this.btnCERRAR_SESION.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCERRAR_SESION.Image = ((System.Drawing.Image)(resources.GetObject("btnCERRAR_SESION.Image")));
            this.btnCERRAR_SESION.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCERRAR_SESION.Location = new System.Drawing.Point(103, 162);
            this.btnCERRAR_SESION.Name = "btnCERRAR_SESION";
            this.btnCERRAR_SESION.Size = new System.Drawing.Size(87, 54);
            this.btnCERRAR_SESION.TabIndex = 6;
            this.btnCERRAR_SESION.Text = "&Cerrar Sesion";
            this.btnCERRAR_SESION.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCERRAR_SESION.UseVisualStyleBackColor = true;
            this.btnCERRAR_SESION.Click += new System.EventHandler(this.btnCERRAR_SESION_Click_1);
            // 
            // btnCAMBIAR
            // 
            this.btnCAMBIAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCAMBIAR.Image = ((System.Drawing.Image)(resources.GetObject("btnCAMBIAR.Image")));
            this.btnCAMBIAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCAMBIAR.Location = new System.Drawing.Point(3, 162);
            this.btnCAMBIAR.Name = "btnCAMBIAR";
            this.btnCAMBIAR.Size = new System.Drawing.Size(94, 54);
            this.btnCAMBIAR.TabIndex = 5;
            this.btnCAMBIAR.Text = "Cambiar Clave";
            this.btnCAMBIAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCAMBIAR.UseVisualStyleBackColor = true;
            this.btnCAMBIAR.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblEMAIL
            // 
            this.lblEMAIL.AutoSize = true;
            this.lblEMAIL.Location = new System.Drawing.Point(50, 85);
            this.lblEMAIL.Name = "lblEMAIL";
            this.lblEMAIL.Size = new System.Drawing.Size(16, 13);
            this.lblEMAIL.TabIndex = 3;
            this.lblEMAIL.Text = "---";
            // 
            // lblCUENTA
            // 
            this.lblCUENTA.AutoSize = true;
            this.lblCUENTA.Location = new System.Drawing.Point(66, 52);
            this.lblCUENTA.Name = "lblCUENTA";
            this.lblCUENTA.Size = new System.Drawing.Size(16, 13);
            this.lblCUENTA.TabIndex = 2;
            this.lblCUENTA.Text = "---";
            // 
            // lblNOMBRE
            // 
            this.lblNOMBRE.AutoSize = true;
            this.lblNOMBRE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNOMBRE.Location = new System.Drawing.Point(66, 25);
            this.lblNOMBRE.Name = "lblNOMBRE";
            this.lblNOMBRE.Size = new System.Drawing.Size(19, 13);
            this.lblNOMBRE.TabIndex = 1;
            this.lblNOMBRE.Text = "---";
            // 
            // frmMENU_PRINCIPAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1350, 351);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tvMENU);
            this.Controls.Add(this.dfdf);
            this.Name = "frmMENU_PRINCIPAL";
            this.Text = "Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMENU_PRINCIPAL_FormClosed);
            this.Load += new System.EventHandler(this.frmMENU_PRINCIPAL_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label dfdf;
        private System.Windows.Forms.TreeView tvMENU;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCERRAR_SESION;
        private System.Windows.Forms.Button btnCAMBIAR;
        private System.Windows.Forms.Label lblEMAIL;
        private System.Windows.Forms.Label lblCUENTA;
        private System.Windows.Forms.Label lblNOMBRE;
    }
}

