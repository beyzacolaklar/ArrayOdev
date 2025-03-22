// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        
        int[] sayilar = new int[5];
        int toplam = 0;

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Lütfen {i + 1}. sayıyı girin: ");
            sayilar[i] = Convert.ToInt32(Console.ReadLine());  
            toplam += sayilar[i];  
        }

        
        double ortalama = toplam / 5.0;

      
        Console.WriteLine($"Girdiğiniz sayıların ortalaması: {ortalama}");
    }
}

