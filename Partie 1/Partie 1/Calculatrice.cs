using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partie_1
{
    public class Calculatrice
    {
        public int Diviser(int nb1, int nb2)
        {
            return nb1 / nb2;
        }

        public int Multiplier(int nb1, int nb2)
        {
            checked
            {
                return nb1 * nb2;
            }
        }

        public int Additioner(int nb1, int nb2)
        {
            checked
            {
                return nb1 + nb2;
            }
        }

        public int Soustraire(int nb1, int nb2)
        {
            checked
            {
                return nb1 - nb2;
            }
        }

        public double Exposant(int nb1, int nb2)
        {
            checked
            {
                return Math.Pow(nb1, nb2);
            }
        }

        public double Log(int nb1, int nb2)
        {
            checked
            {
                return Math.Log(nb1, nb2);
            }
        }

    }
}
