using System;
using System.Linq;
using System.Windows.Forms;

namespace WFA_KararYapilari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Form Load
        private void Form1_Load(object sender, EventArgs e)
        {
            /*
             Karşılaştırma Operatorleri

            <   Soldaki değerin, sağdaki değerden küçük olma durumu
            >   Soldaki değerin, sağdaki değerden büyük olma durumu
            <=  Soldaki değerin, sağdaki değerden küçük veya eşit olma durumu
            >=  Soldaki değerin, sağdaki değerden büyük veya eşit olma durumu
            ==  Soldaki değerin, sağdaki değere eşit olma durumu
            !=  Soldaki değerin, sağdaki değere eşit olmama durumu
            !   If bloğu içerisinde yer alan değeri olmuz alma durumu  
             */ 
             
            /*
              KARAR YAPILARI
              Uygulamanizin calismasi esnasinda farkli senaryolara gore farkli yonlendirmeler yapmaniz gerekebilir. Ornegin, kullanicidan gelen degerin araligina gore, uygulamadaki mantiksal islerinizin sonuclarina gore yonlendirmeler yapabiliriz. 
              3 temel karar yapısı karsimiza cikar => IF-ELSE ~ SWITCH-CASE ~ TERNARY OPERATORU
            */
        }
        #endregion

        #region Örnek 1
        private void BtnAdminKontrolu_Click(object sender, EventArgs e)
        {
            bool result = txtGirisAlani.Text == "admin";

            if (result)
            {
                MessageBox.Show("Giriş yaptınız");
            }
            else
            {
                MessageBox.Show("Kullanıcı Bilgilerinizi Kontrol Ediniz!");
            }
        }
        #endregion

        #region Örnek 2
        private void BtnNotKontrolu_Click(object sender, EventArgs e)
        {
            //Eger girilen not 0'dan kucukse "O'dan küçük bir not girişi yapamazsınız" 100'den buyukse "100'den büyük bir not girişi yapamazsınız" mesajini gostersin...


            // Parse metodu, string bir değeri ilgili veri tipine en hızlı çevirme imkanı sunar.

            // her sayısal veri tipinin kendine has parse metodu bulunmaktadır.

            //decimal.Parse
            //byte.Parse  gibi.


            try
            {
                int not = int.Parse(txtGirisAlani.Text);

                if (not < 0)
                {
                    MessageBox.Show("0'dan küçük not girişi yapamazsınız!");
                }
                else if (not > 100)
                {
                    MessageBox.Show("100'den büyük not girişi yapamazsınız!");
                }
                else
                {
                    MessageBox.Show("Notunuz: " + not);
                }
            }
            catch (Exception)
            {

            }
        }
        #endregion

        private void BtnCiftMiTekMi_Click(object sender, EventArgs e)
        {
            //textbox'dan girilen sayi cift ise "Sayı Çifttir" tek ise "Sayı Tektir" mesajini kullaniciya gosteriniz...
            int sayi = 0;
            bool result = int.TryParse(txtGirisAlani.Text, out sayi);
            if (result)
            {
                if (sayi % 2 == 0)
                {
                    MessageBox.Show("Sayı çifttir.");
                }
                else
                {
                    MessageBox.Show("Sayı tektir.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen sayısal veri giriniz!");
            }
        }

        private void BtnDegerKontrolu_Click(object sender, EventArgs e)
        {
            //Disaridan girilen kelimenin uzunlugu 8 karaktere esit ya da buyukse kayit onaylandi, degilse daha uzun bir sifre giriniz...

            //string veri = txtGirisAlani.Text;

            //if (veri.Count() >= 8)
            //{

            //}


            // if, else if, else içerisinde tek bir satır kod bloğu var ise, süslü parantez ({}) kullanmasanızda olur.

            if (txtGirisAlani.Text.Length >= 8)
                MessageBox.Show("Şifre onaylandı");
            else
                MessageBox.Show("Daha uzun bir şifre giriniz!");

        }
    }
}
