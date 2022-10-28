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
    public partial class frmLogsRealTime : Form, IIdiomaObserver
    {
        public frmLogsRealTime()
        {
            InitializeComponent();
        }

        private void frmLogsRealTime_Load(object sender, EventArgs e)
        {

            Session.SuscribirObservador(this);
            ActualizarIdioma(Session.GetSession().usuario?.idioma ?? Session.defaultIdioma);
            bitacoraBLL = BitacoraBLL.GetInstance();
            CargarLogs();
        }


        Func<string, string> Tag = IdiomaUtils.Tag;
        public void ActualizarIdioma(Idioma idioma)
        {
            IdiomaUtils.traducciones = new TraduccionBLL().GetAllByIdioma(idioma);
            this.Text = Tag("frmLogsRealTime");
            btnStartStop.Text = Tag("btnStartlogsRealTime");

        }

        BitacoraBLL bitacoraBLL;

        public void CargarLogs() {
            dataGridViewLogs.DataSource = bitacoraBLL.getLastNLogs(100);
            dataGridViewLogs.Columns["Id"].DisplayIndex = 0;
            //adjust width
            dataGridViewLogs.Columns["Id"].Width = 50;
            dataGridViewLogs.Columns["Level"].Width = 50;
            dataGridViewLogs.Columns["User"].Width = 70;
            dataGridViewLogs.Columns["Message"].Width = 300;
            

        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
                btnStartStop.Text = Tag("btnStartlogsRealTime");
            }
            else
            {
                timer1.Start();
                btnStartStop.Text = Tag("btnStoplogsRealTime");
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CargarLogs();
        }
    }
}
