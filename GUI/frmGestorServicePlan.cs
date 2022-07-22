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
using BE;
using BLL;
using SERV.MultiIdioma;

namespace GUI
{
    public partial class frmGestorServicePlan : Form, IIdiomaObserver
    {
        ServicePlanBLL servicePlanBLL;
        TraduccionBLL traduccionBLL;
        
        List<Traduccion> traducciones;
        public frmGestorServicePlan()
        {
            servicePlanBLL = new ServicePlanBLL();
            traduccionBLL = new TraduccionBLL();
            InitializeComponent();
        }

        public void ActualizarIdioma(Idioma idioma)
        {
            traducciones = traduccionBLL.GetAllByIdioma(idioma);
            try
            {
                this.Text = traducciones.Find(x => x.etiqueta.Nombre == "frmGestorServicePlan").traduccion;
                btnNuevo.Text = traducciones.Find(x => x.etiqueta.Nombre == "btnNuevo").traduccion;
                btnGuardar.Text = traducciones.Find(x => x.etiqueta.Nombre == "btnGuardar").traduccion;
                btnEliminar.Text = traducciones.Find(x => x.etiqueta.Nombre == "btnEliminar").traduccion;
                lblId.Text = traducciones.Find(x => x.etiqueta.Nombre == "lblId").traduccion;
                lblServicePlanTitle.Text = traducciones.Find(x => x.etiqueta.Nombre == "lblServicePlanTitle").traduccion;
                lblDescripcion.Text = traducciones.Find(x => x.etiqueta.Nombre == "lblDescripcion").traduccion;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontraron/ Faltan traducciones para el idioma seleccionado");

            }
        }

        private void frmGestorServicePlan_Load(object sender, EventArgs e)
        {
            Session.SuscribirObservador(this);
            ActualizarIdioma(Session.GetSession().usuario?.idioma ?? Session.defaultIdioma);
            CargarServicePlans();
        }

        private void CargarServicePlans()
        {
            try { 
                listBoxServicePlan.DataSource = servicePlanBLL.GetAll();
                listBoxServicePlan.DisplayMember = "descripcion";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void listBoxServicePlan_SelectedIndexChanged(object sender, EventArgs e)
        {
            ServicePlan servicePlan = (ServicePlan)listBoxServicePlan.SelectedItem;
            if (servicePlan != null)
            {
                textBoxIdServicePlan.Text = servicePlan.Id.ToString();
                textBoxServicePlanDescripcion.Text = servicePlan.descripcion;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            listBoxServicePlan.SelectedItem = null;
            textBoxIdServicePlan.Text = "";
            textBoxServicePlanDescripcion.Text = "";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (textBoxServicePlanDescripcion.Text == "")
            {
                MessageBox.Show(Tag("msgErrorDescripcion"));
                return;
            }

            try
            {
                if (listBoxServicePlan.SelectedItem == null)
                {
                    ServicePlan servicePlan = new ServicePlan();
                    servicePlan.descripcion = textBoxServicePlanDescripcion.Text;
                    servicePlanBLL.Create(servicePlan);
                    MessageBox.Show(Tag("tagServicePlanCreado"), Tag("tagInfoTitle"), MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    ServicePlan servicePlan = (ServicePlan)listBoxServicePlan.SelectedItem;
                    servicePlan.descripcion = textBoxServicePlanDescripcion.Text;
                    servicePlanBLL.Update(servicePlan);
                    MessageBox.Show(Tag("tagServicePlanActualizado"), Tag("tagInfoTitle"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            CargarServicePlans();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (listBoxServicePlan.SelectedItem == null)
            {
                MessageBox.Show(Tag("msgErrorSeleccionarServicePlan"));
                return;
            }
            try
            {
                if (MessageBox.Show(Tag("msgConfirmarEliminarServicePlan"), Tag("tagInfoTitle"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ServicePlan servicePlan = (ServicePlan)listBoxServicePlan.SelectedItem;
                    servicePlanBLL.Delete(servicePlan);
                    MessageBox.Show(Tag("tagServicePlanEliminado"), Tag("tagInfoTitle"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            CargarServicePlans();
        }
    }
}
