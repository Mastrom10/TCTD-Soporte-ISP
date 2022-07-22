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
using BE;
using BLL;
using SERV.MultiIdioma;

namespace GUI
{
    public partial class frmGestorDispositivo : Form, IIdiomaObserver
    {
        DispositivoBLL dispositivoBLL;
        TraduccionBLL traduccionBLL;

        List<Traduccion> traducciones;
        public frmGestorDispositivo()
        {
            dispositivoBLL = new DispositivoBLL();
            traduccionBLL = new TraduccionBLL();
            InitializeComponent();
        }

        public void ActualizarIdioma(Idioma idioma)
        {
            traducciones = traduccionBLL.GetAllByIdioma(idioma);
            try
            {
                this.Text = traducciones.Find(x => x.etiqueta.Nombre == "lblGestorDispositivo").traduccion;
                btnNuevo.Text = traducciones.Find(x => x.etiqueta.Nombre == "btnNuevo").traduccion;
                btnGuardar.Text = traducciones.Find(x => x.etiqueta.Nombre == "btnGuardar").traduccion;
                btnEliminar.Text = traducciones.Find(x => x.etiqueta.Nombre == "btnEliminar").traduccion;
                lblId.Text = traducciones.Find(x => x.etiqueta.Nombre == "lblId").traduccion;
                lblGestorDispositivo.Text = traducciones.Find(x => x.etiqueta.Nombre == "lblGestorDispositivo").traduccion;
                lblTipo.Text = traducciones.Find(x => x.etiqueta.Nombre == "lblTipo").traduccion;
                lblMacAdress.Text = traducciones.Find(x => x.etiqueta.Nombre == "lblMacAdress").traduccion;
                lblNroSerie.Text = traducciones.Find(x => x.etiqueta.Nombre == "lblNroSerie").traduccion;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontraron/ Faltan traducciones para el idioma seleccionado");

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


        private void frmGestorDispositivo_Load(object sender, EventArgs e)
        {
            Session.SuscribirObservador(this);
            ActualizarIdioma(Session.GetSession().usuario?.idioma ?? Session.defaultIdioma);
            CargarListViewDispositivos();
        }

        private void CargarListViewDispositivos()
        {
            try
            {
                listBoxDispositivos.DataSource = dispositivoBLL.GetAll();
                listBoxDispositivos.DisplayMember = "MacAdress";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listBoxDispositivos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dispositivo dispositivo = (Dispositivo)listBoxDispositivos.SelectedItem;
            if (dispositivo != null)
            {
                textBoxID.Text = dispositivo.Id.ToString();
                textBoxMacAdress.Text = dispositivo.macAdress;
                textBoxNumerodeSerie.Text = dispositivo.nroserie;
                textBoxTipo.Text = dispositivo.tipo;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            listBoxDispositivos.SelectedItem = null;
            textBoxID.Text = "";
            textBoxMacAdress.Text = "";
            textBoxNumerodeSerie.Text = "";
            textBoxTipo.Text = "";
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (textBoxMacAdress.Text == "")
            {
                MessageBox.Show(Tag("TagErrorIngresarMacAdress"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (listBoxDispositivos.SelectedItem == null) {
                    Dispositivo dispositivo = new Dispositivo();
                    dispositivo.macAdress = textBoxMacAdress.Text;
                    dispositivo.nroserie = textBoxNumerodeSerie.Text;
                    dispositivo.tipo = textBoxTipo.Text;
                    dispositivoBLL.Create(dispositivo);
                    MessageBox.Show(Tag("tagDispositivoCreado"), Tag("tagInfoTitle"), MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    Dispositivo dispositivo = (Dispositivo)listBoxDispositivos.SelectedItem;
                    dispositivo.macAdress = textBoxMacAdress.Text;
                    dispositivo.nroserie = textBoxNumerodeSerie.Text;
                    dispositivo.tipo = textBoxTipo.Text;
                    dispositivoBLL.Update(dispositivo);
                    MessageBox.Show(Tag("tagDispositivoActualizado"), Tag("tagInfoTitle"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            CargarListViewDispositivos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (listBoxDispositivos.SelectedItem == null)
            {
                MessageBox.Show(Tag("TagErrorSeleccionarDispositivo"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                if (MessageBox.Show(Tag("msgConfirmarEliminarDispositivo"), Tag("tagInfoTitle"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                    Dispositivo dispositivo = (Dispositivo)listBoxDispositivos.SelectedItem;
                    dispositivoBLL.Delete(dispositivo);
                    MessageBox.Show(Tag("tagDispositivoEliminado"), Tag("tagInfoTitle"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            CargarListViewDispositivos();
        }
    }
}
