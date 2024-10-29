using System;

class Program
{
    static void Main()
    {
        // Kullanıcıdan tam sayı dizisini al
        Console.WriteLine("Kaç tane sayı gireceksiniz?");
        int n = int.Parse(Console.ReadLine());
        int[] dizi = new int[n];

        Console.WriteLine("Dizinin elemanlarını girin:");
        for (int i = 0; i < n; i++)
        {
            Console.Write("Eleman {0}: ", i + 1);
            dizi[i] = int.Parse(Console.ReadLine());
        }

        // Diziyi sıralayın
        Array.Sort(dizi);

        // Sıralı diziyi ekrana yazdır
        Console.WriteLine("Sıralı Dizi:");
        foreach (int sayi in dizi)
        {
            Console.Write(sayi + " ");
        }
        Console.WriteLine();

        // Kullanıcıdan aranacak sayıyı al
        Console.WriteLine("Aranacak sayıyı girin:");
        int aranacakSayi = int.Parse(Console.ReadLine());

        // İkili arama algoritması ile sayının dizide olup olmadığını kontrol et
        bool bulundu = IkiliArama(dizi, aranacakSayi);

        // Sonucu ekrana yazdır
        if (bulundu)
        {
            Console.WriteLine("Aranan sayı dizide mevcut.");
        }
        else
        {
            Console.WriteLine("Aranan sayı dizide bulunamadı.");
        }
    }

    // İkili arama algoritması
    static bool IkiliArama(int[] dizi, int aranacakSayi)
    {
        int sol = 0;
        int sag = dizi.Length - 1;

        while (sol <= sag)
        {
            int orta = (sol + sag) / 2;

            if (dizi[orta] == aranacakSayi)
                return true;
            else if (dizi[orta] < aranacakSayi)
                sol = orta + 1;
            else
                sag = orta - 1;
        }

        return false;
    }
}
