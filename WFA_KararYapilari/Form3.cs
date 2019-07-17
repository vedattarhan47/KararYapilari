using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_KararYapilari
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }


        Random rnd = new Random();
        private void Form3_Load(object sender, EventArgs e)
        {
            //Formun ilk acilis aninda 8 haneli rastgele bir sayı lblRastgeleKarakterler adli label'a yazdirilacak ve kullanicidan butona bastigi anda textbox'taki yazıyla label'daki yazının karsilastirmasi yapilacak. Eger karsilastirma olumsuz ise lblKalanHakkimiz'deki deger bir azaltılacak. 
            //Eger kullanici 5 defa hatali giris yaparsa button'un aktiflik ozelligi kapatilacak...
            //Her hatali giriste yeni bir rastgele sayi turetilmelidir...

            //  rnd.Next() =   rnd.Next(0, int.MaxValue) => geriye size maximum döneceği değer, int.MaxValue -1 değeridir.

            //rnd.Next(50) = rnd.Next(0,50)  => maximum size 49 değerini teslim eder.

            //rnd.Next(1, 50) => size, 1 ile 49(dahil) değer aralığında sayı teslim eder.

            //int sayi = rnd.Next(-100, 1000);

            lblRastgeleKarakterler.Text = rnd.Next(10000000, 100000000).ToString(); // 99999999
        }
    }
}
