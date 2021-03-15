using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    //Clase pila
    class Pila
    {
        public int Size { get; set; }

        public int Top { get; set; }

        public Disco[] Elementos { get; set; }

        public int tamPila;

        /* TODO: Implementar métodos*/
        public Pila()
        {
            tamPila = 0;

        }

        public void push(Disco d)
        {

            if (tamPila == 0)
            {
                tamPila++;

                Elementos[tamPila] = d;
            }
            else
            {
                if (d.Valor < Elementos[tamPila].Valor)
                {
                    tamPila++;

                    Elementos[tamPila] = d;

                }

                else
                {
                    //No puede haber un push ya que la pila de abajo es menor a la que estas intetando introducir.
                }
            }

        }

        public Disco pop()
        {

            Disco res = Elementos[tamPila];

            tamPila--;

            return res;
        }

        public Disco top()
        {
            Disco res = Elementos[tamPila];

            return res;
        }


        public bool isEmpty()
        {

            if (tamPila != 0)
            {

                return false;

            }

            else
            {

                return true;

            }

        }

    }
}
