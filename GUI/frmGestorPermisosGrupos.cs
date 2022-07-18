using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BLL;
using SERV.Composite;
using SERV.MultiIdioma;
using SERV;

namespace GUI
{
    public partial class frmGestorPermisosGrupos : Form, IIdiomaObserver 
    {
        PermisoBLL permisoBLL;
        TraduccionBLL traduccionBLL;
        List<Traduccion> traducciones;

        public frmGestorPermisosGrupos()
        {
            InitializeComponent();
            permisoBLL = new PermisoBLL();
            traduccionBLL = new TraduccionBLL();
        }

        private void frmGestorPermisosGrupos_Load(object sender, EventArgs e)
        {
            Session.SuscribirObservador(this);
            CargarPermisos();
            HabilitarBotones();
            CargarIdioma();
        }

        private void btnCrearFamilia_Click(object sender, EventArgs e)
        {
            string nombre = txtboxNombrePermiso.Text;
            if (nombre == "")
            {
                MessageBox.Show(Tag("TagGrupoErrorNecesitaNombre"));
                return;
            }

            permisoBLL.CrearFamilia(nombre);
            txtboxNombrePermiso.Text = "";
            MessageBox.Show(Tag("TagGrupoCreadoOK"));
           
            CargarPermisos();
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
                if (MessageBox.Show(Tag("TagAlertaBorrarPermisoP1") + treeViewTodosLosPermisos2.SelectedNode.Text + Tag("TagAlertaBorrarPermisoP2"), 
                    Tag("TagEliminarPermiso"), MessageBoxButtons.YesNo) == DialogResult.Yes)
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

        public void ActualizarIdioma(Idioma idioma)
        {
            traducciones = traduccionBLL.GetAllByIdioma(idioma);
            try
            {
                lblCrearNuevoGrupo.Text = traducciones.Find(x => x.etiqueta.Nombre == "lblCrearNuevoGrupo").traduccion;
                lblNombre.Text = traducciones.Find(x => x.etiqueta.Nombre == "lblNombre").traduccion;
                btnCrearFamilia.Text = traducciones.Find(x => x.etiqueta.Nombre == "btnCrearFamilia").traduccion;
                lblListadoDeGrupos.Text = traducciones.Find(x => x.etiqueta.Nombre == "lblListadoDeGrupos").traduccion;
                lblTodosLosPermisos.Text = traducciones.Find(x => x.etiqueta.Nombre == "lblTodosLosPermisos").traduccion;
                btnQuitarPermiso.Text = traducciones.Find(x => x.etiqueta.Nombre == "btnQuitarPermiso").traduccion;
                btnSumarPermiso.Text = traducciones.Find(x => x.etiqueta.Nombre == "btnSumarPermiso").traduccion;
                btnEliminarPermiso.Text = traducciones.Find(x => x.etiqueta.Nombre == "btnEliminarPermiso").traduccion;
                this.Text = traducciones.Find(x => x.etiqueta.Nombre == "frmPermisos").traduccion;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontraron/ Faltan traducciones para el idioma seleccionado");

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

        public string Tag(string tag)
        {
            string traduccion = tag;
            try
            {
                traduccion = traducciones.Find(x => x.etiqueta.Nombre == tag).traduccion;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontraron/ Faltan traducciones para la etiqueta " + tag);
            }
            return traduccion;
        }

        
    }
}
