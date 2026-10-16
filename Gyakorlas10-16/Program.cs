namespace Gyakorlas10_16
{
    internal class Program
    {
        static int[] tomb = new int[5];
        static Random r = new Random();
        static void Feltolt()
        {
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = r.Next(1, 101);
            }
        }

        static void Kiir()
        {
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write(tomb[i] + " ");
            }
            Console.WriteLine();
        }

        static void KiirVissza()
        {
            for (int i = tomb.Length - 1; i >= 0; i--)
            {
                Console.Write(tomb[i] + " ");
            }
            Console.WriteLine();
        }

        static void MasodikElemek()
        {
            for (int i = 1; i < tomb.Length; i += 2)
            {
                Console.Write(tomb[i] + " ");
            }
            Console.WriteLine();
        }

        static void MegadottSzam()
        {
            Console.Write("Kérek egy számot: ");
            int szam = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"A megadott helyen található szám: {tomb[szam-1]}");
        }



        static void Main(string[] args)
        {
            Feltolt();
            Kiir();
            KiirVissza();
            MasodikElemek();
            MegadottSzam();
        }
    }
}
