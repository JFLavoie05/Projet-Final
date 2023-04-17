using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partie_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrez votre premier nombre");
            Int32.TryParse(Console.ReadLine(), out int nb1);
            Console.WriteLine("Entrez votre deuxieme nombre");
            Int32.TryParse(Console.ReadLine(), out int nb2);

            Calculatrice calculatrice = new Calculatrice();

            Console.WriteLine(calculatrice.Exposant(nb1, nb2));
        }
    }
}
