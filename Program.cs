using System;
class Program
{
    static bool OduncUygunMu(bool OduncAlindi, int gun)
    {
        return !OduncAlindi && gun >= 1 && gun <= 7;
    }
    static void Main()
    {
        Console.Write("Kaç gün? ");
        string? giris = Console.ReadLine();
        if (!int.TryParse(giris, out int gun) ||
            gun < 1 || gun > 7)
        {
            Console.WriteLine(" 1-7 arası  bir sayı giriniz.");
            return;
        }
        bool oduncAlindi = true;
        if (OduncUygunMu(oduncAlindi, gun))
        {
            Console.WriteLine($"Süre : {gun} gün ");
        }
        else
        {
            Console.WriteLine("Talep uygun değil. Ekipman ödünçte.");
        }
    }
}
// abc girilirse reddedilir metin tam sayıya dönüstürülemez.
// 0 girilirse reddedilir çünkü gün sayısı 1'den küçüktür.
// 1 girilirse kabul edilir.
// 7 girilirse kabul edilir.
// 8 girilirse reddedilir çünkü gün sayısı 7'den büyüktür.
