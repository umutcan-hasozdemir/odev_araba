using System;

namespace or224
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,,] Araba = new int[3, 3, 3];
            string[] isim = { "polo", "jetta", "passat", "Sedan", "Station", "Hatchback", "siyah", "Beyaz", "kırmızı" };
            Random rastgele = new Random();
            for (int u = 0; u < 3; u++)
            {
                for (int t = 0; t < 3; t++)
                {
                    for (int r = 0; r < 3; r++)
                    {
                        Araba[u, t, r] = rastgele.Next(11);
                    }
                }
            }
            int enbuyuk = -1;

            
            foreach (var adet in Araba)
            {
                if (adet > enbuyuk)
                {
                    enbuyuk = adet;
                }
            }

            Console.Write("En yüksek adete sahip araba/lar:");

         
            for (int u = 0; u < 3; u++)
            {
                for (int t = 0; t < 3; t++)
                {
                    for (int r = 0; r < 3; r++)
                    {
                        if (Araba[u, t, r] == enbuyuk)
                        {
                            Console.WriteLine($"{isim[u]} {isim[t + 3]} {isim[r + 6]} {Araba[u, t, r]} Adet");
                        }
                    }
                }
            }
         
        }
    }
}