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
using SERV;
using BLL;
using SERV.MultiIdioma;

namespace GUI
{
    public partial class frmDispositivosNoAsignados : Form, IIdiomaObserver
    {
        DispositivoBLL dispositivoBLL;

        public Dispositivo dispositivoSeleccionado;
        public frmDispositivosNoAsignados()
        {
            
            dispositivoBLL = new DispositivoBLL();
            InitializeComponent();
            CargarDispositivos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        void CargarDispositivos()
        {
            try
            {
                listBoxUnassignedDevices.DataSource = dispositivoBLL.GetUnassigned();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (listBoxUnassignedDevices.SelectedIndex != -1)
            {
                this.dispositivoSeleccionado = (Dispositivo)listBoxUnassignedDevices.SelectedItem;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else {
                MessageBox.Show(Tag("TagSeleccioneDispositivo"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        TraduccionBLL traduccionBLL;
        List<Traduccion> traducciones;

        public void ActualizarIdioma(Idioma idioma)
        {
            traducciones = traduccionBLL.GetAllByIdioma(idioma);
            try
            {
                this.Text = traducciones.Find(x => x.etiqueta.Nombre == "lblDispositivosDisponibles").traduccion;
                lblDispositivosDisponibles.Text = traducciones.Find(x => x.etiqueta.Nombre == "lblDispositivosDisponibles").traduccion;
                btnSeleccionar.Text = traducciones.Find(x => x.etiqueta.Nombre == "btnSeleccionar").traduccion;
                btnCancelar.Text = traducciones.Find(x => x.etiqueta.Nombre == "btnCancelar").traduccion;
                lblSeleccionarUnDispositivo.Text = traducciones.Find(x => x.etiqueta.Nombre == "lblSeleccionarUnDispositivo").traduccion;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontraron/ Faltan traducciones para el idioma seleccionado");

            }
        }

        private void frmDispositivosNoAsignados_Load(object sender, EventArgs e)
        {
            traduccionBLL = new TraduccionBLL();
            Session.SuscribirObservador(this);
            ActualizarIdioma(Session.GetSession().usuario?.idioma ?? Session.defaultIdioma);
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
        
    }
}
