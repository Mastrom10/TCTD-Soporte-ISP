using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using SERV.Composite;
using SERV;

namespace GUI
{
    public partial class frmGestorPermisos : Form
    {
        PermisoBLL permisoBLL = new PermisoBLL();
        UsuarioBLL usuarioBLL = new UsuarioBLL();

        Usuario selectedUser = null;
        public frmGestorPermisos()
        {
            InitializeComponent();
        }

        private void frmGestorPermisos_Load(object sender, EventArgs e)
        {
            CargarPermisos();
            CargarUsuarios();
        }


        private void CargarPermisosUsuario(Usuario user) {
            user.Permisos = permisoBLL.getPermisosPorUsuario(user);
            CompletarLista(treeViewPermisosUsuario, user.Permisos, false); 
        }

        private void CargarUsuarios() {
            List<Usuario> usuarios = usuarioBLL.GetAll();
            comboBoxUsuario.DataSource = usuarios;
            comboBoxUsuario.DisplayMember = "Email";
        }


        private void CargarPermisos() {
            List<Permiso> todosLosPermisos = permisoBLL.GetAll();
            CompletarLista(treeViewTodosLosPermisos, todosLosPermisos, true);
        }

        private void CompletarLista(TreeView tv, List<Permiso> listaDePermisos, bool validarPadre = true) {
            tv.Nodes.Clear();
            TreeNode raiz = new TreeNode("Permisos");
            tv.Nodes.Add(raiz);

            foreach (Permiso permiso in listaDePermisos)
            {
                if (permiso is Familia)
                {
                    TreeNode nodo = CrearNodo(permiso);
                    raiz.Nodes.Add(nodo);
                    CargarPermisosRecursivo(permiso, nodo);
                }
                else if (!validarPadre || !permisoBLL.TienePadre(permiso))
                {
                    TreeNode nodo = CrearNodo(permiso);
                    raiz.Nodes.Add(nodo);
                }

            }
        }

        private void CargarPermisosRecursivo(Permiso permiso, TreeNode nodo)
        {
            foreach (Permiso p in permiso.ObtenerHijos())
            {
                TreeNode nodoNuevo = CrearNodo(p);
                nodo.Nodes.Add(nodoNuevo);

                if (p is Familia)
                {
                    CargarPermisosRecursivo(p, nodoNuevo);
                }
            }
        }

        private TreeNode CrearNodo(Permiso item)
        {
            TreeNode tn = new TreeNode(item.Nombre);
            tn.Tag = item;

            return tn;
        }

        private void comboBoxUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedUser = (Usuario)comboBoxUsuario.SelectedItem;
            UpdateSelectedUserLabel();
            CargarPermisosUsuario(selectedUser);
        }

        private void UpdateSelectedUserLabel() {
            lblSelectedUser.Text = selectedUser.Email;
        }

      

        private void habilitarBotones() {
            btnAgregarPermiso.Enabled = treeViewTodosLosPermisos.SelectedNode != null && treeViewTodosLosPermisos.SelectedNode.Text != "Permisos";
            btnQuitarPermiso.Enabled = treeViewPermisosUsuario.SelectedNode != null && treeViewPermisosUsuario.SelectedNode.Text != "Permisos";
        }

        private void treeViewTodosLosPermisos_AfterSelect(object sender, TreeViewEventArgs e)
        {
            habilitarBotones();
        }
        private void treeViewPermisosUsuario_AfterSelect(object sender, TreeViewEventArgs e)
        {
            habilitarBotones();
        }

        private void btnQuitarPermiso_Click_1(object sender, EventArgs e)
        {
            if (treeViewPermisosUsuario.SelectedNode != null)
            {
                Permiso permiso = (Permiso)treeViewPermisosUsuario.SelectedNode.Tag;
                permisoBLL.QuitarPermisoAUsuario(selectedUser, permiso);
                CargarPermisosUsuario(selectedUser);
            }
        }

        private void btnAgregarPermiso_Click_1(object sender, EventArgs e)
        {
            if (treeViewTodosLosPermisos.SelectedNode != null)
            {
                Permiso permiso = (Permiso)treeViewTodosLosPermisos.SelectedNode.Tag;
                permisoBLL.AgregarPermisoAUsuario(selectedUser, permiso);
                CargarPermisosUsuario(selectedUser);
            }
        }
    }
}
