using System;
using System.Windows.Forms;

namespace WFA_KararYapilari
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
         
        #region Açıklama
        /*
* MANTIKSAL OPERATORLER
* Birden fazla durumun ayni anda kontrol edilmesi senaryosunda kullanilan operatorlerdir...
* && (VE) (Kontrol blogu icerisinde yer alan tum kosullarin saglanmasi durumuna isaret eder... Kosullardan biri dahi saglanmazsa blogunuz harekete gecmez...)
* || (VEYA) (Kontrol blogu icerisinde yer alan kosullardan herhangi birinin saglanmasi durumuna isaret eder... Boylece bir kosul bile saglansa blogunuza yazdiginiz kodlar harekete gecer...) Kısayol => ALTGR + Tire
* 
* Yukarıdaki operatorlere "kısa devre operatoru (shortcut operator)" adi verilir.. Kosullari kontrole en soldan baslar, herhangi bir uygunsuzluk durumunda diger kosullara asla bakmaz!.. Asagidaki operatorlerde ise, kosullar uysun ya da uymasin hepsi kontrol edilir...
* 

*/
        #endregion

        #region Örnek 1
        private void BtnGirisKontrolu_Click(object sender, EventArgs e)
        {
            if (txtBirinciDeger.Text == "admin" && txtIkinciDeger.Text == "1234")
            {
                MessageBox.Show("Tebrikler, tum bilgileri dogru girdiniz...");
            }
            else
            {
                //Iki kosuldan herhangi birinin saglanmamasi durumu
                MessageBox.Show("Kullanıcı adınızı ya da şifrenizi yanlış girdiniz!");
            }
        }
        #endregion

        #region Örnek 2
        private void BtnNotKontrolu_Click(object sender, EventArgs e)
        {
            //Girilen not 0 - 30 araligi ise "FF" 30 - 50 araligi "DD" 50 - 70 "BB" 70 - 100 "AA" aldınız seklinde kullaniciyi uyariniz..
        }
        #endregion

        #region Örnek 3
        private void BtnMarketKontrolu_Click(object sender, EventArgs e)
        {
            //Disaridan urun adi girilecek, kasiyer bize urunun hangi reyonda oldugunu soyleyecek...
            //Domates, Biber, Patlican => Sebze Reyonu
            //Diş Macunu, Parfüm, Şampuan => Kozmetik Reyonu
            //Cep Telefonu, Bilgisayar, Ses Sistemi => Teknoloji Reyonu
            //Başka bir ürün girilirse "Bu ürün bizde yok!" uyarisi verilsin!
        }
        #endregion

        #region Örnek 4
        private void BtnSatisIslemi_Click(object sender, EventArgs e)
        {
            //Disaridan siparis alinacak olan kitap miktari girilsin. Sipari sayisi 20'den azsa toplam ucretten %5, 20 - 50 araliginda ise %10, 50-100 araligi ise %15, 100'den fazla ise %25 indirim yapilsin. Kitabın birim fiyatı => 5 TLdir... Amac => Odenecek tutari kullaniciya gostermek...
        } 
        #endregion
    }
}
