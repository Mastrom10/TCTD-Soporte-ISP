using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SERV;
using BLL;
using SERV.MultiIdioma;


namespace GUI
{
    public partial class frmCambiarIdioma : Form, IIdiomaObserver
    {
        IdiomaBLL idiomaBLL;
        TraduccionBLL traduccionBLL;
        public frmCambiarIdioma()
        {
            InitializeComponent();
            idiomaBLL = new IdiomaBLL();
            traduccionBLL = new TraduccionBLL();
        }

        private void frmCambiarIdioma_Load(object sender, EventArgs e)
        {
            Session.SuscribirObservador(this);
            CargarIdioma();
            if (Session.GetSession().IsLogged()) {
                lblIdiomaActualValue.Text = Session.GetSession().usuario.idioma.Nombre;
            } else {
                lblIdiomaActualValue.Text = "Español";
            }
            CargarIdiomas();
        }

        void CargarIdiomas() {
            comboBoxIdiomas.DataSource = idiomaBLL.GetAll();
            comboBoxIdiomas.DisplayMember = "Nombre";
        }

        private void btnSeleccionarIdioma_Click(object sender, EventArgs e)
        {
            try
            {
                idiomaBLL.SeleccionarIdioma((Idioma)comboBoxIdiomas.SelectedItem);
                lblIdiomaActualValue.Text = Session.GetSession().usuario.idioma.Nombre;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public void CargarIdioma()
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
            lblCambioDeIdiomaTitulo.Text = traducciones.Find(x => x.etiqueta.Nombre == "lblCambioDeIdiomaTitulo").traduccion;
            lblIdiomaActual.Text = traducciones.Find(x => x.etiqueta.Nombre == "lblIdiomaActual").traduccion;
            this.Text = traducciones.Find(x => x.etiqueta.Nombre == "frmCambiarIdioma").traduccion;
            btnSeleccionarIdioma.Text = traducciones.Find(x => x.etiqueta.Nombre == "btnSeleccionarIdioma").traduccion;
            
        }


        
    }
}
