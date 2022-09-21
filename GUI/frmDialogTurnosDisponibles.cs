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
    public partial class frmDialogTurnosDisponibles : Form, IIdiomaObserver
    {

        TurnoBLL turnoBLL;

        public Turno turnoSeleccionado= null;

        public frmDialogTurnosDisponibles()
        {
            InitializeComponent();
            turnoBLL = new TurnoBLL();
        }

        private void frmDialogTurnosDisponibles_Load(object sender, EventArgs e)
        {

            Session.SuscribirObservador(this);
            ActualizarIdioma(Session.GetSession().usuario?.idioma ?? Session.defaultIdioma);

            CargarTurnos();

                
        }

        Func<string, string> Tag = IdiomaUtils.Tag;
        public void ActualizarIdioma(Idioma idioma)
        {
            IdiomaUtils.traducciones = new TraduccionBLL().GetAllByIdioma(idioma);
            this.Text = Tag("lblTituloTurnosDisponibles");
            lblTituloTurnosDisponibles.Text = Tag("lblTituloTurnosDisponibles");



        }

        void CargarTurnos() {
            List<Turno> turnos = turnoBLL.GetTurnosDisponibles();
            if (turnos.Count == 0)
            {
                listBoxTurnosDisponibles.DataSource = null;
                listBoxTurnosDisponibles.Items.Add("No hay turnos disponibles");
            }
            else
            {
                listBoxTurnosDisponibles.DataSource = turnos;
                listBoxTurnosDisponibles.DisplayMember = "ToString";
            }           
            
        }

        private void listBoxTurnosDisponibles_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if some value is selected
            if (listBoxTurnosDisponibles.SelectedIndex != -1)
            {
                btnSeleccionar.Enabled = true;
            }
            else
            {
                btnSeleccionar.Enabled = false;
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (listBoxTurnosDisponibles.SelectedIndex != -1)
            {
                turnoSeleccionado = (Turno)listBoxTurnosDisponibles.SelectedItem;
                //TODO Reserva temporal de turnos
                CargarTurnos();
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
