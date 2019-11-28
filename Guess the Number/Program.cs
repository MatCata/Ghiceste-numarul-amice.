using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_the_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nume Participant: ");
            
                string nume = Console.ReadLine();
            
            Console.WriteLine("Initializare GOTY", nume);
            Console.WriteLine("3");
            Console.WriteLine("2");
            Console.WriteLine("1");
            Console.WriteLine("Start");
            Random r = new Random();

            int nc = r.Next(0, 100);

            bool victorie = false;

            do
            {
                Console.Write("Ghiceste un numar cuprins intre 0 si 100: ");
                string s = Console.ReadLine();

                int nr;
                bool n = int.TryParse(s, out nr);

                if (nr > nc)
                {
                    Console.WriteLine("Numar prea mare, mai incearca.");
                }
                else if (nr < nc)
                {
                    Console.WriteLine("Numar prea mic, mai incearca.");
                }
                else if (nr == nc)
                {
                    Console.WriteLine("Felicitari , ai primit medalia de aur :D");
                    victorie = true;
                }
                Console.WriteLine();
            } while (victorie == false);

            Console.WriteLine("Joc incheiat, va urma....");
            Console.Write("Apasa orice tasta pentru a inchide jocul.");
            Console.ReadKey(true);
           
        }
    }
}
