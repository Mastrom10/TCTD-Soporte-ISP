using System;
using System.Windows.Forms;


using BE;
using SERV;
using BLL;
using SERV.MultiIdioma;


namespace GUI
{
    public partial class frmLogsExplorer : Form, IIdiomaObserver
    {
        public frmLogsExplorer()
        {
            InitializeComponent();
        }

        private void frmLogsExplorer_Load(object sender, EventArgs e)
        {
            Session.SuscribirObservador(this);
            ActualizarIdioma(Session.GetSession().usuario?.idioma ?? Session.defaultIdioma);
            bitacoraBLL = BitacoraBLL.GetInstance();

            //comboBoxLogLevel with Level
            comboBoxLogLevel.DataSource = Enum.GetValues(typeof(LogLevel));
            dateTimePickerFrom.Value = DateTime.Today.AddDays(-7);
            dateTimePickerTo.Value = DateTime.Now.AddHours(2);

            CargarLogs(null);
        }

        Func<string, string> Tag = IdiomaUtils.Tag;
        public void ActualizarIdioma(Idioma idioma)
        {
            IdiomaUtils.traducciones = new TraduccionBLL().GetAllByIdioma(idioma);
            this.Text = Tag("frmLogsExplorer");
            lblTituloLogExplorer.Text = Tag("lblTituloLogExplorer");
            lblLevel.Text = Tag("lblLevel");
            lblFechaDesde.Text = Tag("lblFechaDesde");
            lblFechaHasta.Text = Tag("lblFechaHasta");
            lblCantidadRegistros.Text = Tag("lblCantidadRegistros");
            lblUsuario.Text = Tag("lblUsuario");
            lblMensajecontiene.Text = Tag("lblMensajecontiene");
            lblDetalleContiene.Text = Tag("lblDetalleContiene");
            lblClase.Text = Tag("lblClase");
            lblMetodo.Text = Tag("lblMetodo");
            buttonBuscar.Text = Tag("buttonBuscar");

        }

        BitacoraBLL bitacoraBLL;


        public void CargarLogs(LogSearchingCriteria criteria)
        {
            if (criteria == null)
            {
                dataGridViewLogs.DataSource = bitacoraBLL.getLastNLogs(100);
            }
            else {
                dataGridViewLogs.DataSource = bitacoraBLL.searchLogs(criteria);
            }
           
            dataGridViewLogs.Columns["Id"].DisplayIndex = 0;
            //adjust width
            dataGridViewLogs.Columns["Id"].Width = 50;
            dataGridViewLogs.Columns["Level"].Width = 50;
            dataGridViewLogs.Columns["User"].Width = 70;
            dataGridViewLogs.Columns["Message"].Width = 300;


        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {

            LogSearchingCriteria criteria = new LogSearchingCriteria();
            if (comboBoxLogLevel.SelectedItem != null)
            {
                criteria.Level = (LogLevel)comboBoxLogLevel.SelectedItem;
            }
            criteria.TimeFrom = dateTimePickerFrom.Value;
            criteria.TimeTo = dateTimePickerTo.Value;
            if ((int)numericUpDownLimit.Value > 0)
            {
                criteria.Limit = (int)numericUpDownLimit.Value;
            }
            if (textBoxUsuario.Text != "")
            {
                criteria.User = textBoxUsuario.Text;
            }
            if (textBoxClase.Text != "")
            {
                criteria.Class = textBoxClase.Text;
            }
            if (textBoxMetodo.Text != "")
            {
                criteria.Method = textBoxMetodo.Text;
            }
            if (textBoxMensajeContiene.Text != "")
            {
                criteria.Message = textBoxMensajeContiene.Text;
            }
            if (textBoxDetalleContiene.Text != "")
            {
                criteria.Details = textBoxDetalleContiene.Text;
            }
            CargarLogs(criteria);


        }
    }
}
