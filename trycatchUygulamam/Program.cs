
using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Lütfen bir sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            int karesi = sayi * sayi;
            Console.WriteLine("Girdiğiniz sayının karesi: " + karesi);
        }
        catch
        {
            Console.WriteLine("Geçersiz giriş! Lütfen bir sayı giriniz.");
        }
    }
}
