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
    public partial class frmDialogDerivarTicket : Form, IIdiomaObserver
    {

        Ticket ticketActual = null;

        public EstadoTicket estadoTicket;
        public string motivo;
        public string franjaHoraria;
        
        public frmDialogDerivarTicket(Ticket ticket)
        {
            InitializeComponent();
            ticketActual = ticket;
        }

        private void frmDialogDerivarTicket_Load(object sender, EventArgs e)
        {
            Session.SuscribirObservador(this);
            ActualizarIdioma(Session.GetSession().usuario?.idioma ?? Session.defaultIdioma);
           
            comboBoxTipoDerivacion.DataSource = Enum.GetValues(typeof(EstadoTicket))
                                                    .Cast<EstadoTicket>()
                                                    .Where(v => v == EstadoTicket.DerivadoTecnico || v == EstadoTicket.DerivadoBackoffice)
                                                    .ToList();

            //create array with 3 timeframes
            comboBoxFranjaHoraria.DataSource = new List<string>() 
                                                    {
                                                        "Mañana de 08 a 12hs",
                                                        "Tarde de 12 a 17hs",
                                                        "Noche de 17 a 20hs"
                                                    };



        }

        Func<string, string> Tag = IdiomaUtils.Tag;
        public void ActualizarIdioma(Idioma idioma)
        {
            IdiomaUtils.traducciones = new TraduccionBLL().GetAllByIdioma(idioma);
            this.Text = Tag("frmDialogDerivarTicket");
            lblTituloDerivacion.Text = Tag("lblTituloDerivacion");
            lblTipoDerivacion.Text = Tag("lblTipoDerivacion");
            lblMotivoEscalamiento.Text = Tag("lblMotivoEscalamiento");
            btnCancelar.Text = Tag("btnCancelar");
            btnDerivar.Text = Tag("btnDerivar");





        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //close dialog cancel
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnDerivar_Click(object sender, EventArgs e)
        {
            //comboBoxTipoDerivacion.SelectedItem as EstadoTicket
            estadoTicket = (EstadoTicket)comboBoxTipoDerivacion.SelectedItem;
            motivo = textBoxMotivoEscalamiento.Text;
            franjaHoraria = comboBoxFranjaHoraria.SelectedItem.ToString();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

