using ILveILCEJSON_ENTITYMODELS.Classlar;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ILveILCEJSON_BLL
{
    public class ILILceServis
    {
        private string JsonString = string.Empty;
        ILServis ilServisi = new ILServis();
        public ILILceServis()
        {
            VeriKaynaginaBaglan();
        }
        private void VeriKaynaginaBaglan()
        {
            using (WebClient istemci = new WebClient())
            {
                byte[] data = istemci.DownloadData(@"C:\Users\ECR_EXCALIBUR_G770\source\repos\ILveILCEORNEK\belediyelerfull.json");
                JsonString = Encoding.UTF8.GetString(data);
            }
        }

        public List<ILILceBilgileri> BilgileriGetir()
        {
            List<ILILceBilgileri> liste = new List<ILILceBilgileri>();

            JObject j = JObject.Parse(JsonString);
            List<string> illerim = ilServisi.IlleriGetir().Select(x=> x.ILAdi).ToList();

            illerim = illerim.Select(x => DilIslemleri.TurkceKarakterleriIngilizceyeCevir(x.ToLower())).ToList();

            foreach (var item in illerim)
            {
                //her bir il için bilgileri belediyelerfull.json'dan çekeceğiz.
                var data = j.SelectToken(item).SelectToken("il");
                ILILceBilgileri detayliBilgi = new ILILceBilgileri();
                detayliBilgi.Plaka = Convert.ToByte(data["plaka"].ToObject<string>());
                detayliBilgi.Tel = data["belediye-tel"].ToObject<string>();
                detayliBilgi.Faks = data["belediye-faks"].ToObject<string>();
                detayliBilgi.Ismi = data["belediye-ismi"].ToObject<string>();
                detayliBilgi.Mail = data["belediye-mail"]==null ? "" : data["belediye-mail"].ToObject<string>();
                detayliBilgi.Web = data["belediye-web"]==null ? "" : data["belediye-web"].ToObject<string>();
                detayliBilgi.Nufus = data["nufus"].ToObject<string>();
                detayliBilgi.Alankodu = data["alankodu"]==null ? "" : data["alankodu"].ToObject<string>();
                detayliBilgi.Bolge = data["bolge"].ToObject<string>();
                detayliBilgi.Bilgi = data["bilgi"].ToObject<string>();

                liste.Add(detayliBilgi);
            }

            return liste;
        }

        public List<ILILceBilgileri> ILAdinaGoreILceleriGetir(string ilAdi)
        {
            List<ILILceBilgileri> liste = new List<ILILceBilgileri>();

            JObject j = JObject.Parse(JsonString);

            List<string> ilclerListem2 = ilServisi.IlleriGetir().Single(x => x.ILAdi == ilAdi).ILceleri;

            ilclerListem2 = ilclerListem2.Select(x => DilIslemleri.TurkceKarakterleriIngilizceyeCevir(x.ToLower())).ToList();

            ilAdi = DilIslemleri.TurkceKarakterleriIngilizceyeCevir(ilAdi.ToLower());

            foreach (var item in ilclerListem2)
            {
                var data = j.SelectToken(ilAdi.ToLower()).SelectToken(item);
                if (data!=null)
                {
                    ILILceBilgileri bilgiler = new ILILceBilgileri();
                    bilgiler.Ismi = data["belediye-ismi"] == null ? "" : data["belediye-ismi"].ToObject<string>();
                    bilgiler.Tel = data["belediye-tel"]==null ? "" : data["belediye-tel"].ToObject<string>();
                    bilgiler.Faks = data["belediye-faks"]==null ? "" : data["belediye-faks"].ToObject<string>();
                    bilgiler.Mail = data["belediye-mail"] == null ? "" : data["belediye-mail"].ToObject<string>();
                    bilgiler.Web = data["belediye-web"] == null ? "" : data["belediye-web"].ToObject<string>();
                    bilgiler.Nufus = data["nufus"]==null ? "" : data["nufus"].ToObject<string>();
                    bilgiler.Bilgi = data["bilgi"]==null ? "" : data["bilgi"].ToObject<string>();
                    liste.Add(bilgiler);
                }

            }


            return liste;
        }
    }
}
