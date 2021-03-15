using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Hanoi
    {

        public void mover_disco(Pila a, Pila b)
        {
            if (b.isEmpty() == true || b.top().Valor > a.top().Valor)
            {

                Console.WriteLine("Moviendo disco de A a B");

                b.push(a.pop());
            }
            else if (a.isEmpty() == true || a.top().Valor > b.top().Valor)
            {

                a.push(b.pop());

                Console.WriteLine("Moviendo disco de B a A");

            }

        }

        public int iterativo(int n, Pila ini, Pila fin, Pila aux)
        {
            int m = 0;

            if ((n % 2) == 0)
            {
                while (fin.tamPila < 3)
                {
                    mover_disco(ini, aux);

                    mover_disco(ini, fin);

                    mover_disco(aux, fin);

                    m++;
                }

            }
            else
            {
                while (fin.tamPila < 3)
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
