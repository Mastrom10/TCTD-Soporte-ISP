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
    public partial class frmSoporteClientes : Form, IIdiomaObserver
    {


        ClienteBLL clienteBLL;
        Cliente clienteSeleccionado = null;
        TicketBLL ticketBLL;

        public frmSoporteClientes()
        {
            InitializeComponent();
            clienteBLL = new ClienteBLL();
            ticketBLL = new TicketBLL();
        }

        private void frmSoporteClientes_Load(object sender, EventArgs e)
        {
            Session.SuscribirObservador(this);
            ActualizarIdioma(Session.GetSession().usuario?.idioma ?? Session.defaultIdioma);
        }

        Func<string, string> Tag;
        public void ActualizarIdioma(Idioma idioma)
        {
            IdiomaUtils.traducciones = new TraduccionBLL().GetAllByIdioma(idioma);
            Tag = IdiomaUtils.Tag;
            this.Text = Tag("frmSoporteClientes");
            groupBoxBuscarCliente.Text = Tag("groupBoxBuscarCliente");
            lblNroCliente.Text = Tag("lblNroCliente");
            lblDNICliente.Text = Tag("lblDNICliente");
            btnBuscar.Text = Tag("btnBuscar");
            lblNombre.Text = Tag("lblNombre");
            lblApellido.Text = Tag("lblApellido");
            labelNroCliente.Text = Tag("labelNroCliente");
            lblDNI.Text = Tag("lblDNI");
            lblFechaNacimiento.Text = Tag("lblFechaNacimiento");
            lblTelPrincipal.Text = Tag("lblTelPrincipal");
            lblTelSecundario.Text = Tag("lblTelSecundario");
            lblEmail.Text = Tag("lblEmail");
            lblClienteNododeRed.Text = Tag("lblClienteNododeRed");
            lblClienteProvincia.Text = Tag("lblClienteProvincia");
            lblClienteLocalidad.Text = Tag("lblClienteLocalidad");
            lblClienteCodigoPostal.Text = Tag("lblClienteCodigoPostal");
            lblClienteDepto.Text = Tag("lblClienteDepto");
            lblClienteCalle.Text = Tag("lblClienteCalle");
            lblClienteAltura.Text = Tag("lblClienteAltura");
            lblClientePiso.Text = Tag("lblClientePiso");
            lblEstadoServicio.Text = Tag("lblEstadoServicio");
            lblServicePlan.Text = Tag("lblServicePlan");
            labelDispositivos.Text = Tag("labelDispositivos");
            groupBoxDomicilio.Text = Tag("groupBoxDomicilio");
            groupBoxServicio.Text = Tag("groupBoxServicio");
            groupBoxInfoCliente.Text = Tag("groupBoxInfoCliente");
            groupBoxDatosContacto.Text = Tag("groupBoxDatosContacto");
            btnVerTicket.Text = Tag("btnVerTicket");
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
                        CompletarDatosCliente(cliente);
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
                        CompletarDatosCliente(cliente);
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

        private void CompletarDatosCliente(Cliente cliente)
        {
            lblValueNroCliente.Text = cliente.Id.ToString();
            lblValueNombre.Text = cliente.nombre;
            lblValueApellido.Text = cliente.apellido;
            lblValueDNI.Text = cliente.dni;
            lblValueFNacimiento.Text = cliente.fechaDeNacimiento.ToString("dd/MM/yyyy");
            lblValueEmail.Text = cliente.email;
            lblValueTelPrincipal.Text = cliente.telefonoPrincipal;
            lblValueTelSecundario.Text = cliente.telefonoSecundario;
            lblValueCalle.Text = cliente.direccion.calle;
            lblValueAltura.Text = cliente.direccion.altura;
            lblValuePiso.Text = cliente.direccion.piso;
            lblValueProcincia.Text = cliente.direccion.provincia;
            lblValueLocalidad.Text = cliente.direccion.localidad;
            lblValueDepto.Text = cliente.direccion.depto;
            lblValueCodigoPostal.Text = cliente.direccion.codigoPostal;
            lblValueNodoRed.Text = cliente.direccion.nodoRed.ToString();
            lblValuePlanServicio.Text = cliente.servicio.servicePlan.descripcion;
            lblValueEstado.Text = cliente.servicio.estado.ToString();
            string dispositivos = "";
            if (cliente.servicio.dispositivos != null)
            {
                foreach (Dispositivo dispositivo in cliente.servicio.dispositivos)
                {
                    dispositivos += dispositivo.ToString() + "\n";
                }
            }
            lblValueDispositivos.Text = dispositivos;
            HabilitarControlesBusqueda(false);
            listarUltimosTickets();
        }

        private void LimpiarDatos() {
            lblValueNodoRed.Text = "";
            lblValueAltura.Text = "";
            lblValuePiso.Text = "";
            lblValueProcincia.Text = "";
            lblValueCalle.Text = "";
            lblValueLocalidad.Text = "";
            lblValueDepto.Text = "";
            lblValueCodigoPostal.Text = "";
            lblValueTelPrincipal.Text = "";
            lblValueTelSecundario.Text = "";
            lblValueEmail.Text = "";
            lblValueFNacimiento.Text = "";
            lblValueNombre.Text = "";
            lblValueApellido.Text = "";
            lblValueDNI.Text = "";
            lblValueNroCliente.Text = "";
            lblValueEstado.Text = "";
            lblValuePlanServicio.Text = "";
            lblValueDispositivos.Text = "";
            btnVerTicket.Enabled = false;
            listBoxTicketCliente.DataSource = null;
            listBoxTicketCliente.Items.Clear();
            HabilitarControlesBusqueda(true);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            clienteSeleccionado = null;
            LimpiarDatos();


        }

        private void HabilitarControlesBusqueda(bool habilitar)
        {
            btnBuscar.Enabled = habilitar;
            btnModificar.Enabled = !habilitar;
            btnLimpiar.Enabled = !habilitar;
            textBoxNroClienteID.Enabled = habilitar;
            textBoxDNICliente.Enabled = habilitar;
            if (habilitar)
            {
                textBoxDNICliente.Text = "";
                textBoxNroClienteID.Text = "";
            }
            listBoxTicketCliente.Enabled = !habilitar;            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmGestorClientes frmGestorClientes = new frmGestorClientes(clienteSeleccionado);
            frmGestorClientes.ShowDialog();
            clienteSeleccionado = clienteBLL.GetById(clienteSeleccionado.Id);
            CompletarDatosCliente(clienteSeleccionado);
        }

        private void btnCrearTicket_Click(object sender, EventArgs e)
        {
            frmDialogCrearTicket frmDialogCrearTickets = new frmDialogCrearTicket(clienteSeleccionado);
            frmDialogCrearTickets.ShowDialog();
            if (frmDialogCrearTickets.DialogResult == DialogResult.OK)
            {
                
                MessageBox.Show(Tag("TicketCreado") + frmDialogCrearTickets.ticketCreado.Id.ToString(), Tag("tagInfoTitle"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                ticketSeleccionado = frmDialogCrearTickets.ticketCreado;
                frmTicket frmticket = new frmTicket(ticketSeleccionado);
                frmticket.ShowDialog();
                listarUltimosTickets();

            }
        }

        void listarUltimosTickets() {
            listBoxTicketCliente.DataSource = null;
            if (clienteSeleccionado != null)
            {
                List<Ticket> tickets = ticketBLL.GetTicketsByCliente(clienteSeleccionado);
                if (tickets != null && tickets.Count > 0)
                {
                    listBoxTicketCliente.DataSource = tickets;
                    listBoxTicketCliente.Enabled = true;

                }
                else
                {
                    listBoxTicketCliente.DataSource = null;
                    listBoxTicketCliente.Items.Add(Tag("ClienteSinTickets"));
                    listBoxTicketCliente.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show(Tag("ClienteNoSeleccionado"), Tag("tagInfoTitle"), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }


        Ticket ticketSeleccionado;
        private void listBoxTicketCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ticketSeleccionado = (Ticket)listBoxTicketCliente.SelectedItem;
            }
            catch (Exception)
            {
                ticketSeleccionado = null;
            }

            if (ticketSeleccionado != null)
            {
                btnVerTicket.Enabled = true;
            }
            else
            {
                btnVerTicket.Enabled = false;
            }
        }

        private void btnVerTicket_Click(object sender, EventArgs e)
        {
            if (ticketSeleccionado != null)
            {
                frmTicket frmticket = new frmTicket(ticketSeleccionado);
                frmticket.ShowDialog();
                listarUltimosTickets();

            }
            else
            {
                MessageBox.Show(Tag("TicketNoSeleccionado"), Tag("tagInfoTitle"), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmSoporteClientes_Enter(object sender, EventArgs e)
        {
            if (clienteSeleccionado != null)
            {
                CompletarDatosCliente(clienteSeleccionado);
            }
        }

        private void textBoxDNICliente_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
