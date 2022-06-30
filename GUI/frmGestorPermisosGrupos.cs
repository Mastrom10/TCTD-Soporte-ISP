using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using BLL;
using SERV.Composite;

namespace GUI
{
    public partial class frmGestorPermisosGrupos : Form
    {
        PermisoBLL permisoBLL;
        public frmGestorPermisosGrupos()
        {
            InitializeComponent();
            permisoBLL = new PermisoBLL();
        }

        private void frmGestorPermisosGrupos_Load(object sender, EventArgs e)
        {
            comboBoxPermisosEnum.DataSource = Enum.GetValues(typeof(TipoPermiso));
            CargarPermisos();
            HabilitarBotones();
        }

        private void btnCrearPermiso_Click(object sender, EventArgs e)
        {
            string nombre = txtboxNombrePermiso.Text;
            if (nombre == "")
            {
                MessageBox.Show("Debe ingresar un nombre para el Permiso");
                return;
            }

            if (CheckEsGrupo.Checked) {
                permisoBLL.CrearFamilia(nombre);
                txtboxNombrePermiso.Text = "";
                MessageBox.Show("Grupo creado con éxito");
            }
            else
            {
                TipoPermiso tipo = (TipoPermiso)comboBoxPermisosEnum.SelectedItem;
                permisoBLL.CrearPatente(nombre, tipo);
                txtboxNombrePermiso.Text = "";
                MessageBox.Show("Permiso creado con éxito");
            }
            CargarPermisos();
        }

        private void checkEsGrupo_CheckedChanged(object sender, EventArgs e)
        {
            if (!CheckEsGrupo.Checked)
            {
                comboBoxPermisosEnum.Enabled = true;
            }
            else
            {
                comboBoxPermisosEnum.Enabled = false;
            }
        }



        private void CargarPermisos()
        {
            List<Permiso> todosLosPermisos = permisoBLL.GetAll();

            CompletarLista(treeViewTodosLosPermisos, todosLosPermisos.Where(p => p is Familia).ToList(), true);
            CompletarLista(treeViewTodosLosPermisos2, todosLosPermisos, true);
        }

        private void CompletarLista(TreeView tv, List<Permiso> listaDePermisos, bool validarPadre = true)
        {
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

        private void btnSumarPermiso_Click(object sender, EventArgs e)
        {
            if (asignacionValida())
            {
                Permiso permiso = (Permiso)treeViewTodosLosPermisos2.SelectedNode.Tag;

                Permiso Grupo = (Permiso)treeViewTodosLosPermisos.SelectedNode.Tag;
                try
                {
                    permisoBLL.VincularPadreHijo(Grupo, permiso);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
                CargarPermisos();
            }
        }

        private void btnQuitarPermiso_Click(object sender, EventArgs e)
        {
            if (treeViewTodosLosPermisos.SelectedNode != null && treeViewTodosLosPermisos.SelectedNode.Text != "Permisos") {
                Permiso permiso = (Permiso)treeViewTodosLosPermisos.SelectedNode.Tag;
                Permiso padre = (Permiso)treeViewTodosLosPermisos.SelectedNode.Parent.Tag;
                try
                {
                    permisoBLL.DesvincularPadreHijo(padre, permiso);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                CargarPermisos();
            }
        }
        
        private void treeViewTodosLosPermisos2_AfterSelect(object sender, TreeViewEventArgs e)
        {
            HabilitarBotones();
            BackColorAllNodes(treeViewTodosLosPermisos2.TopNode);
            treeViewTodosLosPermisos2.SelectedNode.BackColor = Color.Cyan;
        }

        private void BackColorAllNodes(TreeNode node)
        {
            node.BackColor = Color.White;
            foreach (TreeNode n in node.Nodes)
            {
                BackColorAllNodes(n);
            }
        }

        private void treeViewTodosLosPermisos_AfterSelect(object sender, TreeViewEventArgs e)
        {
            HabilitarBotones();
            BackColorAllNodes(treeViewTodosLosPermisos.TopNode);
            treeViewTodosLosPermisos.SelectedNode.BackColor = Color.Cyan;
        }

        public void HabilitarBotones() {
            btnSumarPermiso.Enabled = asignacionValida();
            btnQuitarPermiso.Enabled = treeViewTodosLosPermisos.SelectedNode != null && treeViewTodosLosPermisos.SelectedNode.Text != "Permisos";
            btnEliminarPermiso.Enabled = treeViewTodosLosPermisos2.SelectedNode != null && treeViewTodosLosPermisos2.SelectedNode.Text != "Permisos";
        }

        private bool asignacionValida() {
            return treeViewTodosLosPermisos2.SelectedNode != null
                                        && treeViewTodosLosPermisos2.SelectedNode.Text != "Permisos"
                                        && treeViewTodosLosPermisos.SelectedNode != null
                                        && treeViewTodosLosPermisos.SelectedNode.Text != "Permisos";
        }

        private void btnEliminarPermiso_Click(object sender, EventArgs e)
        {
            if (treeViewTodosLosPermisos2.SelectedNode != null && treeViewTodosLosPermisos2.SelectedNode.Text != "Permisos")
            {
                // messagebox está seguro?
                if (MessageBox.Show("Está a punto de eliminar el permiso: " + treeViewTodosLosPermisos2.SelectedNode.Text +
                    "\n\nTodos los permisos Hijos quedarán Huerfanos." +
                    "\nTambien se le quitará el permiso a todos los usuarios que lo tengan." +
                    "\nESTA ES UNA OPERACION PELIGROSA QUE PODRIA AFECTAR A LA INTEGRIDAD DEL SISTEMA" +
                    "\n\n¿Desea Eliminar el Permiso?", "Eliminar permiso", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Permiso permiso = (Permiso)treeViewTodosLosPermisos2.SelectedNode.Tag;
                    try
                    {
                        permisoBLL.EliminarPermiso(permiso);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    CargarPermisos();
                }


            }

        }
    }
}
