using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BLL;
using SERV.MultiIdioma;

namespace GUI
{
    public partial class frmABMIdiomas : Form
    {
        IdiomaBLL IdiomaBLL;

        public frmABMIdiomas()
        {
            IdiomaBLL = new IdiomaBLL();
            InitializeComponent();
        }
        

        private void frmABMIdiomas_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }

        private void ActualizarGrilla() {
            listBoxIdiomas.DataSource = IdiomaBLL.GetAll();
            listBoxIdiomas.DisplayMember = "Nombre";

        }

        private void btnNuevoIdioma_Click(object sender, EventArgs e)
        {
            try
            {
                IdiomaBLL.Create(new Idioma() { Nombre = textBoxNuevoIdioma.Text });
                MessageBox.Show("Idioma Creado Correctamente");
                textBoxNuevoIdioma.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Crear Idioma: " + ex.Message);

            }            
            ActualizarGrilla();

        }

        private void listBoxIdiomas_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxModificarIdioma.Text = ((Idioma)listBoxIdiomas.SelectedItem).Nombre;
        }

        private void btnGuardarIdioma_Click(object sender, EventArgs e)
        {
            if (textBoxModificarIdioma.Text != "")
            {
                Idioma idioma = (Idioma)listBoxIdiomas.SelectedItem;
                idioma.Nombre = textBoxModificarIdioma.Text;
                try
                {
                    IdiomaBLL.Update(idioma);
                    MessageBox.Show("Idioma Modificado Correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al Modificar Idioma: " + ex.Message);
                }
                ActualizarGrilla();
            }
        }

        private void btnEliminarIdioma_Click(object sender, EventArgs e)
        {
            Idioma idioma = (Idioma)listBoxIdiomas.SelectedItem;
            try
            {
                //Messagebox confirmacion
                if (MessageBox.Show("Todas las traducciones serán irrecuperables. \nEsta seguro que desea eliminar el idioma " + idioma.Nombre, "Eliminar Idioma", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    IdiomaBLL.Delete(idioma);
                    MessageBox.Show("Idioma Eliminado Correctamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Eliminar Idioma: " + ex.Message);
            }
            ActualizarGrilla();
        }
    }
}
