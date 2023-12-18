using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VISTA
{
    public partial class frmGRUPO : Form
    {
        string accion;
        MODELO.GRUPO oGRUPO;
        bool chekearU;
        bool chekearN;
        CONTROLADORA.GRUPOS cGRUPOS;
       
        public frmGRUPO(MODELO.GRUPO MiGrupo, string MiAccion)
        {
            InitializeComponent();
            oGRUPO = MiGrupo;
            accion = MiAccion;
            cGRUPOS = CONTROLADORA.GRUPOS.ObtenerInstancia();
           
            txtCODIGO.Enabled = false;

          
            if (accion == "M")
            {
                txtCODIGO.Text = oGRUPO.cod_grupo.ToString();
                txtDESCRIPCION.Text = oGRUPO.NOMBRE;
            }
          
           
            
           
        }
        private void frmGRUPO_Load(object sender, EventArgs e)
        {
            USUARIOS.DataSource = null;
            USUARIOS.DataSource = cGRUPOS.ObtenerUsuarios();
            USUARIOS.DisplayMember = "NOMBRE";
            chekearU = false;
            for (int i = 0; i < USUARIOS.Items.Count; i++)
            {
                MODELO.USUARIO oUsuario = (MODELO.USUARIO)USUARIOS.Items[i];
                foreach (MODELO.USUARIO miUsuario in oGRUPO.USUARIOS.ToList())
                {
                    if (miUsuario.cod_usuario == oUsuario.cod_usuario)
                    {
                        USUARIOS.SetItemChecked(i, true);
                    }
                }
            }
            chekearU = true;

            chekearN = false;
            List<MODELO.MODELO_DE_SEGURIDAD.ESTRUCTURA.formulario> FORMULARIOS = CONTROLADORA.ACCIONES.OBTENER_ACCIONES();

            var modulos = (from formulario in FORMULARIOS
                           where formulario.SEGURIDAD
                           select new { DESCRIPCION = formulario.MODULO })
                          .Distinct();

            foreach (var MODULO in modulos)
            {
                TreeNode tnM = new TreeNode();
                tnM.Text = MODULO.DESCRIPCION;
                tnM.Tag = null;
                var formularios = from formulario in FORMULARIOS
                                  where formulario.MODULO == MODULO.DESCRIPCION
                                  select formulario;

                foreach (MODELO.MODELO_DE_SEGURIDAD.ESTRUCTURA.formulario oFORM in formularios)
                {
                    if (oFORM.ACCIONES.Count() > 0)
                    {
                        TreeNode tnf = new TreeNode();
                        tnf.Text = oFORM.DESCRIPCION;
                        tnf.Tag = null;
                        tnM.Nodes.Add(tnf);
                        foreach (MODELO.MODELO_DE_SEGURIDAD.ESTRUCTURA.accion oACCION in oFORM.ACCIONES)
                        {
                            TreeNode tnA = new TreeNode();
                            tnA.Text = oACCION.DESCRIPCION;
                            tnA.Tag = oACCION;
                            if (oGRUPO.ACCIONES.Count(acc => (acc.MODULO == oACCION.MODULO) && (acc.FORMULARIO == oACCION.FORMULARIO) && (acc.CONTROL == oACCION.CONTROL)) > 0)
                                tnA.Checked = true;
                            else
                                tnA.Checked = false;

                            tnf.Nodes.Add(tnA);
                            HasCheckedChildNodes(tnf);
                        }
                    }
                }
                tvACCIONES.Nodes.Add(tnM);


            }
            chekearN = true;

            this.Show();
            txtDESCRIPCION.Focus();
        }

   
     
        

        private void btnGUARDAR_Click(object sender, EventArgs e)
        {
            oGRUPO.NOMBRE = txtDESCRIPCION.Text;
            
            if (accion == "A")
            {
                cGRUPOS.AGREGAR_GRUPOS(oGRUPO);
            }
            else
            {
                cGRUPOS.MODIFICAR_GRUPOS(oGRUPO);
            }
            this.DialogResult = DialogResult.OK;
        }

        private void txtGRUPO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void USUARIOS_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (chekearU == false) return;
            MODELO.USUARIO oUSUARIO = (MODELO.USUARIO)USUARIOS.SelectedItem;
            if (e.NewValue == CheckState.Checked)
            {
                oGRUPO.USUARIOS.Add(oUSUARIO);
            }
            else
            {
                oGRUPO.USUARIOS.Remove(oUSUARIO);
            }
        }

       
        private void checkChildNodes(TreeNode node, bool nodeChecked)
        {
            chekearN = false;
            foreach (TreeNode tnS in node.Nodes)
            {
                if (tnS.Nodes.Count > 0)
                {
                    tnS.Checked = nodeChecked;
                    checkChildNodes(tnS, nodeChecked);
                }
                else
                {
                    if (tnS.Tag != null)
                    {
                        MODELO.ACCION miACCION;
                        tnS.Checked = nodeChecked;
                        if (tnS.Checked)
                        {
                            miACCION = new MODELO.ACCION();
                            miACCION.CONTROL = ((MODELO.MODELO_DE_SEGURIDAD.ESTRUCTURA.accion)tnS.Tag).CONTROL;
                            miACCION.DESCIPCION_ACCION = ((MODELO.MODELO_DE_SEGURIDAD.ESTRUCTURA.accion)tnS.Tag).DESCRIPCION;
                            miACCION.FORMULARIO = ((MODELO.MODELO_DE_SEGURIDAD.ESTRUCTURA.accion)tnS.Tag).FORMULARIO;
                            miACCION.FORMULARIO_DESCRIPCION = ((MODELO.MODELO_DE_SEGURIDAD.ESTRUCTURA.accion)tnS.Tag).FORMULARIO_DESCRIPCION;
                            miACCION.MODULO = ((MODELO.MODELO_DE_SEGURIDAD.ESTRUCTURA.accion)tnS.Tag).MODULO;
                            oGRUPO.ACCIONES.Add(miACCION);
                        }
                        else
                        {
                            miACCION = oGRUPO.ACCIONES.FirstOrDefault(acc => (acc.CONTROL == ((MODELO.MODELO_DE_SEGURIDAD.ESTRUCTURA.accion)tnS.Tag).CONTROL) && (acc.FORMULARIO == ((MODELO.MODELO_DE_SEGURIDAD.ESTRUCTURA.accion)tnS.Tag).FORMULARIO));
                            oGRUPO.ACCIONES.Remove(miACCION);
                        }
                    }
                }
            }
            chekearN = true;
        }



        private void HasCheckedChildNodes(TreeNode node)
        {
            chekearN = false;
            bool marca = true;
            if (node.Nodes.Count > 0)
            {
                foreach (TreeNode childNode in node.Nodes)
                {
                    if (!childNode.Checked)
                        marca = false;
                }
                node.Checked = marca;
                if (node.Parent != null)
                    HasCheckedChildNodes(node.Parent);
            }
            chekearN = true;
        }

   

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void USUARIOS_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tabDATOS.SelectedTab = tabPage2;
                tvACCIONES.Focus();
            }
        }

        

        private void tvACCIONES_AfterCheck_1(object sender, TreeViewEventArgs e)
        {
            if (chekearN == false)
                return;

            TreeNode seleccion = e.Node;

            if (seleccion.Nodes.Count > 0)
            {
                checkChildNodes(seleccion, seleccion.Checked);
            }
            else
            {
                if (seleccion.Tag != null)
                {
                    MODELO.ACCION miACCION;
                    if (seleccion.Checked)
                    {
                        miACCION = new MODELO.ACCION();
                        miACCION.CONTROL = ((MODELO.MODELO_DE_SEGURIDAD.ESTRUCTURA.accion)seleccion.Tag).CONTROL;
                        miACCION.DESCIPCION_ACCION = ((MODELO.MODELO_DE_SEGURIDAD.ESTRUCTURA.accion)seleccion.Tag).DESCRIPCION;
                        miACCION.FORMULARIO = ((MODELO.MODELO_DE_SEGURIDAD.ESTRUCTURA.accion)seleccion.Tag).FORMULARIO;
                        miACCION.FORMULARIO_DESCRIPCION = ((MODELO.MODELO_DE_SEGURIDAD.ESTRUCTURA.accion)seleccion.Tag).FORMULARIO_DESCRIPCION;
                        miACCION.MODULO = ((MODELO.MODELO_DE_SEGURIDAD.ESTRUCTURA.accion)seleccion.Tag).MODULO;
                        oGRUPO.ACCIONES.Add(miACCION);
                    }
                    else
                    {
                        miACCION = oGRUPO.ACCIONES.FirstOrDefault(acc => (acc.CONTROL == ((MODELO.MODELO_DE_SEGURIDAD.ESTRUCTURA.accion)seleccion.Tag).CONTROL) && (acc.FORMULARIO == ((MODELO.MODELO_DE_SEGURIDAD.ESTRUCTURA.accion)seleccion.Tag).FORMULARIO));
                        oGRUPO.ACCIONES.Remove(miACCION);
                    }
                }
            }
            chekearN = false;
            if (seleccion.Parent != null)
            {
                HasCheckedChildNodes(seleccion.Parent);
            }
            chekearN = true;
        }

        private void tvACCIONES_BeforeCheck_1(object sender, TreeViewCancelEventArgs e)
        {
            if (accion == "C") e.Cancel = true;
        }

        private void tvACCIONES_KeyDown_1(object sender, KeyEventArgs e)
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
    }
}

