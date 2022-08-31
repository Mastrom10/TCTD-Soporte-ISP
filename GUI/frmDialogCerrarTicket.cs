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
    public partial class frmDialogCerrarTicket : Form, IIdiomaObserver
    {


        public string DetalleCierre;
        public frmDialogCerrarTicket()
        {
            InitializeComponent();
        }

        private void frmDialogCerrarTicket_Load(object sender, EventArgs e)
        {
            Session.SuscribirObservador(this);
            ActualizarIdioma(Session.GetSession().usuario?.idioma ?? Session.defaultIdioma);

        }

        
        Func<string, string> Tag = IdiomaUtils.Tag;
        public void ActualizarIdioma(Idioma idioma)
        {
            IdiomaUtils.traducciones = new TraduccionBLL().GetAllByIdioma(idioma);
            this.Text = Tag("lblTituloCerrarTicket");
            btnCerrarTicket.Text = Tag("btnCerrarTicket");
            btnCancelar.Text = Tag("btnCancelar");
            lblTituloCerrarTicket.Text = Tag("lblTituloCerrarTicket");
            lblDetalleCerreTicket.Text = Tag("lblDetalleCerreTicket");
        }

        
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
            
        }

        private void btnCerrarTicket_Click(object sender, EventArgs e)
        {
            DetalleCierre = textBoxDetalleCierre.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
