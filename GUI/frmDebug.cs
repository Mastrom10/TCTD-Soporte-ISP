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
using SERV.Serializacion;
using SERV;

namespace GUI
{
    public partial class frmDebug : Form
    {
        public frmDebug()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = LogSerializer.Serialize(Session.GetSession().usuario);
        }
    }
}
