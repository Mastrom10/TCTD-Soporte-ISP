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
    public partial class frmDialogCrearTicket : Form, IIdiomaObserver
    {

        TraduccionBLL traduccionBLL;
        List<Traduccion> traducciones;

        TicketBLL ticketBLL;

        Cliente clienteSeleccionado = null;

        public Ticket ticketCreado = null;

        public frmDialogCrearTicket(Cliente cliente)
        {
            InitializeComponent();
            clienteSeleccionado = cliente;
            ticketBLL = new TicketBLL();
        }

        private void frmDialogCrearTicket_Load(object sender, EventArgs e)
        {
            traduccionBLL = new TraduccionBLL();
            Session.SuscribirObservador(this);
            ActualizarIdioma(Session.GetSession().usuario?.idioma ?? Session.defaultIdioma);
            comboBoxPrioridad.DataSource = Enum.GetValues(typeof(PrioridadTicket));
            comboBoxPrioridad.SelectedIndex = 0;
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
            this.Text = Tag("frmDialogCrearTicket");
            lblTituloCrearTicket.Text = Tag("frmDialogCrearTicket");
            lblTitulo.Text = Tag("lblTitulo");
            lblPrioridad.Text = Tag("lblPrioridad");
            btnCancelar.Text = Tag("btnCancelar");
            btnCrearTicket.Text = Tag("btnCrearTicket");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //CloseDialog
            this.DialogResult = DialogResult.Cancel;
            this.Close();
            
        }

        private void btnCrearTicket_Click(object sender, EventArgs e)
        {
            if (textBoxTituloTicket.Text == "")
            {
                MessageBox.Show(Tag("msgErrorTitulo"));
                return;
            }

            Ticket ticket = new Ticket();
            ticket.cliente = clienteSeleccionado;
            ticket.prioridad = (PrioridadTicket)comboBoxPrioridad.SelectedItem;
            ticket.titulo = textBoxTituloTicket.Text;

            try
            {
                ticketBLL.Create(ticket);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.ticketCreado = ticket;
            Console.WriteLine("Ticket creado: " + ticket.ToString());

            this.DialogResult = DialogResult.OK;
            this.Close();

            //console log ticket

        }
    }
}
