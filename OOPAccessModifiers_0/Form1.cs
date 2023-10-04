using OOPAccessModifiers_0.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPAccessModifiers_0
{
  


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        /*
         
                          Access Modifiers (Erişim Belirtecleri)

        public,internal,protected internal , protected, private

        public : Başında yazıldıgı yapının her yere erişiminin oldugunu belirtir(Proje icerisinden veya proje dısarısından fark etmez)

        internal : Basında yazıldı yapının sadece bulundugu proje icerisinde her yere erişiminin oldugunu belirtir...

        private : Yazıldığı yapının sadece kendi bulundugu yapı icerisinden erişilebilecegini belirtir(Baska hicbir yere, kendi proje icerisinde bile cıkamaz)...
         
        Local alanın icerisindeki yapılara erişim belirteci yazamazsınız...
         
        
        Biz erişim belirteci yazabilecegimiz bir yerde bir erişim belirteci yazmazsak C#, ilgili alanı kontrol eder ve ilgili alanda tanımladıgınız yapının o alanda alabilecegi en kısıtlayıcı erişim belirteci hangisiyse otomatik olarak verir...


        Namespace alanında direkt tanımlanan bir yapının (erişim belirteci yazılmadan tanımlanan bir yapının) erişim belirteci minimum internal olabilir...Global alanda tanımlanabilecek erişim belirteci minimum private'tir...

        **Namespace alanında direkt tanımlanan hicbir yapının basına erişim belirteci olarak private,protected,protected internal yazamazsınız...ONlar sadece public veya internal alabilirler...En kapsayıcı erişim belirteci public'tir...Ondan sonra internal gelir...Sonra protected internal, protected sonra private...
        *
        *Yapı İkonları => 
        *Lila renkli küp => Metot demektir
        *İngiliz Anahtarı => Property
        *Turuncu geometrik şekiller => class
        *Mavi dikdörtgen prizması => Global degişken (field)
        *Parantezler icerisindeki dikdörtgen prizması => Local degişken (local variable)

        **Erişim Belirtecleri ikonları => Yapı ikonlarının altında cıkan kücük ikonlar
        *
        *private => kilit şeklinde ikon
        *internal => kalp şeklinde ikon
        *protected/protected internal => Yıldız şeklinde ikon
        *public : ikon cıkmaz( zaten local alanda erişim belirteci olamaz)
        *
        *Private erişim belirteci ogeler sadece iclerinde bulundukları yapı icerisinden erişilebilirler...Yapı dısından hicbir yerden erişilemezler
         
         */

         int a = 2;
        
      
   

        private void Form1_Load(object sender, EventArgs e)
        {
            //Egitmen egt = new Egitmen();
             
           
           
           
        }
    }
}
