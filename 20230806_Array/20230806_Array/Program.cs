using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230806_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Array(dizi)
            //Program yazarken bazı durumlarda aynı türden birden fazla değerler tutmak zorunda kalabiliriz
            //Bu gibi durumlarda array(dizi) mantığı devreye girer
            //Array tanımlama işlemi [] işaretleri ile belirtiriz
            //Array tanımlaması yaparken içerisinde aynı türden kaç adet değer tutacak ise o sayıyı tanımlama esnasında belirtiriz
            //Array içerisindeki elemanları index numarası ile erişim sağlarız
            //Index numarası sayesinde  array içerisindeki elemanlara değer ataması yapabilir , güncelleme yapabilir veya okuma işlemini gerçekleştirebiliriz
            //Arraylerin içerisinde bulunan ilk elemanın index numarası 0 ' dır.Son elemanın index numarası ise eleman sayısının bir eksiğidir

            //Syntax
            //veriTipi[] takmaAd = new veriTipi[elemanSayisi];


            //Ornek 
            //İçerisinde 5 adet eleman barındıran , int türünden bir array oluşturalım

            //int[] sayilar=new int[5];

            //sayilar[0] = 5;
            //sayilar[1] = -200;
            //sayilar[2] = 8150;
            //sayilar[3] = -351;
            //sayilar[4] = 1;

            //Console.WriteLine("0. index'teki 1.eleman : " + sayilar[0]);
            //Console.WriteLine("1. index'teki 2.Eleman : " + sayilar[1]);
            //Console.WriteLine("2. index'teki 3.Eleman : " + sayilar[2]);
            //Console.WriteLine("3. index'teki 4.Eleman : " + sayilar[3]);
            //Console.WriteLine("4. index'teki 5.Eleman : " + sayilar[4]);

            

            Console.ReadKey();

        }
    }
}
