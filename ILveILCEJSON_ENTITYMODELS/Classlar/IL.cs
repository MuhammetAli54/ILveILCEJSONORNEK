using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILveILCEJSON_ENTITYMODELS.Classlar
{
    public class IL
    {
        //C# Property kurallarına göre IL isimli class'ı oluşturduk.
        //JSONIL class deserialize olunca oradaki dataları IL class'ında türeteceğimiz nesneye aktaracağız.
        public string ILAdi { get; set; }
        public byte PlakaKodu { get; set; }
        public List<String> ILceleri { get; set; }
    }
}
