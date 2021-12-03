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
    public partial class FormILSorgulama : Form
    {
        public FormILSorgulama()
        {
            InitializeComponent();
        }

        ILServis ilServisim = new ILServis();
        ILILceServis ILILceServisim = new ILILceServis();
        private void FormILSorgulama_Load(object sender, EventArgs e)
        {
            // Form yüklenirken burası çalışacak
            //combobox'ın içerisine illeri getirdim
            comboBoxILSecimi.DataSource = ilServisim.IlleriGetir();
            comboBoxILSecimi.DisplayMember = "ILAdi";
            comboBoxILSecimi.ValueMember = "PlakaKodu";

            //ListView içini dolduracağız
           List<ILILceBilgileri> SehireAitBilgilerListesi = ILILceServisim.BilgileriGetir();

            foreach (var item in SehireAitBilgilerListesi)
            {
                ListViewItem deger = new ListViewItem()
                {
                    Text=item.Ismi,
                        Tag = item,
                };

                deger.SubItems.Add(item.Tel);
                deger.SubItems.Add(item.Faks);
                deger.SubItems.Add(item.Mail);
                deger.SubItems.Add(item.Web);

                //listview'e ekleme yapılacak.
                listView1.Items.Add(deger);
            }

            groupBoxIL.Enabled = false;
            groupBoxIL.Visible = false;
            //detay göster şeklinde sağ tık menüsü

        }

        private void btnsec_Click(object sender, EventArgs e)
        {
            //combobox'tan hangi ili seçtiyse onun bilgilerini listView'de görelim.

            IL secilenIL = (IL)comboBoxILSecimi.SelectedItem;

            //Linq ile şart yazıyorum 
            // where yazdık ---> verilen koşula göre bilgileri getirdik
            //FirstOrDefault ---> where'den dönen liste elemanlarından sadece birini alıyoruz.
           ILILceBilgileri secilenILBilgisi = ILILceServisim.BilgileriGetir().
                Where(x => x.Plaka == secilenIL.PlakaKodu)
                .FirstOrDefault();

            listView1.Items.Clear();
            ListViewItem deger = new ListViewItem();
            
                deger.Text = secilenILBilgisi.Ismi;
            deger.Tag = secilenILBilgisi;
            deger.SubItems.Add(secilenILBilgisi.Tel);
            deger.SubItems.Add(secilenILBilgisi.Faks);
            deger.SubItems.Add(secilenILBilgisi.Mail);
            deger.SubItems.Add(secilenILBilgisi.Web);
            listView1.Items.Add(deger);




        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void detayGosterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBoxIL.Visible = true;
            groupBoxIL.Enabled = true;

            ILILceBilgileri secilenIL = (ILILceBilgileri)listView1.FocusedItem.Tag;

            richTextBoxIL.Text = secilenIL.Bilgi;
        }
    }
}
