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
    public partial class frmGestionDispositivosCliente : Form, IIdiomaObserver
    {
        Cliente clienteSeleccionado;
        DispositivoBLL dispositivoBLL;
        TraduccionBLL traduccionBLL;
        List<Traduccion> traducciones;

        private void frmGestionDispositivosCliente_Load(object sender, EventArgs e)
        {
            traduccionBLL = new TraduccionBLL();
            Session.SuscribirObservador(this);
            ActualizarIdioma(Session.GetSession().usuario?.idioma ?? Session.defaultIdioma);
            cargarDispositivos();
            lvlNroCLienteValue.Text = clienteSeleccionado.Id.ToString();
            lblNombreyApellidoValue.Text = clienteSeleccionado.nombre + " " + clienteSeleccionado.apellido;
        }

        public frmGestionDispositivosCliente(Cliente cliente)
        {
            clienteSeleccionado = cliente;
            dispositivoBLL = new DispositivoBLL();
            InitializeComponent();
        }

        private void cargarDispositivos()
        {
            try
            {
                listBoxDispositivosCliente.DataSource = dispositivoBLL.getDispositivoByServicio(clienteSeleccionado.servicio);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void listBoxDispositivosCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxDispositivosCliente.SelectedIndex != -1)
            {
                btnQuitarDispositivo.Enabled = true;
            }
        }

        private void btnQuitarDispositivo_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBoxDispositivosCliente.SelectedIndex != -1)
                {

                    dispositivoBLL.QuitarDispositivoAServicio((Dispositivo)listBoxDispositivosCliente.SelectedItem, clienteSeleccionado.servicio);
                    cargarDispositivos();
                }
                else {
                    MessageBox.Show(Tag("TagSeleccioneUnDispositivo"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregarDispositivo_Click(object sender, EventArgs e)
        {
            frmDispositivosNoAsignados frmDispositivosNoAsignados = new frmDispositivosNoAsignados();
            DialogResult result = frmDispositivosNoAsignados.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    dispositivoBLL.AgregarDispositivoAServicio((Dispositivo)frmDispositivosNoAsignados.dispositivoSeleccionado, clienteSeleccionado.servicio);
                    cargarDispositivos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

        public void ActualizarIdioma(Idioma idioma)
        {
            traducciones = traduccionBLL.GetAllByIdioma(idioma);
            try
            {
                this.Text = traducciones.Find(x => x.etiqueta.Nombre == "lblGetsionDispositivoCliente").traduccion;
                lblGetsionDispositivoCliente.Text = traducciones.Find(x => x.etiqueta.Nombre == "lblGetsionDispositivoCliente").traduccion;
                lblNombreyApellido.Text = traducciones.Find(x => x.etiqueta.Nombre == "lblNombreyApellido").traduccion;
                lblNroCliente.Text = traducciones.Find(x => x.etiqueta.Nombre == "lblNroCliente").traduccion;
                btnAgregarDispositivo.Text = traducciones.Find(x => x.etiqueta.Nombre == "btnAgregarDispositivo").traduccion;
                btnQuitarDispositivo.Text = traducciones.Find(x => x.etiqueta.Nombre == "btnQuitarDispositivo").traduccion;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontraron/ Faltan traducciones para el idioma seleccionado");

            }
        }
    }
}
