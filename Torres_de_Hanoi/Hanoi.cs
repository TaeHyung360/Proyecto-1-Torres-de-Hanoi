using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Hanoi
    {

        public static void mover_disco(Pila a, Pila b)
        {
            if (b.isEmpty() == true || b.Top > a.Top)
            {

                Console.WriteLine("Moviendo disco de A a B");

                b.push(a.pop());
            }
            else if (a.isEmpty() == true || a.Top > b.Top)
            {

                a.push(b.pop());

                Console.WriteLine("Moviendo disco de B a A");

            }

        }

        public static int iterativo(int n, Pila ini, Pila fin, Pila aux)
        {
            int m = 0;

            if ((n % 2) == 0) //Si el reesto de n  entre dos es 0 hace los pares, si no los impares
            {
                while (fin.Size < 3)
                {
                    mover_disco(ini, aux);

                    mover_disco(ini, fin);

                    mover_disco(aux, fin);

                    m++;
                }

            }
            else
            {
                while (fin.Size < 3)
                {
                    
                    mover_disco(ini, fin);

                    mover_disco(ini, aux);

                    mover_disco(aux, fin);

                    m++;
                }
            }

            return m;
        }

    }
}
