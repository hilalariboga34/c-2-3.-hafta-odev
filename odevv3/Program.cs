using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> sayilar = new List<int>();
        int sayi;

        // Kullanıcıdan tam sayı dizisi al
        Console.WriteLine("Pozitif tam sayılar girin (Bitirmek için 0 girin):");
        while (true)
        {
            sayi = int.Parse(Console.ReadLine());
            if (sayi == 0)
                break;

            sayilar.Add(sayi);
        }

        // Dizide ardışık sayı gruplarını bul ve yazdır
        ArdışıkGruplariBul(sayilar);
    }

    static void ArdışıkGruplariBul(List<int> sayilar)
    {
        // Sayıları sıraya göre diz
        sayilar.Sort();

        int baslangic = sayilar[0];
        int onceki = baslangic;

        for (int i = 1; i < sayilar.Count; i++)
        {
            // Eğer ardışık değilse mevcut grubu yazdır ve yeni gruba başla
            if (sayilar[i] != onceki + 1)
            {
                if (baslangic == onceki)
                    Console.WriteLine(baslangic);
                else
                    Console.WriteLine($"{baslangic}-{onceki}");

                baslangic = sayilar[i];
            }
            onceki = sayilar[i];
        }

        // Son grubu yazdır
        if (baslangic == onceki)
            Console.WriteLine(baslangic);
        else
            Console.WriteLine($"{baslangic}-{onceki}");
    }
}
