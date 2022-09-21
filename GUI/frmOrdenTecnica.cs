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
    public partial class frmOrdenTecnica : Form, IIdiomaObserver
    {

        Ticket ticketActual = null;
        public OrdenTecnica ordenTecnica = null;

        Turno turnoSeleccionado;

        ClienteBLL clienteBLL;
        OrdenTecnicaBLL ordenTecnicaBLL;



        public frmOrdenTecnica(Ticket ticket)
        {
            InitializeComponent();
            ticketActual = ticket;
            clienteBLL = new ClienteBLL();
            ordenTecnicaBLL = new OrdenTecnicaBLL();

        }

        private void frmOrdenTecnica_Load(object sender, EventArgs e)
        {
            Session.SuscribirObservador(this);
            ActualizarIdioma(Session.GetSession().usuario?.idioma ?? Session.defaultIdioma);

            MostrarInfoClienteTicket();
            //TipoOrdenTecnica
            comboBoxTipoService.DataSource = Enum.GetValues(typeof(TipoOrdenTecnica));


        }
        Func<string, string> Tag = IdiomaUtils.Tag;
        public void ActualizarIdioma(Idioma idioma)
        {
            IdiomaUtils.traducciones = new TraduccionBLL().GetAllByIdioma(idioma);
            this.Text = Tag("frmOrdenTecnica");
            if (this.Modal == true)
            {
                lblTituloOrdenTecnica.Text = Tag("lblTituloOrdenTecnicaDialog");
            }
            else {
                lblTituloOrdenTecnica.Text = Tag("lblTituloOrdenTecnicaShow");

            }

            lblNroTicket.Text = Tag("lblNroTicket");
            lblNroOrdenTecnica.Text = Tag("lblNroOrdenTecnica");

            groupBoxinfoClientes.Text = Tag("groupBoxinfoClientes");
            labelNroCliente.Text = Tag("labelNroCliente");
            lblFullNombre.Text = Tag("lblFullNombre");


            lblClienteNododeRed.Text = Tag("lblClienteNododeRed");
            lblClienteProvincia.Text = Tag("lblClienteProvincia");
            lblClienteLocalidad.Text = Tag("lblClienteLocalidad");
            lblClienteCodigoPostal.Text = Tag("lblClienteCodigoPostal");
            lblClienteDepto.Text = Tag("lblClienteDepto");
            lblClienteCalle.Text = Tag("lblClienteCalle");
            lblClienteAltura.Text = Tag("lblClienteAltura");
            lblClientePiso.Text = Tag("lblClientePiso");

            lblTIpoService.Text = Tag("lblTIpoService");
            lblTurno.Text = Tag("lblTurno");
            btnAsignarTurno.Text = Tag("btnAsignarTurno");
            lblNotas.Text = Tag("lblNotas");

            btnConfirmar.Text = Tag("btnConfirmar");

        }


        void MostrarInfoClienteTicket() {

            lvlNroTIcketValue.Text = ticketActual.Id.ToString();

            lblValueNroCliente.Text = ticketActual.cliente.Id.ToString();
            lblValueNombre.Text = ticketActual.cliente.nombre + " " + ticketActual.cliente.apellido;

            Cliente cliente = ticketActual.cliente;
            //Direccion:
            lblValueCalle.Text = cliente.direccion.calle;
            lblValueAltura.Text = cliente.direccion.altura;
            lblValuePiso.Text = cliente.direccion.piso;
            lblValueProcincia.Text = cliente.direccion.provincia;
            lblValueLocalidad.Text = cliente.direccion.localidad;
            lblValueDepto.Text = cliente.direccion.depto;
            lblValueCodigoPostal.Text = cliente.direccion.codigoPostal;
            lblValueNodoRed.Text = cliente.direccion.nodoRed.ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmGestorClientes frmGestorClientes = new frmGestorClientes(ticketActual.cliente);
            frmGestorClientes.ShowDialog();
            ticketActual.cliente = clienteBLL.GetById(ticketActual.cliente.Id);
            MostrarInfoClienteTicket();
        }

        private void btnAsignarTurno_Click(object sender, EventArgs e)
        {
            frmDialogTurnosDisponibles frmDialogTurnosDisponibles = new frmDialogTurnosDisponibles();
            frmDialogTurnosDisponibles.ShowDialog();
            if (frmDialogTurnosDisponibles.DialogResult == DialogResult.OK && frmDialogTurnosDisponibles.turnoSeleccionado != null)
            {
                turnoSeleccionado = frmDialogTurnosDisponibles.turnoSeleccionado;
                lblTurnoValue.Text = "Id: " + turnoSeleccionado.Id.ToString() + " - " + turnoSeleccionado.ToString();
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (turnoSeleccionado == null)
            {
                MessageBox.Show(Tag("errorTurnoNoSeleccionado"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboBoxTipoService.SelectedItem == null)
            {
                MessageBox.Show(Tag("errorTipoOrdenTecnicaNoSeleccionado"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ordenTecnica = new OrdenTecnica();
            ordenTecnica.ticket = ticketActual;
            ordenTecnica.turno = turnoSeleccionado;
            ordenTecnica.tipoOrdenTecnica = (TipoOrdenTecnica)comboBoxTipoService.SelectedItem;
            ordenTecnica.notas = textBoxNotas.Text;
            ordenTecnicaBLL.Create(ordenTecnica);
            MessageBox.Show(Tag("ordenTecnicaCreada") + ordenTecnica.Id.ToString(), "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lblNroOrdenTecnicaValue.Text = ordenTecnica.Id.ToString();
            btnConfirmar.Enabled = false;
            btnAsignarTurno.Enabled = false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (ordenTecnica == null)
            {
                if (MessageBox.Show(Tag("confirmarCerrarSinCrearOrdenTecnica"), "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.DialogResult = DialogResult.Cancel;
                    this.Close();
                }

            }
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
