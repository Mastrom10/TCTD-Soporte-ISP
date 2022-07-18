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
using SERV.MultiIdioma;

namespace GUI
{
    public partial class frmGestorPermisosUsuario : Form, IIdiomaObserver
    {
        PermisoBLL permisoBLL = new PermisoBLL();
        UsuarioBLL usuarioBLL = new UsuarioBLL();
        TraduccionBLL traduccionBLL;


        Usuario selectedUser = null;
        public frmGestorPermisosUsuario()
        {
            traduccionBLL = new TraduccionBLL();
            InitializeComponent();
        }

        private void frmGestorPermisos_Load(object sender, EventArgs e)
        {
            Session.SuscribirObservador(this);
            CargarPermisos();
            CargarUsuarios();
            CargarIdioma();
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
            raiz.ForeColor = Color.Blue;
            tv.Nodes.Add(raiz);

            foreach (Permiso permiso in listaDePermisos)
            {
                if (permiso is Familia)
                {
                    TreeNode nodo = CrearNodo(permiso);
                    nodo.ForeColor = Color.Blue;
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
                    nodoNuevo.ForeColor = Color.Blue;
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

        private void btnQuitarPermiso_Click(object sender, EventArgs e)
        {
            if (treeViewPermisosUsuario.SelectedNode != null)
            {
                Permiso permiso = (Permiso)treeViewPermisosUsuario.SelectedNode.Tag;
                permisoBLL.QuitarPermisoAUsuario(selectedUser, permiso);
                CargarPermisosUsuario(selectedUser);
            }
        }

        private void btnAgregarPermiso_Click(object sender, EventArgs e)
        {
            if (treeViewTodosLosPermisos.SelectedNode != null)
            {
                Permiso permiso = (Permiso)treeViewTodosLosPermisos.SelectedNode.Tag;
                try
                {
                    permisoBLL.AgregarPermisoAUsuario(selectedUser, permiso);

                }
                catch (Exception ex)
                {
                    //show error
                    MessageBox.Show(ex.Message);
                }
                CargarPermisosUsuario(selectedUser);
            }
        }

        private void CargarIdioma()
        {
            if (Session.GetSession().IsLogged())
            {
                ActualizarIdioma(Session.GetSession().usuario.idioma);
            }
            else
            {
                ActualizarIdioma(Session.defaultIdioma);
            }
        }

        public void ActualizarIdioma(Idioma idioma)
        {
            List<Traduccion> traducciones = traduccionBLL.GetAllByIdioma(idioma);
            try
            {
                lblTituloGestorPermisos.Text = traducciones.Find(x => x.etiqueta.Nombre == "lblTituloGestorPermisos").traduccion;
                this.Text = traducciones.Find(x => x.etiqueta.Nombre == "frmGestorPermisosUsuario").traduccion;
                lblUsuario.Text = traducciones.Find(x => x.etiqueta.Nombre == "lblUsuario").traduccion;
                lblUsuarioSeleccionado.Text = traducciones.Find(x => x.etiqueta.Nombre == "lblUsuarioSeleccionado").traduccion;
                lblListPermisosDeUsuario.Text = traducciones.Find(x => x.etiqueta.Nombre == "lblListPermisosDeUsuario").traduccion;
                lblListTodosLosPermisos.Text = traducciones.Find(x => x.etiqueta.Nombre == "lblListTodosLosPermisos").traduccion;
                btnQuitarPermiso.Text = traducciones.Find(x => x.etiqueta.Nombre == "btnQuitarPermiso").traduccion;
                btnAgregarPermiso.Text = traducciones.Find(x => x.etiqueta.Nombre == "btnAgregarPermiso").traduccion;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontraron/ Faltan traducciones para el idioma seleccionado");

            }
        }
    }
}
