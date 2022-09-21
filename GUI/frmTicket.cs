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
    public partial class frmTicket : Form, IIdiomaObserver
    {

        Ticket ticketActual;
        TicketBLL ticketBLL;
        InteraccionTicketBLL interaccionTicketBLL;

        public frmTicket()
        {
            InitializeComponent();
        }
        public frmTicket(Ticket ticket )
        {
            InitializeComponent();
            ticketBLL = new TicketBLL();
            ticketActual = ticket;
            interaccionTicketBLL = new InteraccionTicketBLL();
        }

        Func<string, string> Tag = IdiomaUtils.Tag;
        public void ActualizarIdioma(Idioma idioma)
        {
            IdiomaUtils.traducciones = new TraduccionBLL().GetAllByIdioma(idioma);
            this.Text = Tag("lblTituloTicket") + " " + (ticketActual?.Id == null ? "" : ticketActual.Id.ToString());
            groupBoxinfoClientes.Text = Tag("groupBoxinfoClientes");
            labelNroCliente.Text = Tag("labelNroCliente");
            lblFullNombre.Text = Tag("lblFullNombre");
            lblTitulo.Text = Tag("lblTitulo");
            lblFechaCreacion.Text = Tag("lblFechaCreacion");
            lblCreadoPor.Text = Tag("lblCreadoPor");
            lblFechaCierre.Text = Tag("lblFechaCierre");
            lblPrioridad.Text = Tag("lblPrioridad");
            lblUltimaModificacion.Text = Tag("lblUltimaModificacion");
            lblDescripcion.Text = Tag("lblDescripcion");
            btnGuardar.Text = Tag("btnGuardar");
            btnEditar.Text = Tag("btnEditar");
            btnDerivar.Text = Tag("btnDerivar");
            btnCerrarTicket.Text = Tag("btnCerrarTicket");

        }


        void CargarInteracciones() {
            if (ticketActual == null || ticketActual.interacciones == null)
                return;

            //clear interactions
            flowLayoutPanel1.Controls.Clear();
            ticketActual.interacciones = interaccionTicketBLL.GetAllByTicket(ticketActual);
            for (int i = ticketActual.interacciones.Count; i > 0; i--)
            {
                InteraccionTicket interaccion = ticketActual.interacciones[i-1];
                InteraccionControl control = new InteraccionControl(interaccion);
                flowLayoutPanel1.Controls.Add(control);
            }
        }

        void MostrarInfoTicket() {
            if (ticketActual == null)
            {
                MessageBox.Show(Tag("errorTicketNoSeleccionado"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblTicketNumeroValue.Text = ticketActual.Id.ToString();
            lblValueNroCliente.Text = ticketActual.cliente.Id.ToString();
            lblValueNombre.Text = ticketActual.cliente.nombre + " " + ticketActual.cliente.apellido;
            textBoxTitulo.Text = ticketActual.titulo;
            lblEstadoValue.Text = ticketActual.estado.ToString();
            lblCreadoPorValue.Text = ticketActual.empleado.NombreCompleto;
            comboBoxPrioridad.Text = ticketActual.prioridad.ToString();
            lblFechaCreacionValue.Text = ticketActual.fechaCreacion.ToString("dd/MM/yyyy HH:mm");
            if (ticketActual.fechaCierre != DateTime.MinValue)
                lblFechaCierreValue.Text = ticketActual.fechaCierre.ToString("dd/MM/yyyy HH:mm");
            else
                lblFechaCierreValue.Text = "---";
            lblFechaUltimaModificacionValue.Text = ticketActual.fechaUltimaModificacion.ToString("dd/MM/yyyy HH:mm");
            textBoxDescripcion.Text = ticketActual.descripcion;
            CargarInteracciones();
        }

        void HabilitarEdicion() {
            //enable textBoxTitulo, comboBoxPrioridad, textBoxDescripcion, btnGuardar
            textBoxTitulo.Enabled = true;
            comboBoxPrioridad.Enabled = true;
            textBoxDescripcion.ReadOnly = false;
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
            
        }

        void DeshabilitarEdicion() {
            //disable textBoxTitulo, comboBoxPrioridad, textBoxDescripcion, btnGuardar
            if (ticketActual.estado == EstadoTicket.Abierto || ticketActual.estado == EstadoTicket.EnProceso)
            { 
            textBoxTitulo.Enabled = false;
            comboBoxPrioridad.Enabled = false;
            textBoxDescripcion.ReadOnly = true;
            btnGuardar.Enabled = false;
            btnEditar.Enabled = true;
            } else
            {
                DeshabilitarTodo();
            }
        }

        void DeshabilitarTodo() {
            //disable textBoxTitulo, comboBoxPrioridad, textBoxDescripcion, btnGuardar, btnEditar, btnDerivar, btnCerrarTicket
            textBoxTitulo.Enabled = false;
            comboBoxPrioridad.Enabled = false;
            textBoxDescripcion.ReadOnly = true;
            btnGuardar.Enabled = false;
            btnEditar.Enabled = false;
            btnDerivar.Enabled = false;
            btnCerrarTicket.Enabled = false;
        }
        

        private void frmTicket_Load(object sender, EventArgs e)
        {
            Session.SuscribirObservador(this);
            ActualizarIdioma(Session.GetSession().usuario?.idioma ?? Session.defaultIdioma);
          
            comboBoxPrioridad.DataSource = Enum.GetValues(typeof(PrioridadTicket));
            ticketBLL.RegistrarMostrarTicket(ticketActual);
            MostrarInfoTicket();
            DeshabilitarEdicion();


        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            HabilitarEdicion();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ticketActual == null)
            {
                MessageBox.Show(Tag("errorTicketNoSeleccionado"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Ticket ticketActualizado = (Ticket)ticketActual.Clone();
            ticketActualizado.titulo = textBoxTitulo.Text;
            ticketActualizado.prioridad = (PrioridadTicket)comboBoxPrioridad.SelectedItem;
            ticketActualizado.descripcion = textBoxDescripcion.Text;
            ticketActualizado.fechaUltimaModificacion = DateTime.Now;


            try
            {
                ticketBLL.Update(ticketActual, ticketActualizado);
                MessageBox.Show(Tag("msgTicketActualizado"), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DeshabilitarEdicion();
            MostrarInfoTicket();
        }

        private void btnDerivarTicket_Click(object sender, EventArgs e)
        {
            frmDialogDerivarTicket frmDialogDerivarTicket = new frmDialogDerivarTicket(ticketActual);
            frmDialogDerivarTicket.ShowDialog();
            if (frmDialogDerivarTicket.DialogResult == DialogResult.OK)
            {
                
                

                InteraccionTicket interaccion = new InteraccionTicket();
                interaccion.idTicket = ticketActual.Id;
                interaccion.empleado = Session.GetSession().usuario.empleado;
                interaccion.fecha = DateTime.Now;
                interaccion.accion = "Cambio Estado " + ticketActual.estado.ToString() + " --> " + frmDialogDerivarTicket.estadoTicket.ToString();
                interaccion.motivo = "Escalamiento de ticket";
                interaccion.observacion = "Horario Contacto: " + frmDialogDerivarTicket.franjaHoraria + Environment.NewLine + frmDialogDerivarTicket.motivo ;
                interaccionTicketBLL.Create(interaccion);

                ticketActual.estado = frmDialogDerivarTicket.estadoTicket;
                ticketActual.fechaUltimaModificacion = DateTime.Now;
                 ticketBLL.Update(ticketActual);   
                
                MessageBox.Show(Tag("msgTicketDerivado"), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DeshabilitarEdicion();
                MostrarInfoTicket();
            }
        }

        private void btnCerrarTicket_Click(object sender, EventArgs e)
        {
            frmDialogCerrarTicket frmdialogcerrarticket = new frmDialogCerrarTicket();
            frmdialogcerrarticket.ShowDialog();
            if (frmdialogcerrarticket.DialogResult == DialogResult.OK)
            {
                InteraccionTicket interaccion = new InteraccionTicket();
                interaccion.idTicket = ticketActual.Id;
                interaccion.empleado = Session.GetSession().usuario.empleado;
                interaccion.fecha = DateTime.Now;
                interaccion.accion = "Cambio Estado " + ticketActual.estado.ToString() + " --> " + EstadoTicket.Cerrado.ToString();
                interaccion.motivo = "Cierre de ticket";
                interaccion.observacion = frmdialogcerrarticket.DetalleCierre;
                interaccionTicketBLL.Create(interaccion);

                
                ticketActual.estado = EstadoTicket.Cerrado;
                ticketActual.fechaUltimaModificacion = DateTime.Now;
                ticketActual.fechaCierre = DateTime.Now;
                ticketBLL.Update(ticketActual);
                MessageBox.Show(Tag("msgTicketCerrado"), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MostrarInfoTicket();
                DeshabilitarEdicion();
            }

        }
    }
}
