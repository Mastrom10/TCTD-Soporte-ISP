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
using SERV;
using SERV.MultiIdioma;

namespace GUI
{
    public partial class frmABMIdiomas : Form, IIdiomaObserver
    {
        IdiomaBLL IdiomaBLL;
        TraduccionBLL traduccionBLL;
        List<Traduccion> traducciones;

        public frmABMIdiomas()
        {
            IdiomaBLL = new IdiomaBLL();
            traduccionBLL = new TraduccionBLL();
            InitializeComponent();
        }
        

        private void frmABMIdiomas_Load(object sender, EventArgs e)
        {
            Session.SuscribirObservador(this);
            CargarIdioma();
            ActualizarGrilla();
            
        }

        private void ActualizarGrilla() {
            listBoxIdiomas.DataSource = IdiomaBLL.GetAll();
            listBoxIdiomas.DisplayMember = "Nombre";

        }

        private void btnNuevoIdioma_Click(object sender, EventArgs e)
        {
            try
            {
                IdiomaBLL.Create(new Idioma() { Nombre = textBoxNuevoIdioma.Text });
                MessageBox.Show(Tag("TagIdiomaCreado"));
                textBoxNuevoIdioma.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(Tag("TagErrorCrearIdioma") + ex.Message);

            }            
            ActualizarGrilla();

        }

        private void listBoxIdiomas_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxModificarIdioma.Text = ((Idioma)listBoxIdiomas.SelectedItem).Nombre;
        }

        private void btnGuardarIdioma_Click(object sender, EventArgs e)
        {
            if (textBoxModificarIdioma.Text != "")
            {
                Idioma idioma = (Idioma)listBoxIdiomas.SelectedItem;
                idioma.Nombre = textBoxModificarIdioma.Text;
                try
                {
                    IdiomaBLL.Update(idioma);
                    MessageBox.Show(Tag("TagIdiomaModificado"));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Tag("TagErrorModificarIdioma") + ex.Message);
                }
                ActualizarGrilla();
            }
        }

        private void btnEliminarIdioma_Click(object sender, EventArgs e)
        {
            Idioma idioma = (Idioma)listBoxIdiomas.SelectedItem;
            try
            {
                //Messagebox confirmacion
                if (MessageBox.Show(Tag("TagAlertaBorrarIdioma") + idioma.Nombre, Tag("TagEliminarIdioma"), MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    IdiomaBLL.Delete(idioma);
                    MessageBox.Show(Tag("TagEliminadoOK"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Tag("TagEliminadoError") + ex.Message);
            }
            ActualizarGrilla();
        }

        public void ActualizarIdioma(Idioma idioma)
        {
            traducciones = traduccionBLL.GetAllByIdioma(idioma);
            try
            {
                lblTitleIdiomas.Text = traducciones.Find(x => x.etiqueta.Nombre == "lblTitleIdiomas").traduccion;
                this.Text = traducciones.Find(x => x.etiqueta.Nombre == "frmABMIdiomas").traduccion;
                lblModificarIdioma.Text = traducciones.Find(x => x.etiqueta.Nombre == "lblModificarIdioma").traduccion;
                btnGuardarIdioma.Text = traducciones.Find(x => x.etiqueta.Nombre == "btnGuardar").traduccion;
                lblNuevoIdioma.Text = traducciones.Find(x => x.etiqueta.Nombre == "lblNuevoIdioma").traduccion;
                btnCrear.Text = traducciones.Find(x => x.etiqueta.Nombre == "btnCrear").traduccion;
                btnEliminarIdioma.Text = traducciones.Find(x => x.etiqueta.Nombre == "btnEliminar").traduccion;
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
