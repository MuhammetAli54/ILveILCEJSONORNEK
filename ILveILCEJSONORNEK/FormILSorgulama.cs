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

        }

        private void btnsec_Click(object sender, EventArgs e)
        {
            //ILILceServis deneme = new ILILceServis();
            //deneme.BilgileriGetir();
        }
    }
}
