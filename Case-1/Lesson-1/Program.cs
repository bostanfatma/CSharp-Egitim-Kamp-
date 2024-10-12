using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YazdirmaKomutlari
            //Console.WriteLine("Merhaba Dünya");
            //Console.Write("Selam");

            //Console.WriteLine("******** Yemek Kategorileri ********");
            //Console.WriteLine();
            //Console.WriteLine("1-)Çorbalar");
            //Console.WriteLine("2-)Ana Yemek");
            //Console.WriteLine("3-)Soğuk Başlangıçlar");
            //Console.WriteLine("4-)Salatalar");
            //Console.WriteLine("5-)Tatlılar");
            //Console.WriteLine("6-)İçecekler");
            //Console.WriteLine();
            //Console.Write("******** Yemek Kategorileri ********");

            #endregion

            #region StringDegiskenler

            //Değişkenler
            //string name;
            //name = "Emir";
            //Console.WriteLine(name);

            //string CustomerName;
            //string CustomerSurname;
            //string CustomerPhone;
            //string CustomerEmail, district, city;

            //CustomerName = "Fatma";
            //CustomerSurname = "Bostan";
            //CustomerPhone = "+90 500 400 30 20";
            //CustomerEmail = "deneme@gmail.com";
            //district = "Kadıköy";
            //city = "İstanbul";

            //Console.WriteLine("**** Rezervasyon Kartı ****");
            //Console.WriteLine();
            //Console.WriteLine("------------------------");
            //Console.WriteLine("Müşteri: " + CustomerName + " " + CustomerSurname);
            //Console.WriteLine("İletişim: " + CustomerPhone);
            //Console.WriteLine("Email Adress: " + CustomerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("------------------------");

            //Console.WriteLine();

            //CustomerName = "Ayşegül";
            //CustomerSurname = "Kaya";
            //CustomerPhone = "+90 400 300 80 70";
            //CustomerEmail = "test@gmail.com";
            //district = "Taksim";
            //city = "İstanbul";

            //Console.WriteLine("------------------------");
            //Console.WriteLine("Müşteri: " + CustomerName + " " + CustomerSurname);
            //Console.WriteLine("İletişim: " + CustomerPhone);
            //Console.WriteLine("Email Adress: " + CustomerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("------------------------");
            #endregion

            #region IntDegiskenler

            //int
            //int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("**** Restoran Menü Fiyatları ****");
            Console.WriteLine();
            Console.WriteLine("-----Hamburger: " + hamburgerPrice + " TL");
            Console.WriteLine("-----Pizza: " + pizzaPrice + " TL");
            Console.WriteLine("-----Kola: " + cokePrice + " TL");
            Console.WriteLine("-----Limonata: " + lemonadePrice + " TL");
            Console.WriteLine("-----Kızartma: " + friesPrice + " TL");
            Console.WriteLine("-----Su: " + waterPrice + " TL");
            Console.WriteLine();
            Console.WriteLine("**** Restoran Menü Fiyatı ****");
            Console.WriteLine();

            int hamburgerCount = 3;
            int cokeCount = 3;
            int waterCount = 3;
            int friesCount = 1;
            int pizzaCount = 0;
            int lemonadeCount = 0;

            int totalHamburgerPrice = hamburgerPrice * hamburgerCount;
            int totalCokePrice = cokePrice * cokeCount;
            int totalWaterCount = waterPrice * waterCount;
            int totalFriesCount = friesPrice * friesCount;
            int totalPizzaCount = pizzaPrice * pizzaCount;
            int totalLemanodeCount = lemonadePrice * lemonadeCount;

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Hamburger Tutarı: " + totalHamburgerPrice + " TL");
            Console.WriteLine("Pizza Tutarı: " + totalPizzaCount + " TL");
            Console.WriteLine("Kızartma Tutarı: " + totalFriesCount + " TL");
            Console.WriteLine("Kola Tutarı: " + totalCokePrice + " TL");
            Console.WriteLine("Limonata Tutarı: " + totalLemanodeCount + " TL");
            Console.WriteLine("Su Tutarı " + totalWaterCount + " TL");
            Console.WriteLine();

            int totalPrice = totalHamburgerPrice + totalCokePrice + totalWaterCount + totalFriesCount + totalPizzaCount + totalLemanodeCount;

            Console.WriteLine("Toplam Ödenecek Tutar: " + totalPrice + " TL");

            #endregion

            Console.ReadKey();

        }
    }
}