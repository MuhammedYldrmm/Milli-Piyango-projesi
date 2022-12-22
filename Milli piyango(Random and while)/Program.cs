namespace Milli_piyango_Random_and_while_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] kazananBiletler = { 123, 562, 297, 476, 821, 401, 500, 632 };
            int benimBiletim = 0;
            int denemeSayisi = 0;
            bool kazandimMi = false;

            Random random = new Random();

            while(!kazandimMi)
            {
                benimBiletim = random.Next(1000);
                denemeSayisi++;

                foreach (var bilet in kazananBiletler)
                {
                    if(bilet==benimBiletim)
                    {
                        kazandimMi = true;
                        Console.WriteLine("Tebrikler,kazandınız");
                        Console.WriteLine("Deneme Sayısı:" + denemeSayisi.ToString());
                    }

                }
            }
        }
    }
}