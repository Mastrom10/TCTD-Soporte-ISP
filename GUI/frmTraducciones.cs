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
using SERV.MultiIdioma;
using SERV;

namespace GUI
{
    public partial class frmTraducciones : Form, IIdiomaObserver
    {
        IdiomaBLL IdiomaBLL;
        TraduccionBLL traduccionBLL;

        public frmTraducciones()
        {
            InitializeComponent();
            IdiomaBLL = new IdiomaBLL();
            traduccionBLL = new TraduccionBLL();
        }

        private void frmTraducciones_Load(object sender, EventArgs e)
        {
            Session.SuscribirObservador(this);
            CargarIdiomas();
            CargarIdioma();
        }

        void CargarIdiomas() {
            try
            {
                comboBoxIdiomas.DataSource = IdiomaBLL.GetAll();
                comboBoxIdiomas.DisplayMember = "Nombre";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void CargarTraducciones() {
            dataGridViewTraducciones.DataSource = traduccionBLL.GetAllByIdioma((Idioma)comboBoxIdiomas.SelectedItem);
            dataGridViewTraducciones.Columns[3].Visible = false;
            dataGridViewTraducciones.Columns[0].ReadOnly = true;
            dataGridViewTraducciones.Columns[1].ReadOnly = true;
        }

        private void comboBoxIdiomas_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarTraducciones();
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {

            try
            {
                List<Traduccion> traducciones = dataGridViewTraducciones.DataSource as List<Traduccion>;
                traduccionBLL.UpdateMany(traducciones);
                CargarTraducciones();
                Session.CambiarIdioma();
                MessageBox.Show("Se han guardado los cambios");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ActualizarIdioma(Idioma idioma)
        {
            List<Traduccion> traducciones = traduccionBLL.GetAllByIdioma(idioma);
            try
            {
                lblTraducciones.Text = traducciones.Find(x => x.etiqueta.Nombre == "lblTraducciones").traduccion;
                lblSeleccionarIdioma.Text = traducciones.Find(x => x.etiqueta.Nombre == "lblSeleccionarIdioma").traduccion;
                btnGuardarCambios.Text = traducciones.Find(x => x.etiqueta.Nombre == "btnGuardarCambios").traduccion;
                this.Text = traducciones.Find(x => x.etiqueta.Nombre == "frmTraducciones").traduccion;

            }
            catch (Exception)
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
    }
}
