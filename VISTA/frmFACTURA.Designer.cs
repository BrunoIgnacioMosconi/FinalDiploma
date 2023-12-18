namespace VISTA
{
    partial class frmFACTURA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFACTURA));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCLIENTE = new System.Windows.Forms.Label();
            this.lblTIPO = new System.Windows.Forms.Label();
            this.lblFECHA = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPAGO = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblEMPLEADO = new System.Windows.Forms.Label();
            this.btnIMPRIMIR = new System.Windows.Forms.Button();
            this.lblFACTURA = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.lblPRODUCTOO = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTOTAL = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo de factura:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha de emision:";
            // 
            // lblCLIENTE
            // 
            this.lblCLIENTE.AutoSize = true;
            this.lblCLIENTE.Location = new System.Drawing.Point(129, 65);
            this.lblCLIENTE.Name = "lblCLIENTE";
            this.lblCLIENTE.Size = new System.Drawing.Size(0, 13);
            this.lblCLIENTE.TabIndex = 4;
            // 
            // lblTIPO
            // 
            this.lblTIPO.AutoSize = true;
            this.lblTIPO.Location = new System.Drawing.Point(135, 215);
            this.lblTIPO.Name = "lblTIPO";
            this.lblTIPO.Size = new System.Drawing.Size(37, 13);
            this.lblTIPO.TabIndex = 5;
            this.lblTIPO.Text = "----------";
            // 
            // lblFECHA
            // 
            this.lblFECHA.AutoSize = true;
            this.lblFECHA.Location = new System.Drawing.Point(153, 151);
            this.lblFECHA.Name = "lblFECHA";
            this.lblFECHA.Size = new System.Drawing.Size(37, 13);
            this.lblFECHA.TabIndex = 7;
            this.lblFECHA.Text = "----------";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Pago:";
            // 
            // lblPAGO
            // 
            this.lblPAGO.AutoSize = true;
            this.lblPAGO.Location = new System.Drawing.Point(18, 398);
            this.lblPAGO.Name = "lblPAGO";
            this.lblPAGO.Size = new System.Drawing.Size(37, 13);
            this.lblPAGO.TabIndex = 9;
            this.lblPAGO.Text = "----------";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Empleado:";
            // 
            // lblEMPLEADO
            // 
            this.lblEMPLEADO.AutoSize = true;
            this.lblEMPLEADO.Location = new System.Drawing.Point(129, 98);
            this.lblEMPLEADO.Name = "lblEMPLEADO";
            this.lblEMPLEADO.Size = new System.Drawing.Size(0, 13);
            this.lblEMPLEADO.TabIndex = 11;
            // 
            // btnIMPRIMIR
            // 
            this.btnIMPRIMIR.Location = new System.Drawing.Point(25, 494);
            this.btnIMPRIMIR.Name = "btnIMPRIMIR";
            this.btnIMPRIMIR.Size = new System.Drawing.Size(174, 23);
            this.btnIMPRIMIR.TabIndex = 14;
            this.btnIMPRIMIR.Text = "Imprimir";
            this.btnIMPRIMIR.UseVisualStyleBackColor = true;
            this.btnIMPRIMIR.Click += new System.EventHandler(this.btnIMPRIMIR_Click);
            // 
            // lblFACTURA
            // 
            this.lblFACTURA.AutoSize = true;
            this.lblFACTURA.Location = new System.Drawing.Point(153, 182);
            this.lblFACTURA.Name = "lblFACTURA";
            this.lblFACTURA.Size = new System.Drawing.Size(37, 13);
            this.lblFACTURA.TabIndex = 22;
            this.lblFACTURA.Text = "----------";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(22, 182);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 15);
            this.label11.TabIndex = 21;
            this.label11.Text = "Numero de factura:";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // lblPRODUCTOO
            // 
            this.lblPRODUCTOO.AutoSize = true;
            this.lblPRODUCTOO.Location = new System.Drawing.Point(24, 293);
            this.lblPRODUCTOO.Name = "lblPRODUCTOO";
            this.lblPRODUCTOO.Size = new System.Drawing.Size(37, 13);
            this.lblPRODUCTOO.TabIndex = 24;
            this.lblPRODUCTOO.Text = "----------";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 25;
            this.label3.Text = "Producto:";
            // 
            // lblTOTAL
            // 
            this.lblTOTAL.AutoSize = true;
            this.lblTOTAL.Location = new System.Drawing.Point(61, 458);
            this.lblTOTAL.Name = "lblTOTAL";
            this.lblTOTAL.Size = new System.Drawing.Size(37, 13);
            this.lblTOTAL.TabIndex = 26;
            this.lblTOTAL.Text = "----------";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 456);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 15);
            this.label8.TabIndex = 27;
            this.label8.Text = "Total:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 523);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(152, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(223, 22);
            this.label6.TabIndex = 29;
            this.label6.Text = "FACTURACION VENTA";
            // 
            // frmFACTURA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(516, 549);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblTOTAL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPRODUCTOO);
            this.Controls.Add(this.lblFACTURA);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnIMPRIMIR);
            this.Controls.Add(this.lblEMPLEADO);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblPAGO);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblFECHA);
            this.Controls.Add(this.lblTIPO);
            this.Controls.Add(this.lblCLIENTE);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFACTURA";
            this.Text = "Generar factura ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCLIENTE;
        private System.Windows.Forms.Label lblTIPO;
        private System.Windows.Forms.Label lblFECHA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPAGO;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblEMPLEADO;
        private System.Windows.Forms.Button btnIMPRIMIR;
        private System.Windows.Forms.Label lblFACTURA;
        private System.Windows.Forms.Label label11;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label lblPRODUCTOO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTOTAL;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
    }
}