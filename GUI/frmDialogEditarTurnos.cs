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
    public partial class frmDialogEditarTurnos : Form, IIdiomaObserver
    {

        TurnoBLL turnoBLL;

        
        public frmDialogEditarTurnos()
        {
            InitializeComponent();
            turnoBLL = new TurnoBLL();
        }

        private void frmDialogEditarTurnos_Load(object sender, EventArgs e)
        {
            Session.SuscribirObservador(this);
            ActualizarIdioma(Session.GetSession().usuario?.idioma ?? Session.defaultIdioma);


            comboBoxFranjaHoraria.DataSource = FranjaHoraria.GetValues(typeof(FranjaHoraria));
        }

        Func<string, string> Tag = IdiomaUtils.Tag;
        public void ActualizarIdioma(Idioma idioma)
        {
            IdiomaUtils.traducciones = new TraduccionBLL().GetAllByIdioma(idioma);
            this.Text = Tag("lblEditarTurnoTitulo");
            lblEditarTurnoTitulo.Text = Tag("lblEditarTurnoTitulo");
            lblFranjaHoraria.Text = Tag("lblFranjaHoraria");
            lblFecha.Text = Tag("lblFecha");
            lblTurnosTomados.Text = Tag("lblTurnosTomados");
            lblTurnosDisponibles.Text = Tag("lblTurnosDisponibles");
            btnGuardar.Text = Tag("btnGuardar");

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            CargarInfo();
        }

        void CargarInfo() {
            
            DateTime fecha = dtpFecha.Value;
            FranjaHoraria franjaHoraria = (FranjaHoraria)comboBoxFranjaHoraria.SelectedItem;

            int[] datos = turnoBLL.GetTurnosTomadosByFechayFranjaHoraria(fecha, franjaHoraria);

            lblTurnosTomadosValue.Text = datos[0].ToString();
            textBoxTurnosDisponibles.Text = datos[1].ToString();

        }

        private void comboBoxFranjaHoraria_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarInfo();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int cantidad = int.Parse(textBoxTurnosDisponibles.Text);
            DateTime fecha = dtpFecha.Value;
            FranjaHoraria franjaHoraria = (FranjaHoraria)comboBoxFranjaHoraria.SelectedItem;
            try
            {
                turnoBLL.SetTurnosDisponibles(fecha, franjaHoraria, cantidad);
                MessageBox.Show(Tag("msgTurnosModificados"), Tag("tagInfoTitle"), MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
