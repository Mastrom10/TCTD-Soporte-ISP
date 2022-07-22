using SERV.MultiIdioma;
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
using SERV;

namespace GUI
{
    public partial class frmGestorNodoRed : Form, IIdiomaObserver
    {
        TraduccionBLL traduccionBLL;
        List<Traduccion> traducciones;
        
        NodoRedBLL NodoRedBLL;
        public frmGestorNodoRed()
        {
            traduccionBLL = new TraduccionBLL();
            NodoRedBLL = new NodoRedBLL();
            InitializeComponent();
        }

        public void ActualizarIdioma(Idioma idioma)
        {
            traducciones = traduccionBLL.GetAllByIdioma(idioma);
            try
            {
                this.Text = traducciones.Find(x => x.etiqueta.Nombre == "frmGestorNodoRed").traduccion;
                lblId.Text = traducciones.Find(x => x.etiqueta.Nombre == "lblId").traduccion;
                lblnombreNodoRed.Text = traducciones.Find(x => x.etiqueta.Nombre == "lblnombreNodoRed").traduccion;
                lblEstadoNodoRed.Text = traducciones.Find(x => x.etiqueta.Nombre == "lblEstadoNodoRed").traduccion;
                lblGestorNodosRedTitle.Text = traducciones.Find(x => x.etiqueta.Nombre == "lblGestorNodosRedTitle").traduccion;
                btnNuevo.Text = traducciones.Find(x => x.etiqueta.Nombre == "btnNuevo").traduccion;
                btnGuardar.Text = traducciones.Find(x => x.etiqueta.Nombre == "btnGuardar").traduccion;
                btnEliminar.Text = traducciones.Find(x => x.etiqueta.Nombre == "btnEliminar").traduccion;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontraron/ Faltan traducciones para el idioma seleccionado");

            }
        }

        private void frmGestorNodoRed_Load(object sender, EventArgs e)
        {
            Session.SuscribirObservador(this);
            ActualizarIdioma(Session.GetSession().usuario?.idioma ?? Session.defaultIdioma);
            CargarNodos();
            
        
        }

        private void CargarNodos()
        {
            try
            {
                listBoxNodosRed.DataSource = NodoRedBLL.GetAll();
                listBoxNodosRed.DisplayMember = "nombre";
                comboBoxEstadoNodoRed.DataSource = Enum.GetValues(typeof(EstadoNodo));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listBoxNodosRed_SelectedIndexChanged(object sender, EventArgs e)
        {
            NodoRed nodoRed = (NodoRed)listBoxNodosRed.SelectedItem;
            if (nodoRed != null)
            {
                textBoxIdNodoRed.Text = nodoRed.Id.ToString();
                textBoxNombreNodoRed.Text = nodoRed.nombre;
                comboBoxEstadoNodoRed.Text = nodoRed.estado.ToString();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            listBoxNodosRed.SelectedItem = null;
            textBoxIdNodoRed.Text = "";
            textBoxNombreNodoRed.Text = "";
            comboBoxEstadoNodoRed.Text = "";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBoxNodosRed.SelectedItem == null)
                {
                    NodoRed nodoRed = new NodoRed();
                    nodoRed.nombre = textBoxNombreNodoRed.Text;
                    nodoRed.estado = (EstadoNodo)Enum.Parse(typeof(EstadoNodo), comboBoxEstadoNodoRed.Text);
                    NodoRedBLL.Create(nodoRed);
                    MessageBox.Show(Tag("tagNodoRedCreado"), Tag("tagInfoTitle"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    NodoRed nodoRed = (NodoRed)listBoxNodosRed.SelectedItem;
                    nodoRed.nombre = textBoxNombreNodoRed.Text;
                    nodoRed.estado = (EstadoNodo)Enum.Parse(typeof(EstadoNodo), comboBoxEstadoNodoRed.Text);
                    NodoRedBLL.Update(nodoRed);
                    MessageBox.Show(Tag("tagNodoRedActualizado"), Tag("tagInfoTitle"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                CargarNodos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string Tag(string tag)
        {
            string traduccion = tag;
            try
            {
                if (traducciones != null)
                {
                    traduccion = traducciones.Find(x => x.etiqueta.Nombre == tag).traduccion;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontraron/ Faltan traducciones para la etiqueta " + tag);
            }
            return traduccion;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Tag("tagConfirmarEliminarNodoRed"), Tag("tagInfoTitle"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    NodoRed nodoRed = (NodoRed)listBoxNodosRed.SelectedItem;
                    NodoRedBLL.Delete(nodoRed);
                    MessageBox.Show(Tag("tagNodoRedEliminado"), Tag("tagInfoTitle"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarNodos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
