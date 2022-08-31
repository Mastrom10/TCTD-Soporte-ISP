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
    public partial class InteraccionControl : UserControl, IIdiomaObserver
    {

        
        InteraccionTicket interaccion;
        public InteraccionControl(InteraccionTicket interaccion)
        {
            InitializeComponent();
            this.interaccion = interaccion;
            ActualizarIdioma(Session.GetSession().usuario?.idioma ?? Session.defaultIdioma);
        }

        Func<string, string> Tag = IdiomaUtils.Tag;
        public void ActualizarIdioma(Idioma idioma)
        {
            IdiomaUtils.traducciones = new TraduccionBLL().GetAllByIdioma(idioma);
            lblAccion.Text = Tag("lblAccion");
            lblEmpleado.Text = Tag("lblEmpleado");
            lblFecha.Text = Tag("lblFecha");
            lblMotivo.Text = Tag("lblMotivo");
            lblObservacion.Text = Tag("lblObservacion");
        }

        private void InteraccionControl_Load(object sender, EventArgs e)
        {
            Session.SuscribirObservador(this);
            ActualizarIdioma(Session.GetSession().usuario?.idioma ?? Session.defaultIdioma);

            lblAccionValue.Text = interaccion.accion;
            lblMotivoValue.Text = interaccion.motivo;
            lblObservacionValue.Text = interaccion.observacion;
            lblFechaValue.Text = interaccion.fecha.ToString("g");
            lblEmpleadoValue.Text = interaccion.empleado.NombreCompleto.ToString();
        }
    }
}
