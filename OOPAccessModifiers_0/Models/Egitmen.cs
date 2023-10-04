using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAccessModifiers_0.Models
{


    public class Egitmen
    {
        public string Isim { get; set; }
        public string SoyIsim { get; set; }

        public Egitmen()
        {
            _a = "asasd";
        }


        string _a; //dikkat ederseniz _a isimli degişkenimize bir erişim belirteci keyword'u yazılmadığı icin burada private olmustur...Private olan bir yapıya da kendi bulunduğu yer dısında erişemezsiniz...

        void Deneme()
        {

        }


    }
}
