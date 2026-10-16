namespace Gyakorlas10_16
{
    internal class Program
    {
        static int[] tomb = new int[10];
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
        }


        static void Main(string[] args)
        {
            Feltolt();
            Kiir();
            KiirVissza();
            MasodikElemek();
        }
    }
}
