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

        public List<Disco> Elementos { get; set; }


        /* TODO: Implementar métodos*/
        public Pila()
        {
            Size = 0;

        }

        public void push(Disco d)
        {

            if (Size == 0 || d.Valor < Top)
            {
                Size++;

                Elementos[Size] = d;

                Top = d.Valor;
            }
 
        }

        public Disco pop()
        {

            Disco res = new Disco();

            if (Size > 0)
            {
                res = Elementos.Last(); //Creamos un obj con el ultimo disco de la lista

                Elementos.RemoveAt(Size - 1); //Eliminamos el ultimo de la lista 

                Size--; //Se reduce el tamanyo

                if (Size == 0)
                {
                    Top = 0;
                }
                else
                {
                    Top = Elementos.Last().Valor; //Asignamos a top el ultimo valor
                }
  
            }

            return res;

        }

        public bool isEmpty()
        {

            if (Size != 0)
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
