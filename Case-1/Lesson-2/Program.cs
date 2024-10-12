using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region DoubleDegiskenler
            //double number;

            //number = 4.85;

            //Console.WriteLine(number);


            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;
            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;
            //Console.WriteLine("-------- Elma Birim Fiyatı: " + applePrice + " TL");
            //Console.WriteLine("-------- Portakal Birim Fiyatı: " + orangePrice + " TL");
            //Console.WriteLine("-------- Çilek Birim Fiyatı: " + strawberryPrice + " TL");
            //Console.WriteLine("-------- Patates Birim Fiyatı: " + potatoPrice + " TL");
            //Console.WriteLine("-------- Domates Birim Fiyatı: " + tomatoPrice + " TL");
            //Console.WriteLine();
            //Console.WriteLine();

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;
            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice=applePrice * appleGram;
            //double orangeTotalPrice=orangePrice * orangeGram;
            //double strawberryTotalPrice = strawberryPrice * strawberryGram;
            //double potatoTotalPrice = potatoPrice * potatoGram;
            //double tomateTotalPrice = tomatoGram * tomatoPrice;

            //Console.WriteLine("Alınan Ürün: Elma - " + "Birim Fiyat: " + applePrice + " - Gramaj: " + appleGram + " Toplam Tutar: " + appleTotalPrice);
            //Console.WriteLine("Alınan Ürün: Portakal - " + "Birim Fiyat: " + orangePrice + " - Gramaj: " + orangeGram + " Toplam Tutar: " + orangeTotalPrice);
            //Console.WriteLine("Alınan Ürün: Çilek - " + "Birim Fiyat: " + strawberryPrice + " - Gramaj: " + strawberryGram + " Toplam Tutar: " + strawberryTotalPrice);
            //Console.WriteLine("Alınan Ürün: Patates - " + "Birim Fiyat: " + potatoPrice + " - Gramaj: " + potatoGram + " Toplam Tutar: " + potatoTotalPrice);
            //Console.WriteLine("Alınan Ürün: Domates - " + "Birim Fiyat: " + tomatoPrice + " - Gramaj: " + tomatoGram + " Toplam Tutar: " + tomateTotalPrice);

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomateTotalPrice;
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("Alışveriş Toplam Tutar: " + shoppingTotalPrice + " TL");




            #endregion

            #region CharDegiskenler

            //char symbol;

            //symbol = 'a';
            //Console.WriteLine(symbol);
            #endregion

            #region Klavyeden Veri Girisi String Degisken

            //Console.WriteLine("**** Csharp Hava Yolları Yolcu Bilgisi ****");
            //Console.WriteLine();

            //string passangerName, passangerSurname, passangerDistrict, passangerCity, passangerAge, passangerIdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //passangerName = Console.ReadLine();
            //Console.Write("Yolcu Soyadı: ");
            //passangerSurname = Console.ReadLine();
            //Console.Write("İlçe Bilgisi: ");
            //passangerDistrict= Console.ReadLine();
            //Console.Write("Şehir Bilgisi: ");
            //passangerCity= Console.ReadLine();
            //Console.Write("Yolcu Yaş: ");
            //passangerAge= Console.ReadLine();
            //Console.Write("Yolcu TC Kimlik: ");
            //passangerIdentityNumber= Console.ReadLine();

            //Console.WriteLine();
            //Console.WriteLine("-------------------------");
            //Console.WriteLine("Yolcu TC Kimlik No: " + passangerIdentityNumber + " - Yolcu Ad Soyad:  " +  passangerName + " " + passangerSurname + " " + passangerDistrict + " / " +  passangerCity + " " + passangerAge );



            #endregion

            #region Klavyeden Veri Girisi Int Degisken

            //ABC12D

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoeCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoeCount= int.Parse(Console.ReadLine());
            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount= int.Parse(Console.ReadLine());
            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            //chairCount= int.Parse(Console.ReadLine());
            //Console.Write("Lütfen aldığınız televizyon sayısını giriniz: ");
            //tvCount= int.Parse(Console.ReadLine());

            //int totalPrice= shoesCount * shoesPrice + computerCount * computerPrice + chairCount * chairPrice + tvCount * tvPrice;

            //Console.WriteLine();
            //Console.WriteLine("Toplam Ödemeniz Gereken Tutar: " + totalPrice + " TL");

            #endregion

            #region Klavyeden Veri Girisi Ondalikli Sayi

            //double exam1, exam2, exam3, result;
            //Console.Write("Lütfen 1. sınav notunuzu giriniz: ");
            //exam1=double.Parse(Console.ReadLine());
            //Console.Write("Lütfen 2. sınav notunuzu giriniz: ");
            //exam2=double.Parse(Console.ReadLine());
            //Console.Write("Lütfen 3. sınav notunuzu giriniz: ");
            //exam3=double.Parse(Console.ReadLine());
            //result = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınav Ortalamanız: " + result);


            #endregion

            #region Klavyeden Veri Girisi Karakter

            char gender;
            Console.Write("Lütfen cinsiyet seçiniz: ");
            gender = char.Parse(Console.ReadLine());
            Console.WriteLine("Seçtiğiniz Cinsiyet: " + gender);
            #endregion


            Console.ReadKey();
        }
    }
}