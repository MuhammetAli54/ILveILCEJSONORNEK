using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ILveILCEJSONORNEK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void iLSorgulamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Açık bir form varsa kapatılacak.
            if (this.ActiveMdiChild!=null)
            {
                this.ActiveMdiChild.Hide();
            }
            FormILSorgulama formIlSorgulama = new FormILSorgulama();
            formIlSorgulama.MdiParent = this;
            formIlSorgulama.Show();
            // form içinde form boyutlarında göstermesi için ayarlama yap
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void iLCESorgulamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild!=null)
            {
                this.ActiveMdiChild.Hide();
            }

            FormILEAitILceleriSorgulama frmIlce = new FormILEAitILceleriSorgulama();
            frmIlce.MdiParent = this;
            frmIlce.Show();

            this.LayoutMdi(MdiLayout.TileVertical);
        }
    }
}
