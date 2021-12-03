using ILveILCEJSON_BLL;
using ILveILCEJSON_ENTITYMODELS.Classlar;
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
    public partial class FormILEAitILceleriSorgulama : Form
    {
        public FormILEAitILceleriSorgulama()
        {
            InitializeComponent();
        }

        //Global alan
        ILServis ilServisim = new ILServis();
        ILILceServis ilceServis = new ILILceServis();
        private void FormILEAitILceleriSorgulama_Load(object sender, EventArgs e)
        {
            comboBoxILLER.DataSource = ilServisim.IlleriGetir();
            comboBoxILLER.DisplayMember = "ILAdi";
            comboBoxILLER.ValueMember = "PlakaKodu";
        }

        private void comboBoxILLER_SelectedIndexChanged(object sender, EventArgs e)
        {
            // içindeki değer değiştiğinde bu metot tetiklenecek
            IL secilenIL = comboBoxILLER.SelectedItem as IL;

            //BLL'in bilgileri getirmesine ihtiyacım var.
            // BLL'de öyle bir metot olmalı ki... il ismini parametre olarak verince bana ilçeye dair detay bilgileri versin.

          List<ILILceBilgileri> sehreAitILcelerListem = ilceServis.ILAdinaGoreILceleriGetir(secilenIL.ILAdi);
            listView1.Items.Clear();

            foreach (var item in sehreAitILcelerListem)
            {
                //her birini listviewitem olarak tutup

                ListViewItem li = new ListViewItem();
                li.Text = item.Ismi;
                li.Tag = item;
                li.SubItems.Add(item.Tel);
                li.SubItems.Add(item.Mail);

                //listView içine ekleyeceğim
                listView1.Items.Add(li);

            }

        }
    }
}
