using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
    
        Console.Write("Üçgenin taban uzunluğunu girin: ");
        double taban = Convert.ToDouble(Console.ReadLine());
        Console.Write("Üçgenin yüksekliğini girin: ");
        double yukseklik = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Üçgenin alanı: {UcgenAlaniHesapla(taban, yukseklik)}\n");

        
        int[] sayilar = { 1, 3, 7, 0, 5, 9, 2 };
        Console.WriteLine($"Dizideki en büyük değer: {DizidekiEnBuyukDegeriBul(sayilar)}\n");

        
        Console.WriteLine($"İki int toplamı: {CalculateSum(5, 10)}");
        Console.WriteLine($"İki double toplamı: {CalculateSum(5.5, 10.2)}");
        Console.WriteLine($"Üç int toplamı: {CalculateSum(1, 2, 3)}\n");

        
        Console.WriteLine($"Fibonacci(5): {Fibonacci(5)}\n");

        
        Console.WriteLine($"Ortalama: {OrtalamaHesapla(1.0, 2.0, 3.0, 4.0, 5.0)}\n");

      
        int filtre = 3;
        Console.WriteLine($"Filtreye göre toplam: {DiziToplaVeFiltrele(sayilar, filtre)}\n");

       
        Console.WriteLine($"Yaş farkı: {YasHesapla(25)}");
        Console.WriteLine($"Yaş farkı (varsayılan): {YasHesapla()}\n");

        
        string[] kelimeler = { "elma", "armut", "çilek", "kavun", "karpuz", "kayısı" };
        List<string> uzunKelimeler = FiltreleVeListeDondur(kelimeler);
        Console.WriteLine("Uzun kelimeler:");
        uzunKelimeler.ForEach(Console.WriteLine);
    }

    
    static double UcgenAlaniHesapla(double taban, double yukseklik)
    {
        return (taban * yukseklik) / 2;
    }

    
    static int DizidekiEnBuyukDegeriBul(int[] dizi)
    {
        int max = int.MinValue;
        foreach (int sayi in dizi)
        {
            if (sayi > max)
            {
                max = sayi;
            }
        }
        return max;
    }

    
    static int CalculateSum(int a, int b)
    {
        return a + b;
    }

    static double CalculateSum(double a, double b)
    {
        return a + b;
    }

    static int CalculateSum(int a, int b, int c)
    {
        return a + b + c;
    }

   
    static int Fibonacci(int n)
    {
        if (n <= 1)
            return n;
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }

   
    static double OrtalamaHesapla(params double[] sayilar)
    {
        double toplam = 0;
        foreach (double sayi in sayilar)
        {
            toplam += sayi;
        }
        return toplam / sayilar.Length;
    }

    // 6. Filtreleme ve toplama metodu
    static int DiziToplaVeFiltrele(int[] dizi, int filtre)
    {
        int toplam = 0;
        foreach (int sayi in dizi)
        {
            if (sayi > filtre)
            {
                toplam += sayi;
            }
        }
        return toplam;
    }

    
    static int YasHesapla(int yas = 18)
    {
        return yas - 18;
    }

    
    static List<string> FiltreleVeListeDondur(string[] dizi)
    {
        List<string> sonuc = new List<string>();
        foreach (string kelime in dizi)
        {
            if (kelime.Length > 5)
            {
                sonuc.Add(kelime);
            }
        }
        return sonuc;
        Console.ReadKey();
    }
    
}