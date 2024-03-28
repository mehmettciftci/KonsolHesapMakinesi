using System;

namespace KonsolHesapMakinesi
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Console Dinamik Hesap Makinesi");
            int birinciDeger = 0;
            bool canParse1 = false;
            
            do
            {
                Console.WriteLine("1. Sayıyı giriniz. Girilen değer mutlaka rakam olmalıdır.");
                try
                {
                    var sayi = int.Parse(Console.ReadLine());
                    canParse1 = int.TryParse(sayi.ToString(), out birinciDeger);
                }
                catch (Exception)
                {
                    Console.WriteLine("Lütfen sayı giriniz!");
                }

            } while (!canParse1);

            string argument;
            do
            {
                Console.WriteLine("Artitmetik operatör giriniz. Girebileceğiniz operatörler şekilde görüldüğü gibidir. (+,-,*,/)");
                argument = Console.ReadLine();
            } while (argument != "+" && argument != "-" && argument != "*" && argument != "/");
            string _operator = argument;

            int ikinciDeger = 0;
            bool canParse2 = false;
            do
            {
                Console.WriteLine("2. Sayıyı giriniz");
                try
                {
                    var sayi = int.Parse(Console.ReadLine());
                    canParse2 = int.TryParse(sayi.ToString(), out ikinciDeger);
                }
                catch (Exception)
                {
                    Console.WriteLine("Lütfen sayı giriniz!");
                }
            } while (!canParse2);
             
            if (_operator == "+")
            {
                int sonuc = birinciDeger + ikinciDeger;
                Console.WriteLine($"işlem sonucu = {sonuc}");
            }
            else if (_operator == "-")
            {
                int sonuc = birinciDeger - ikinciDeger;
                Console.WriteLine($"işlem sonucu = {sonuc}");
            }
            else if (_operator == "*")
            {
                int sonuc = birinciDeger * ikinciDeger;
                Console.WriteLine($"işlem sonucu = {sonuc}");
            }
            else if (_operator == "/")
            {
                int sonuc = birinciDeger / ikinciDeger;
                Console.WriteLine($"işlem sonucu = {sonuc}");
            }
            Console.ReadLine();

        }
    }
}
