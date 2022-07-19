using System;

namespace metod_overloding // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            string sayi="999";
            int outsayi;
            bool sonuc=int.TryParse(sayi,out outsayi);
            if(sonuc)
            {
                Console.WriteLine("başarılı: ",sonuc);
            }
            else
            {
                Console.WriteLine("başarısız");
            }
            metodlar instance=new metodlar();
            instance.topla(2,3,out int toplamsonuc);
            Console.WriteLine(toplamsonuc);
            int ifade=999;
            instance.ekranayazdir(Convert.ToString(ifade));
            instance.ekranayazdir(ifade);
            instance.ekranayazdir("s","a");

        }
    }
    class metodlar
    {
        public void topla(int a, int b,out int toplam)
        {
            toplam=a+b;
        }
        public void ekranayazdir(string veri)
        {
            Console.WriteLine(veri);
        }
        public void ekranayazdir(int veri)
        {
            Console.WriteLine(veri);
        }
        public void ekranayazdir(string veri1,string veri2)
        {
            Console.WriteLine(veri1+veri2);
        }


    }
}