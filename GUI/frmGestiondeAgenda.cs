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
    public partial class frmGestiondeAgenda : Form, IIdiomaObserver
    {

        TurnoBLL turnoBLL;
        public frmGestiondeAgenda()
        {
            InitializeComponent();
            turnoBLL = new TurnoBLL();
        }

        private void frmGestiondeAgenda_Load(object sender, EventArgs e)
        {
            Session.SuscribirObservador(this);
            ActualizarIdioma(Session.GetSession().usuario?.idioma ?? Session.defaultIdioma);

            dtpHasta.Value = DateTime.Today.AddDays(7);
            MostrarTurnosProximaSemana();

        }

        Func<string, string> Tag = IdiomaUtils.Tag;
        public void ActualizarIdioma(Idioma idioma)
        {
            IdiomaUtils.traducciones = new TraduccionBLL().GetAllByIdioma(idioma);
            this.Text = Tag("frmGestiondeAgenda");
            lblGestiondeAgendatitulo.Text = Tag("lblGestiondeAgendatitulo");
            groupBoxBusqueda.Text = Tag("groupBoxBusqueda");
            btnVerTurnos.Text = Tag("btnVerTurnos");
            lblDesde.Text = Tag("lblDesde");
            lblHasta.Text = Tag("lblHasta");
            btnEditarTurnos.Text = Tag("btnEditarTurnos");

        }

        private void btnVerTurnos_Click(object sender, EventArgs e)
        {
            dataGridViewTurnos.DataSource = turnoBLL.GetTurnosByFechaRange(dtpDesde.Value, dtpHasta.Value);
        }

        void MostrarTurnosProximaSemana() {
           
            dataGridViewTurnos.DataSource = turnoBLL.GetTurnosProximaSemana();

        }

        private void btnEditarTurnos_Click(object sender, EventArgs e)
        {
            frmDialogEditarTurnos frmDialogEditarTurnos = new frmDialogEditarTurnos();
            frmDialogEditarTurnos.ShowDialog();
            MostrarTurnosProximaSemana();
        }
    }
}
