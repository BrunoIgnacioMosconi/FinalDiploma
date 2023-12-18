namespace VISTA
{
    partial class frmCLIENTES
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCLIENTES));
            this.dgvCLIENTE = new System.Windows.Forms.DataGridView();
            this.txtBUSCAR_CLIENTE = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCANCELAR = new System.Windows.Forms.Button();
            this.btnMODIFICACIONES = new System.Windows.Forms.Button();
            this.btnELIMINAR = new System.Windows.Forms.Button();
            this.btnAGREGAR = new System.Windows.Forms.Button();
            this.btnBUSCAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCLIENTE)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCLIENTE
            // 
            this.dgvCLIENTE.BackgroundColor = System.Drawing.Color.White;
            this.dgvCLIENTE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCLIENTE.Location = new System.Drawing.Point(131, 61);
            this.dgvCLIENTE.Name = "dgvCLIENTE";
            this.dgvCLIENTE.Size = new System.Drawing.Size(855, 384);
            this.dgvCLIENTE.TabIndex = 0;
            this.dgvCLIENTE.DoubleClick += new System.EventHandler(this.dgvCLIENTE_DoubleClick);
            // 
            // txtBUSCAR_CLIENTE
            // 
            this.txtBUSCAR_CLIENTE.Location = new System.Drawing.Point(747, 31);
            this.txtBUSCAR_CLIENTE.Name = "txtBUSCAR_CLIENTE";
            this.txtBUSCAR_CLIENTE.Size = new System.Drawing.Size(100, 20);
            this.txtBUSCAR_CLIENTE.TabIndex = 5;
            this.txtBUSCAR_CLIENTE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBUSCAR_CLIENTE_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(686, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Buscar";
            // 
            // btnCANCELAR
            // 
            this.btnCANCELAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCANCELAR.Image = ((System.Drawing.Image)(resources.GetObject("btnCANCELAR.Image")));
            this.btnCANCELAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCANCELAR.Location = new System.Drawing.Point(878, 473);
            this.btnCANCELAR.Name = "btnCANCELAR";
            this.btnCANCELAR.Size = new System.Drawing.Size(94, 60);
            this.btnCANCELAR.TabIndex = 101;
            this.btnCANCELAR.Text = "&Cerrar";
            this.btnCANCELAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCANCELAR.UseVisualStyleBackColor = true;
            this.btnCANCELAR.Click += new System.EventHandler(this.btnCANCELAR_Click);
            // 
            // btnMODIFICACIONES
            // 
            this.btnMODIFICACIONES.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMODIFICACIONES.Image = ((System.Drawing.Image)(resources.GetObject("btnMODIFICACIONES.Image")));
            this.btnMODIFICACIONES.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMODIFICACIONES.Location = new System.Drawing.Point(20, 224);
            this.btnMODIFICACIONES.Name = "btnMODIFICACIONES";
            this.btnMODIFICACIONES.Size = new System.Drawing.Size(91, 60);
            this.btnMODIFICACIONES.TabIndex = 100;
            this.btnMODIFICACIONES.Text = "&Modificar";
            this.btnMODIFICACIONES.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMODIFICACIONES.UseVisualStyleBackColor = true;
            this.btnMODIFICACIONES.Click += new System.EventHandler(this.btnMODIFICACIONES_Click);
            // 
            // btnELIMINAR
            // 
            this.btnELIMINAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnELIMINAR.Image = ((System.Drawing.Image)(resources.GetObject("btnELIMINAR.Image")));
            this.btnELIMINAR.Location = new System.Drawing.Point(18, 385);
            this.btnELIMINAR.Name = "btnELIMINAR";
            this.btnELIMINAR.Size = new System.Drawing.Size(91, 60);
            this.btnELIMINAR.TabIndex = 99;
            this.btnELIMINAR.Text = "&Eliminar";
            this.btnELIMINAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnELIMINAR.UseVisualStyleBackColor = true;
            this.btnELIMINAR.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAGREGAR
            // 
            this.btnAGREGAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAGREGAR.Image = ((System.Drawing.Image)(resources.GetObject("btnAGREGAR.Image")));
            this.btnAGREGAR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAGREGAR.Location = new System.Drawing.Point(18, 61);
            this.btnAGREGAR.Name = "btnAGREGAR";
            this.btnAGREGAR.Size = new System.Drawing.Size(93, 60);
            this.btnAGREGAR.TabIndex = 98;
            this.btnAGREGAR.Text = "&Agregar";
            this.btnAGREGAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAGREGAR.UseVisualStyleBackColor = true;
            this.btnAGREGAR.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnBUSCAR
            // 
            this.btnBUSCAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBUSCAR.Image = ((System.Drawing.Image)(resources.GetObject("btnBUSCAR.Image")));
            this.btnBUSCAR.Location = new System.Drawing.Point(878, 13);
            this.btnBUSCAR.Name = "btnBUSCAR";
            this.btnBUSCAR.Size = new System.Drawing.Size(64, 38);
            this.btnBUSCAR.TabIndex = 102;
            this.btnBUSCAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBUSCAR.UseVisualStyleBackColor = true;
            this.btnBUSCAR.Click += new System.EventHandler(this.btnBUSCAR_Click_1);
            // 
            // frmCLIENTES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(998, 545);
            this.Controls.Add(this.btnBUSCAR);
            this.Controls.Add(this.btnCANCELAR);
            this.Controls.Add(this.btnMODIFICACIONES);
            this.Controls.Add(this.btnELIMINAR);
            this.Controls.Add(this.btnAGREGAR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBUSCAR_CLIENTE);
            this.Controls.Add(this.dgvCLIENTE);
            this.Name = "frmCLIENTES";
            this.Text = "Gestionar cliente";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCLIENTE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCLIENTE;
        private System.Windows.Forms.TextBox txtBUSCAR_CLIENTE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCANCELAR;
        private System.Windows.Forms.Button btnMODIFICACIONES;
        private System.Windows.Forms.Button btnELIMINAR;
        private System.Windows.Forms.Button btnAGREGAR;
        private System.Windows.Forms.Button btnBUSCAR;
    }
}