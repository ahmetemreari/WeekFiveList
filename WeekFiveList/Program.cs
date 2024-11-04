using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //liste oluştur
        List<string> ziyaretciListesi = new List<string>();

        // Ziyaretçi ekle
        ziyaretciListesi.Add("Behlül");
        ziyaretciListesi.Add("Bihter");
        ziyaretciListesi.Add("Nihal");
        ziyaretciListesi.Add("Adnan");
        ziyaretciListesi.Add("Firdevs");

        // isimleri ekrana yazdıralım
        Console.WriteLine("Patika Plus gala gecesine davetli ziyaretçiler:");
        foreach (string ziyaretci in ziyaretciListesi)
        {
            Console.WriteLine(ziyaretci);
        }
    }
}
