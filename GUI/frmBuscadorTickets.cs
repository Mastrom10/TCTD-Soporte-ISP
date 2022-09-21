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
    public partial class frmBuscadorTickets : Form, IIdiomaObserver
    {

        TicketBLL ticketBLL;
        public frmBuscadorTickets()
        {
            InitializeComponent();
            ticketBLL = new TicketBLL();
        }

        private void frmTicketDeBackOffice_Load(object sender, EventArgs e)
        {
            Session.SuscribirObservador(this);
            ActualizarIdioma(Session.GetSession().usuario?.idioma ?? Session.defaultIdioma);

            comboBoxEstado.DataSource = Enum.GetValues(typeof(EstadoTicket));

            CargarTickets(EstadoTicket.Abierto);


        }

        Func<string, string> Tag = IdiomaUtils.Tag;
        public void ActualizarIdioma(Idioma idioma)
        {
            IdiomaUtils.traducciones = new TraduccionBLL().GetAllByIdioma(idioma);
            this.Text = Tag("frmBuscadorTickets");
            lblTituloBuscadorTickets.Text = Tag("frmBuscadorTickets");
            btnRecuperarTicket.Text = Tag("btnRecuperarTicket");
            groupBoxCriterioBusqueda.Text = Tag("groupBoxCriterioBusqueda");



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

        
        void CargarTickets(EstadoTicket estado) {
            listBoxticketsDerivados.DataSource = null;
            try
            {
                List<Ticket> tickets = ticketBLL.GetTicketsByEstado(estado);



                if (tickets != null && tickets.Count > 0)
                {
                    listBoxticketsDerivados.DataSource = tickets;
                    listBoxticketsDerivados.Enabled = true;
                    btnRecuperarTicket.Enabled = true;

                }
                else
                {
                    listBoxticketsDerivados.DataSource = null;
                    listBoxticketsDerivados.Items.Add(Tag("SinTicketsDerivadosEnEstado") + " " + estado.ToString());
                    listBoxticketsDerivados.Enabled = false;
                    btnRecuperarTicket.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnRecuperarTicket_Click(object sender, EventArgs e)
        {
            if (ticketSeleccionado != null)
            {
                ticketSeleccionado.estado = EstadoTicket.EnProceso;

                frmTicket frmticket = new frmTicket(ticketSeleccionado);
                frmticket.ShowDialog();
                CargarTickets(EstadoTicket.Abierto);

            }
            else
            {
                MessageBox.Show(Tag("TicketNoSeleccionado"), Tag("tagInfoTitle"), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void comboBoxEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarTickets((EstadoTicket)comboBoxEstado.SelectedItem);

        }
    }
}
