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
    public partial class frmTicketDeBackOffice : Form, IIdiomaObserver
    {

        TicketBLL ticketBLL;
        public frmTicketDeBackOffice()
        {
            InitializeComponent();
            ticketBLL = new TicketBLL();
        }

        private void frmTicketDeBackOffice_Load(object sender, EventArgs e)
        {
            Session.SuscribirObservador(this);
            ActualizarIdioma(Session.GetSession().usuario?.idioma ?? Session.defaultIdioma);

            CargarTickets();


        }

        Func<string, string> Tag = IdiomaUtils.Tag;
        public void ActualizarIdioma(Idioma idioma)
        {
            IdiomaUtils.traducciones = new TraduccionBLL().GetAllByIdioma(idioma);
            this.Text = Tag("frmTicketDeBackOffice");
            lblTituloTicketsBackOffice.Text = Tag("lblTituloTicketsBackOffice");
            btnRecuperarTicket.Text = Tag("btnRecuperarTicket");




        }

        Ticket ticketSeleccionado;

        private void listBoxticketsDerivados_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ticketSeleccionado = (Ticket)listBoxticketsDerivados.SelectedItem;
                btnRecuperarTicket.Enabled = true;                
            }
            catch (Exception)
            {
                ticketSeleccionado = null;
                btnRecuperarTicket.Enabled = false;
            }
        }

        
        void CargarTickets() {
            listBoxticketsDerivados.DataSource = null;
            
            List<Ticket> tickets = ticketBLL.GetTicketsByEstado(EstadoTicket.DerivadoBackoffice);
            if (tickets != null && tickets.Count > 0)
            {
                listBoxticketsDerivados.DataSource = tickets;
                listBoxticketsDerivados.Enabled = true;
                btnRecuperarTicket.Enabled = true;

            }
            else
            {
                listBoxticketsDerivados.DataSource = null;
                listBoxticketsDerivados.Items.Add(Tag("SinTicketsDerivados"));
                listBoxticketsDerivados.Enabled = false;
                btnRecuperarTicket.Enabled = false;
            }
        }

        private void btnRecuperarTicket_Click(object sender, EventArgs e)
        {
            if (ticketSeleccionado != null)
            {
                ticketSeleccionado.estado = EstadoTicket.EnProceso;
                frmTicket frmticket = new frmTicket(ticketSeleccionado);
                frmticket.ShowDialog();
                CargarTickets();

            }
            else
            {
                MessageBox.Show(Tag("TicketNoSeleccionado"), Tag("tagInfoTitle"), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
