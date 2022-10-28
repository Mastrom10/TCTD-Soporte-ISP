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
    public partial class frmControlCambiosClientes : Form, IIdiomaObserver
    {

        ClienteBLL clienteBLL;
        Cliente clienteSeleccionado = null;

        
        public frmControlCambiosClientes()
        {
            InitializeComponent();
            clienteBLL = new ClienteBLL();
            
        }

        private void frmControlCambiosClientes_Load(object sender, EventArgs e)
        {
            Session.SuscribirObservador(this);
            ActualizarIdioma(Session.GetSession().usuario?.idioma ?? Session.defaultIdioma);
        }

        Func<string, string> Tag;
        public void ActualizarIdioma(Idioma idioma)
        {
            IdiomaUtils.traducciones = new TraduccionBLL().GetAllByIdioma(idioma);
            Tag = IdiomaUtils.Tag;
            this.Text = Tag("frmControlCambiosClientes");
            groupBoxBuscarCliente.Text = Tag("groupBoxBuscarCliente");
            lblNroCliente.Text = Tag("lblNroCliente");
            lblDNICliente.Text = Tag("lblDNICliente");
            btnBuscar.Text = Tag("btnBuscar");
            btnVerEstado.Text = Tag("btnVerEstado");

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxNroClienteID.Text == "" && textBoxDNICliente.Text == "")
                {
                    MessageBox.Show(Tag("SinCriterioBusqueda"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (textBoxNroClienteID.Text != "")
                {
                    int nroCliente = int.Parse(textBoxNroClienteID.Text);
                    Cliente cliente = clienteBLL.GetById(nroCliente);
                    if (cliente != null)
                    {
                        clienteSeleccionado = cliente;
                        CompletarHistoricoCliente(cliente);
                    }
                    else
                    {
                        MessageBox.Show(Tag("ClienteNoEncontrado"), Tag("tagInfoTitle"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    string dni = textBoxDNICliente.Text;
                    Cliente cliente = clienteBLL.getByDNI(dni);
                    if (cliente != null)
                    {
                        clienteSeleccionado = cliente;
                        CompletarHistoricoCliente(cliente);
                    }
                    else
                    {
                        MessageBox.Show(Tag("ClienteNoEncontrado"), Tag("tagInfoTitle"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarDatos()
        {
            textBoxDNICliente.Text = "";
            textBoxNroClienteID.Text = "";
            listBoxEstadosCliente.DataSource = null;
            listBoxEstadosCliente.Items.Clear();
            listBoxEstadosCliente.Items.Add(Tag("ClienteNoSeleccionadoEstados"));
            listBoxEstadosCliente.Enabled = false;
            
        }

        void CompletarHistoricoCliente(Cliente cliente) {
            List<State<Cliente>> states = clienteBLL.GetStates(cliente);
            listBoxEstadosCliente.DataSource = null;
            listBoxEstadosCliente.Items.Clear();
            btnBuscar.Enabled = false;
            textBoxDNICliente.Enabled = false;
            textBoxNroClienteID.Enabled = false;
            if (states.Count > 0)
            {
                listBoxEstadosCliente.DataSource = states;
                listBoxEstadosCliente.DisplayMember = "ToStringList";
                listBoxEstadosCliente.Enabled = true;
                btnVerEstado.Enabled = true;


            }
            else
            {
                listBoxEstadosCliente.Items.Add(Tag("ClienteSinEstados"));
                listBoxEstadosCliente.Enabled = false;
                btnVerEstado.Enabled = false;
                MessageBox.Show(Tag("ClienteSinCambiosRegistrados"), Tag("tagInfoTitle"), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            clienteSeleccionado = null;
            btnBuscar.Enabled = true;
            textBoxDNICliente.Enabled = true;
            textBoxNroClienteID.Enabled = true;
            btnVerEstado.Enabled = false;
            LimpiarDatos();
        }

        private void btnVerEstado_Click(object sender, EventArgs e)
        {
            if (listBoxEstadosCliente.SelectedItem != null)
            {
                State<Cliente> state = (State<Cliente>)listBoxEstadosCliente.SelectedItem;
                frmGestorClientes frmVerEstadoCliente = new frmGestorClientes(state);
                frmVerEstadoCliente.Enabled = true;
                frmVerEstadoCliente.ShowDialog();
                if (frmVerEstadoCliente.DialogResult == DialogResult.OK)
                {
                    CompletarHistoricoCliente(clienteSeleccionado);
                }
            }
        }
    }
}
