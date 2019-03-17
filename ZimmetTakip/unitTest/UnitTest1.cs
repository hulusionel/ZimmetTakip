using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZimmetTakip;

namespace unitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void LoginAdmin()
        {
            int beklenen =1;
            string isim = "Hulusi";
            string Sifre = "1012";
            Login giris = new Login();
            int sonuc =giris.Giris(isim,Sifre);
            Assert.AreEqual(beklenen, sonuc);           
        }

        [TestMethod]
        public void LoginBolumSefi()
        {
            int beklenen = 1;
            string isim = "Özgür";
            string Sifre = "1009";
            Login giris = new Login();
            int sonuc = giris.Giris(isim, Sifre);
            Assert.AreEqual(beklenen, sonuc);
        }
        [TestMethod]
        public void LoginStokTakip()
        {
            int beklenen = 1;
            string isim = "Utku";
            string Sifre = "1003";
            Login giris = new Login();
            int sonuc = giris.Giris(isim, Sifre);
            Assert.AreEqual(beklenen, sonuc);
        }

        [TestMethod]
        public void PersonelListele()
        {
        }
        [TestMethod]
        public void UrunZimmetle()
        {
        }

    }
}
