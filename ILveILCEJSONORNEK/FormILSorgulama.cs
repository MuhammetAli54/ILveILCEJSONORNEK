using ILveILCEJSON_BLL;
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
    public partial class FormILSorgulama : Form
    {
        public FormILSorgulama()
        {
            InitializeComponent();
        }

        ILServis ilServisim = new ILServis();
        private void FormILSorgulama_Load(object sender, EventArgs e)
        {
            // Form yüklenirken burası çalışacak
            comboBoxILSecimi.DataSource = ilServisim.IlleriGetir();
            comboBoxILSecimi.DisplayMember = "il";
        }
    }
}
