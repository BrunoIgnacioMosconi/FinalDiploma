using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using MODELO;

namespace VISTA
{
    public partial class frmMENU_PRINCIPAL : Form
    {
        MODELO.USUARIO oUSUARIO_ACTUAL;
        CONTROLADORA.MODELO_DE_SEGURIDAD.LOGIN cINGRESO;
        CONTROLADORA.FachadaBACKUP cBACKUP;
        CONTROLADORA.USUARIOS cUSUARIO;
        
        private Form miFORM;
        public frmMENU_PRINCIPAL()
        {
            InitializeComponent();
            
            cINGRESO =  CONTROLADORA.MODELO_DE_SEGURIDAD.LOGIN.ObtenerInstancia();
            cUSUARIO = CONTROLADORA.USUARIOS.ObtenerInstancia();
            cBACKUP = CONTROLADORA.FachadaBACKUP.ObtenerInstancia();
            cINGRESO.VERIFICA_PERMISOS_ADMINISTRADOR();


        }
        private void frmMENU_PRINCIPAL_Load(object sender, EventArgs e)
        {
            
            ARMA_LOGIN();
            this.Show();
            tvMENU.Focus();

        }
        private void ARMA_LOGIN()
        {
            frmLOGIN formLOGIN = new frmLOGIN();
            DialogResult drLOGIN = formLOGIN.ShowDialog();
            
            if (drLOGIN == System.Windows.Forms.DialogResult.Cancel)
            {
                Application.Exit();
                return;
            }
            else {
                oUSUARIO_ACTUAL = formLOGIN.USUARIO_ACTUAL;
                oUSUARIO_ACTUAL.Conectado = true;
                cUSUARIO.MODIFICAR_USUARIOS(oUSUARIO_ACTUAL);
                lblNOMBRE.Text = oUSUARIO_ACTUAL.Nombre;
                lblCUENTA.Text = oUSUARIO_ACTUAL.Usuario;
                lblEMAIL.Text = oUSUARIO_ACTUAL.Email;                                              
                ARMA_MODULOS();
                btnCAMBIAR.Enabled = oUSUARIO_ACTUAL.VALIDAR_ACCION("frmCAMBIAR_CLAVE", "btnCAMBIAR");
                tvMENU.Focus();
                this.Show();
            }
            formLOGIN.Dispose();

        }
        private void ARMA_MODULOS()
        {
            tvMENU.Nodes.Clear();
          
            var modulos = (from accion in cINGRESO.ObtenerAccionesDelUsuario(oUSUARIO_ACTUAL)
                           where accion.MODULO != "Menu"
                           select new { DESCRIPCION = accion.MODULO })
                          .Distinct();

            foreach (var MODULO in modulos)
            {
                TreeNode tnM = new TreeNode();
                tnM.Text = MODULO.DESCRIPCION;
                tnM.Tag = "X";
                tvMENU.Nodes.Add(tnM);

                var formularios = (from formulario in cINGRESO.ObtenerAccionesDelUsuario(oUSUARIO_ACTUAL)
                                   where formulario.MODULO == MODULO.DESCRIPCION
                                   select new { FORMULARIO = formulario.FORMULARIO, DESCRIPCION = formulario.FORMULARIO_DESCRIPCION }
                                   ).Distinct();
                foreach (var formulario in formularios)
                {
                    TreeNode tnF = new TreeNode(formulario.DESCRIPCION);
                    tnF.Tag = formulario.FORMULARIO;
                    tnM.Nodes.Add(tnF);

                }

            }

            tvMENU.NodeMouseDoubleClick += new TreeNodeMouseClickEventHandler(this.ITEM_CLICK);
        }
        private void ITEM_CLICK(object sender, TreeNodeMouseClickEventArgs e)
        {
           
            TreeNode seleccion = e.Node;
          
            if ((string)seleccion.Tag != "X")
            {
               
                foreach (System.Type type in Assembly.GetExecutingAssembly().GetTypes())
                {
                   
                    if (type.IsSubclassOf(typeof(Form)))
                    {
                       
                        if (type.Name.ToString() == (string)seleccion.Tag)
                        {
                         
                            try
                            {
                                
                                Type t = type as Type;
                               
                                miFORM = (Form)t.InvokeMember("obtener_instancia", BindingFlags.Default | BindingFlags.Static | BindingFlags.Public | BindingFlags.InvokeMethod | BindingFlags.InvokeMethod, null, null, new object[] { this.oUSUARIO_ACTUAL }) as System.Windows.Forms.Form;
                              
                                miFORM.Show();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                    }
                }
            }
        }

        private void tvMENU_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            ITEM_CLICK(sender, e);
        }
        public void CERRAR_SESION()
        {
            if (oUSUARIO_ACTUAL != null)
            {
                MODELO.LOGIN oLOGIN = new MODELO.LOGIN();
                oLOGIN = cINGRESO.OBTENER_LOGIN(oUSUARIO_ACTUAL);
                if(oLOGIN.Cod_Login > 0)
                {
                    oLOGIN.Fecha_logout = System.DateTime.Now;
                    cINGRESO.MODIFICAR_LOGIN(oLOGIN);
                    if (cINGRESO.CANTIDAD_USUARIOS_CONECTADOS() == 1)
                    {
                        cBACKUP.GENERAR_COPIA();
                    }
                    oUSUARIO_ACTUAL.Conectado = false;
                    cUSUARIO.MODIFICAR_USUARIOS(oUSUARIO_ACTUAL);
                }

            }

        }
        private void btnCERRAR_SESION_Click_1(object sender, EventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name != "frmMENU_PRINCIPAL" && Application.OpenForms[i].Name != "frmLOGIN")
                {
                    Application.OpenForms[i].Close();
                   
                }

            }

            tvMENU.NodeMouseDoubleClick -= new TreeNodeMouseClickEventHandler(this.tvMENU_NodeMouseDoubleClick);
            CERRAR_SESION();
            this.Hide();

            ARMA_LOGIN();
            
        }
        private void CAMBIAR_CLAVE()
        {            
            
            MODELO_DE_SEGURIDAD.frmCAMBIAR_CLAVE formCAMBIAR_CLAVE = MODELO_DE_SEGURIDAD.frmCAMBIAR_CLAVE.obtener_instancia(oUSUARIO_ACTUAL);
            DialogResult dr = formCAMBIAR_CLAVE.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                MessageBox.Show("La contraseña ha sido cambiada exitosamente, la misma será válida a partir del próximo inicio de sesión", "Cambio de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            CAMBIAR_CLAVE();
        }
        private void ITEM_KEY(TreeNode seleccion)
        {
            
            if ((string)seleccion.Tag != "X")
            {
                foreach (System.Type type in Assembly.GetExecutingAssembly().GetTypes())
                {
                    
                    if (type.IsSubclassOf(typeof(Form)))
                    {
                       
                        if (type.Name.ToString() == (string)seleccion.Tag)
                        {
                            try
                            {                                
                                Type t = type as Type;
                               
                                miFORM = (Form)t.InvokeMember("obtener_instancia", BindingFlags.Default | BindingFlags.Static | BindingFlags.Public | BindingFlags.InvokeMethod | BindingFlags.InvokeMethod, null, null, new object[] { this.oUSUARIO_ACTUAL }) as System.Windows.Forms.Form;
                               
                                miFORM.Show(this);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                    }
                }
            }
        }
        private void tvMENU_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TreeNode tn = tvMENU.SelectedNode;
                if (tn != null)
                {
                    if (tn.GetNodeCount(true) == 0)
                    {
                        ITEM_KEY(tn);
                    }
                    else
                    {
                        if (tn.IsExpanded)
                        {
                            tn.Collapse(false);
                        }
                        else
                        {
                            tn.Expand();
                        }
                    }
                }
            }
        }

        private void frmMENU_PRINCIPAL_FormClosed(object sender, FormClosedEventArgs e)
        {
            CERRAR_SESION();
        }
    }
}
