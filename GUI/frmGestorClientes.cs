using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SERV;
using SERV.MultiIdioma;
using BE;
using BLL;

namespace GUI
{
    public partial class frmGestorClientes : Form, IIdiomaObserver
    {
        TraduccionBLL traduccionBLL;
        List<Traduccion> traducciones;

        ClienteBLL clienteBLL;
        NodoRedBLL nodoRedBLL;
        ServicePlanBLL servicePlanBLL;


        Cliente clienteSeleccionado;
        public frmGestorClientes()
        {
            traduccionBLL = new TraduccionBLL();
            clienteBLL = new ClienteBLL();
            nodoRedBLL = new NodoRedBLL();
            servicePlanBLL = new ServicePlanBLL();
            InitializeComponent();
        }

        public void ActualizarIdioma(Idioma idioma)
        {
            traducciones = traduccionBLL.GetAllByIdioma(idioma);
            try
            {
                this.Text = traducciones.Find(x => x.etiqueta.Nombre == "lblTituloGestorClientes").traduccion;
                lblTituloGestorClientes.Text = traducciones.Find(x => x.etiqueta.Nombre == "lblTituloGestorClientes").traduccion;
                groupBoxBuscarCliente.Text = traducciones.Find(x => x.etiqueta.Nombre == "groupBoxBuscarCliente").traduccion;
                lblNroCliente.Text = traducciones.Find(x => x.etiqueta.Nombre == "lblNroCliente").traduccion;
                lblDNICliente.Text = traducciones.Find(x => x.etiqueta.Nombre == "lblDNICliente").traduccion;
                btnBuscar.Text = traducciones.Find(x => x.etiqueta.Nombre == "btnBuscar").traduccion;
                lblNombre.Text = traducciones.Find(x => x.etiqueta.Nombre == "lblNombre").traduccion;
                lblApellido.Text = traducciones.Find(x => x.etiqueta.Nombre == "lblApellido").traduccion;
                labelNroCliente.Text = traducciones.Find(x => x.etiqueta.Nombre == "labelNroCliente").traduccion;
                lblDNI.Text = traducciones.Find(x => x.etiqueta.Nombre == "lblDNI").traduccion;
                lblFechaNacimiento.Text = traducciones.Find(x => x.etiqueta.Nombre == "lblFechaNacimiento").traduccion;
                lblTelPrincipal.Text = traducciones.Find(x => x.etiqueta.Nombre == "lblTelPrincipal").traduccion;
                lblTelSecundario.Text = traducciones.Find(x => x.etiqueta.Nombre == "lblTelSecundario").traduccion;
                lblEmail.Text = traducciones.Find(x => x.etiqueta.Nombre == "lblEmail").traduccion;
                lblClienteNododeRed.Text = traducciones.Find(x => x.etiqueta.Nombre == "lblClienteNododeRed").traduccion;
                lblClienteProvincia.Text = traducciones.Find(x => x.etiqueta.Nombre == "lblClienteProvincia").traduccion;
                lblClienteLocalidad.Text = traducciones.Find(x => x.etiqueta.Nombre == "lblClienteLocalidad").traduccion;
                lblClienteCodigoPostal.Text = traducciones.Find(x => x.etiqueta.Nombre == "lblClienteCodigoPostal").traduccion;
                lblClienteDepto.Text = traducciones.Find(x => x.etiqueta.Nombre == "lblClienteDepto").traduccion;
                lblClienteCalle.Text = traducciones.Find(x => x.etiqueta.Nombre == "lblClienteCalle").traduccion;
                lblClienteAltura.Text = traducciones.Find(x => x.etiqueta.Nombre == "lblClienteAltura").traduccion;
                lblClientePiso.Text = traducciones.Find(x => x.etiqueta.Nombre == "lblClientePiso").traduccion;
                lblEstadoServicio.Text = traducciones.Find(x => x.etiqueta.Nombre == "lblEstadoServicio").traduccion;
                lblServicePlan.Text = traducciones.Find(x => x.etiqueta.Nombre == "lblServicePlan").traduccion;
                labelDispositivos.Text = traducciones.Find(x => x.etiqueta.Nombre == "labelDispositivos").traduccion;
                groupBoxDomicilio.Text = traducciones.Find(x => x.etiqueta.Nombre == "groupBoxDomicilio").traduccion;
                groupBoxServicio.Text = traducciones.Find(x => x.etiqueta.Nombre == "groupBoxServicio").traduccion;
                groupBoxInfoCliente.Text = traducciones.Find(x => x.etiqueta.Nombre == "groupBoxInfoCliente").traduccion;
                groupBoxDatosContacto.Text = traducciones.Find(x => x.etiqueta.Nombre == "groupBoxDatosContacto").traduccion;
                buttonGestionarDispositivos.Text = traducciones.Find(x => x.etiqueta.Nombre == "buttonGestionarDispositivos").traduccion;
                buttonNuevo.Text = traducciones.Find(x => x.etiqueta.Nombre == "buttonNuevo").traduccion;
                buttonGuadar.Text = traducciones.Find(x => x.etiqueta.Nombre == "buttonGuadar").traduccion;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontraron/ Faltan traducciones para el idioma seleccionado");

            }
        }
        public string Tag(string tag)
        {
            string traduccion = tag;
            try
            {
                if (traducciones != null)
                {
                    traduccion = traducciones.Find(x => x.etiqueta.Nombre == tag).traduccion;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontraron/ Faltan traducciones para la etiqueta " + tag);
            }
            return traduccion;
        }



        private void frmGestorClientes_Load(object sender, EventArgs e)
        {
            Session.SuscribirObservador(this);
            ActualizarIdioma(Session.GetSession().usuario?.idioma ?? Session.defaultIdioma);

            try
            {
                comboBoxNodosDeRed.DataSource = nodoRedBLL.GetAll();
                comboBoxNodosDeRed.DisplayMember = "nombre";
                comboBoxNodosDeRed.Text = "";

                comboBoxEstadoServicio.DataSource = Enum.GetValues(typeof(EstadoServicio));
                comboBoxEstadoServicio.Text = "";

                comboBoxServicePlan.DataSource = servicePlanBLL.GetAll();
                comboBoxServicePlan.DisplayMember = "descripcion";
                comboBoxServicePlan.Text = "";

                buttonGestionarDispositivos.Enabled = false;
                listBoxDispositivos.Enabled = false;


                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxNroClienteID.Text == "" && textBoxDNICliente.Text == "")
                {
                    MessageBox.Show(Tag("SinCriterioBusqueda"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (textBoxNroClienteID.Text != "")
                {
                    int nroCliente = int.Parse(textBoxNroClienteID.Text);
                    Cliente cliente = clienteBLL.GetById(nroCliente);
                    if (cliente != null)
                    {
                        CompletarDatosCliente(cliente);
                        clienteSeleccionado = cliente;
                    }
                    else
                    {
                        MessageBox.Show(Tag("ClienteNoEncontrado"), Tag("tagInfoTitle"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    string dni = textBoxDNICliente.Text;
                    Cliente cliente = clienteBLL.getByDNI(dni);
                    if (cliente != null)
                    {
                        CompletarDatosCliente(cliente);
                        clienteSeleccionado = cliente;
                    }
                    else
                    {
                        MessageBox.Show(Tag("ClienteNoEncontrado"), Tag("tagInfoTitle"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void CompletarDatosCliente(Cliente cliente)
        {
            textBoxNroCliente.Text = cliente.Id.ToString();
            textBoxNombre.Text = cliente.nombre;
            textBoxApellido.Text = cliente.apellido;
            textBoxDNI.Text = cliente.dni;
            dateTimePickerFechaNacimiento.Value = cliente.fechaDeNacimiento;
            textBoxTelPrincipal.Text = cliente.telefonoPrincipal;
            textBoxTelSecundario.Text = cliente.telefonoSecundario;
            textBoxEmail.Text = cliente.email;
            textBoxClienteCalle.Text = cliente.direccion.calle;
            textBoxtextBoxClienteAltura.Text = cliente.direccion.altura;
            textBoxClientePiso.Text = cliente.direccion.piso;
            textBoxClienteDepto.Text = cliente.direccion.depto;
            textBoxClienteLocalidad.Text = cliente.direccion.localidad;
            textBoxClienteProvincia.Text = cliente.direccion.provincia;
            textBoxClienteCodigoPostal.Text = cliente.direccion.codigoPostal;
            comboBoxNodosDeRed.Text = cliente.direccion.nodoRed.nombre;
            comboBoxEstadoServicio.Text = cliente.servicio?.estado.ToString();
            comboBoxServicePlan.Text = cliente.servicio?.servicePlan.descripcion;
            listBoxDispositivos.DataSource = cliente.servicio?.dispositivos;
            listBoxDispositivos.DisplayMember = "macAdress";
            buttonGestionarDispositivos.Enabled = true;
            listBoxDispositivos.Enabled = true;
        }



        private void textBoxDNICliente_TextChanged(object sender, EventArgs e)
        {
            textBoxNroClienteID.Text = "";
        }

        private void textBoxNroClienteID_TextChanged(object sender, EventArgs e)
        {
            textBoxDNICliente.Text = "";
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            clienteSeleccionado = null;
            LimpiarDatosCliente();
        }

        public void LimpiarDatosCliente()
        {
            textBoxNroCliente.Text = "";
            textBoxNombre.Text = "";
            textBoxApellido.Text = "";
            textBoxDNI.Text = "";
            dateTimePickerFechaNacimiento.Value = DateTime.Now;
            textBoxTelPrincipal.Text = "";
            textBoxTelSecundario.Text = "";
            textBoxEmail.Text = "";
            textBoxClienteCalle.Text = "";
            textBoxtextBoxClienteAltura.Text = "";
            textBoxClientePiso.Text = "";
            textBoxClienteDepto.Text = "";
            textBoxClienteLocalidad.Text = "";
            textBoxClienteProvincia.Text = "";
            textBoxClienteCodigoPostal.Text = "";
            comboBoxNodosDeRed.Text = "";
            comboBoxEstadoServicio.Text = "";
            comboBoxServicePlan.Text = "";
            listBoxDispositivos.DataSource = null;

            buttonGestionarDispositivos.Enabled = false;
            listBoxDispositivos.Enabled = false;


        }

        private void buttonGuadar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente;
                if (clienteSeleccionado == null)
                {
                    cliente = new Cliente();
                    cliente.direccion = new Direccion();
                    cliente.direccion.nodoRed = new NodoRed();
                    cliente.servicio = new Servicio();
                    cliente.nombre = textBoxNombre.Text;
                    cliente.apellido = textBoxApellido.Text;
                    cliente.dni = textBoxDNI.Text;
                    cliente.fechaDeNacimiento = dateTimePickerFechaNacimiento.Value;
                    cliente.telefonoPrincipal = textBoxTelPrincipal.Text;
                    cliente.telefonoSecundario = textBoxTelSecundario.Text;
                    cliente.email = textBoxEmail.Text;
                    cliente.direccion.calle = textBoxClienteCalle.Text;
                    cliente.direccion.altura = textBoxtextBoxClienteAltura.Text;
                    cliente.direccion.piso = textBoxClientePiso.Text;
                    cliente.direccion.depto = textBoxClienteDepto.Text;
                    cliente.direccion.localidad = textBoxClienteLocalidad.Text;
                    cliente.direccion.provincia = textBoxClienteProvincia.Text;
                    cliente.direccion.codigoPostal = textBoxClienteCodigoPostal.Text;
                    cliente.direccion.nodoRed = comboBoxNodosDeRed.SelectedItem as NodoRed;
                    cliente.servicio.estado = comboBoxEstadoServicio.Text != "" ? (EstadoServicio)Enum.Parse(typeof(EstadoServicio), comboBoxEstadoServicio.Text) : EstadoServicio.Indefinido;
                    cliente.servicio.servicePlan = comboBoxServicePlan.SelectedItem as ServicePlan;
                    clienteBLL.Create(cliente);
                }
                else
                {
                    cliente = clienteSeleccionado;
                    cliente.nombre = textBoxNombre.Text;
                    cliente.apellido = textBoxApellido.Text;
                    cliente.dni = textBoxDNI.Text;
                    cliente.fechaDeNacimiento = dateTimePickerFechaNacimiento.Value;
                    cliente.telefonoPrincipal = textBoxTelPrincipal.Text;
                    cliente.telefonoSecundario = textBoxTelSecundario.Text;
                    cliente.email = textBoxEmail.Text;
                    cliente.direccion.calle = textBoxClienteCalle.Text;
                    cliente.direccion.altura = textBoxtextBoxClienteAltura.Text;
                    cliente.direccion.piso = textBoxClientePiso.Text;
                    cliente.direccion.depto = textBoxClienteDepto.Text;
                    cliente.direccion.localidad = textBoxClienteLocalidad.Text;
                    cliente.direccion.provincia = textBoxClienteProvincia.Text;
                    cliente.direccion.codigoPostal = textBoxClienteCodigoPostal.Text;
                    cliente.direccion.nodoRed = comboBoxNodosDeRed.SelectedItem as NodoRed;
                    cliente.servicio.estado = comboBoxEstadoServicio.Text != "" ? (EstadoServicio)Enum.Parse(typeof(EstadoServicio), comboBoxEstadoServicio.Text) : EstadoServicio.Indefinido;
                    cliente.servicio.servicePlan = comboBoxServicePlan.SelectedItem as ServicePlan;
                    clienteBLL.Update(cliente);
                }
                CompletarDatosCliente(cliente);
                clienteSeleccionado = cliente;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void buttonGestionarDispositivos_Click(object sender, EventArgs e)
        {
            frmGestionDispositivosCliente frmGestionDispositivosCliente = new frmGestionDispositivosCliente(clienteSeleccionado);
            frmGestionDispositivosCliente.ShowDialog();
            clienteSeleccionado = clienteBLL.GetById(clienteSeleccionado.Id);
            CompletarDatosCliente(clienteSeleccionado);

        }
    }
}

