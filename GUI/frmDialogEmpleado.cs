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
    public partial class frmDialogEmpleado : Form, IIdiomaObserver
    {
        public frmDialogEmpleado()
        {
            InitializeComponent();
        }

        private void frmDialogEmpleado_Load(object sender, EventArgs e)
        {
            Session.SuscribirObservador(this);
            ActualizarIdioma(Session.GetSession().usuario?.idioma ?? Session.defaultIdioma);

        }

        Func<string, string> Tag = IdiomaUtils.Tag;
        public void ActualizarIdioma(Idioma idioma)
        {
            IdiomaUtils.traducciones = new TraduccionBLL().GetAllByIdioma(idioma);
            this.Text = Tag("lblTituloEmpleados");
            lblIdEmpleado.Text = Tag("lblIdEmpleado");
            lblNombre.Text = Tag("lblNombre");
            lblApellido.Text = Tag("lblApellido");
            lblNroRepresentante.Text = Tag("lblNroRepresentante");
            lblTipoEmpleado.Text = Tag("lblTipoEmpleado");
            btnCancelar.Text = Tag("btnCancelar");
            btnGuardar.Text = Tag("btnGuardar");
        }

        
    }
}
