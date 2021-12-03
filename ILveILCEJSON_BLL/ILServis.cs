using ILveILCEJSON_ENTITYMODELS.Classlar;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ILveILCEJSON_BLL
{
    public class ILServis
    {
        private string JsonString = string.Empty; //field
        public ILServis()
        {
            VeriKaynaginaBaglan();
        }
        private void VeriKaynaginaBaglan()
        {
            using (WebClient istemci = new WebClient())
            {
             byte [] data=  istemci.DownloadData(@"C:\Users\ECR_EXCALIBUR_G770\source\repos\ILveILCEORNEK\belediyeler.json");

                //Json dosyasındaki ş ç ü gibi harfler çevrilirken bozulma yaşanabiliyor. Biz Encoding UTF8 kullanırsak
                // bütün dillere göre çözümleme sunar.
                JsonString = Encoding.UTF8.GetString(data);
            }
        }
        public List<IL> IlleriGetir()
        {
            List<IL> ILListesi = new List<IL>();

            // data ILJson  classından alınacak. Oradaki property'ler küçük harfli. Çünkü json dosyasında küçük harfle yazmışlar

            var jsonData = JsonConvert.DeserializeObject<List<ILJson>>(JsonString);

            //Alınan data bizim sistemimizdeki IL class'ına aktarılacak.
            foreach (var item in jsonData)
            {
                ILListesi.Add(
                    new IL()
                    {
                        ILAdi = item.il,
                        PlakaKodu = Convert.ToByte(item.plaka),
                        ILceleri = item.ilceleri

                    });
                    
            }

            return ILListesi;
        }

    }
   
}
