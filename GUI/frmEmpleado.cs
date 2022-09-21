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
    public partial class frmEmpleado : Form, IIdiomaObserver
    {
        public frmEmpleado()
        {
            InitializeComponent();
        }

        private void frmEmpleado_Load(object sender, EventArgs e)
        {
            Session.SuscribirObservador(this);
            ActualizarIdioma(Session.GetSession().usuario?.idioma ?? Session.defaultIdioma);

        }


        Func<string, string> Tag = IdiomaUtils.Tag;
        public void ActualizarIdioma(Idioma idioma)
        {
            IdiomaUtils.traducciones = new TraduccionBLL().GetAllByIdioma(idioma);
            this.Text = Tag("lblTituloEmpleados");
            lblTituloEmpleados.Text = Tag("lblTituloEmpleados");
            btnNuevoEmpleado.Text = Tag("btnNuevoEmpleado");
            btnModificar.Text = Tag("btnModificar");
            btnEliminar.Text = Tag("btnEliminar");
            btnSalir.Text = Tag("btnSalir");

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
