using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace VISTA
{
    public partial class frmUSUARIO : Form
    {
        string accion;
        bool checkearA;
        MODELO.USUARIO oUSUARIO;
        CONTROLADORA.USUARIOS cUSUARIO;              

        public frmUSUARIO(MODELO.USUARIO MiUsuario, string MiAccion)
        {
            InitializeComponent();
            oUSUARIO = MiUsuario;
            accion = MiAccion;
            
            cUSUARIO = CONTROLADORA.USUARIOS.ObtenerInstancia();
          
            if (accion == "M")
            {
                txtNOMBRE.Text = oUSUARIO.Nombre;
                txtCONTRASEÑA.Visible = false;            
                chEstado.Checked =oUSUARIO.Estado;
                txtUSUARIO.Text = oUSUARIO.Usuario;
                txtMAIL.Text = oUSUARIO.Email;
            }
            
        }
        public MODELO.USUARIO DATOS_ACTUALIZADOS
        {
            get { return oUSUARIO; }
        }

        private void btnGUARDAR_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNOMBRE.Text))
            {
                MessageBox.Show("Debe ingresar un nombre","Ingresar nombre", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtUSUARIO.Text))
            {
                MessageBox.Show("Debe ingresar un usuario", "Ingresar usuario", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }
            if (!cUSUARIO.VALIDAR_USUARIO_EXISTENTE(txtUSUARIO.Text))
            {
                if (!(accion == "M" && oUSUARIO.Usuario == txtUSUARIO.Text))
                {
                    MessageBox.Show("Este usuario ya esta registrado en el sistema", "Ingresar usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
           
            if (string.IsNullOrWhiteSpace(txtCONTRASEÑA.Text)&& accion == "A")
            {
                
                MessageBox.Show("Debe ingresar una contraseña", "Ingresar contraseña", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtMAIL.Text))
            {

                MessageBox.Show("Debe ingresar un mail", "Ingresar mail", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;

            }
            if (!cUSUARIO.ValidarMail(txtMAIL.Text))
            {
                MessageBox.Show("Debe ingresar un mail valido", "Ingresar mail", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (!cUSUARIO.VALIDAR_MAIL_EXISTENTE(txtMAIL.Text))
            {

                if (!(accion == "M" && oUSUARIO.Email == txtMAIL.Text))
                {
                    MessageBox.Show("Este mail ya existe en el sistema", "Ingresar mail", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    return;
                }

            }

            oUSUARIO.Nombre = txtNOMBRE.Text;
            oUSUARIO.Usuario = txtUSUARIO.Text;
            oUSUARIO.Email = txtMAIL.Text;
           
            oUSUARIO.Estado = chEstado.Checked;
            
            if (accion == "A")
            {
                oUSUARIO.Conectado = false;
                oUSUARIO.Contraseña = CONTROLADORA.MODELO_DE_SEGURIDAD.FUNCIONES_BASICAS.EncriptarContraseña(txtCONTRASEÑA.Text);
                cUSUARIO.AGREGAR_USUARIOS(oUSUARIO);
            }
            else
            {
                cUSUARIO.MODIFICAR_USUARIOS(oUSUARIO);
            }
            this.DialogResult = DialogResult.OK;
        }
       
        private void txtMAIL_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtNOMBRE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void frmUSUARIO_Load(object sender, EventArgs e)
        {
            chkGRUPOS.DataSource = null;
            chkGRUPOS.DataSource = cUSUARIO.OBTENER_GRUPOS();
            chkGRUPOS.DisplayMember = "DESCRIPCION";

            checkearA = false;
            for (int i = 0; i < chkGRUPOS.Items.Count; i++)
            {
                MODELO.GRUPO oGrupo = (MODELO.GRUPO)chkGRUPOS.Items[i];
                foreach (MODELO.GRUPO miGrupo in oUSUARIO.GRUPOs)
                {
                    if (miGrupo.cod_grupo == oGrupo.cod_grupo)
                    {
                        chkGRUPOS.SetItemChecked(i, true);
                    }
                }
            }
            checkearA = true;
            this.Show();
            txtNOMBRE.Focus();
        }

        private void chkGRUPOS_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (checkearA == false) return;

            MODELO.GRUPO oGrupo = (MODELO.GRUPO)chkGRUPOS.SelectedItem;
            if (e.NewValue == CheckState.Checked)
            {
                oUSUARIO.GRUPOs.Add(oGrupo);
            }
            else
            {
                oUSUARIO.GRUPOs.Remove(oGrupo);
            }
        }

        private void chkGRUPOS_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (btnGUARDAR.Enabled)
                {
                    btnGUARDAR.Focus();
                }
                else
                {
                    btnCANCELAR.Focus();
                }
            }
        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
