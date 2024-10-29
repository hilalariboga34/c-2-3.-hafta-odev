using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> sayilar = new List<int>();
        int sayi;

        // Kullanıcıdan pozitif tam sayılar alınır. 0 girildiğinde döngü sonlanır.
        Console.WriteLine("Pozitif tam sayılar girin (Bitirmek için 0 girin):");
        while (true)
        {
            sayi = int.Parse(Console.ReadLine());

            if (sayi == 0)
                break;

            if (sayi > 0)
                sayilar.Add(sayi);
            else
                Console.WriteLine("Lütfen pozitif bir tam sayı girin.");
        }

        // Sayılar listesinde eleman varsa ortalama ve medyan hesaplanır.
        if (sayilar.Count > 0)
        {
            // Ortalama hesaplama
            double ortalama = OrtalamaHesapla(sayilar);
            Console.WriteLine("Ortalama: " + ortalama);

            // Medyan hesaplama
            double medyan = MedyanHesapla(sayilar);
            Console.WriteLine("Medyan: " + medyan);
        }
        else
        {
            Console.WriteLine("Hiç pozitif sayı girilmedi.");
        }
    }

    // Ortalama hesaplama metodu
    static double OrtalamaHesapla(List<int> sayilar)
    {
        int toplam = 0;
        foreach (int sayi in sayilar)
        {
            toplam += sayi;
        }
        return (double)toplam / sayilar.Count;
    }

    // Medyan hesaplama metodu
    static double MedyanHesapla(List<int> sayilar)
    {
        sayilar.Sort(); // Liste sıralanır

        int n = sayilar.Count;
        if (n % 2 == 1)
        {
            // Tek eleman varsa ortadaki değeri döndür
            return sayilar[n / 2];
        }
        else
        {
            // Çift eleman varsa ortadaki iki değerin ortalamasını döndür
            return (sayilar[(n / 2) - 1] + sayilar[n / 2]) / 2.0;
        }
    }
}
