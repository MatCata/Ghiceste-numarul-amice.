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
                    Console.WriteLine("Felicitari, ai primit medalia de aur :D");
                    victorie = true;
                }
                Console.WriteLine();
            } while (victorie == false);

            Console.WriteLine("The End, To Be Continued....");
            Console.Write("Press any key to close the game.");
            Console.ReadKey(true);

        }
    }
}
