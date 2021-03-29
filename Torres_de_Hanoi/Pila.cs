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
        //Tamaño de la pila
        public int Size { get; set; }
        //El elemento situado en la parte superi de la pila
        public int Top { get; set; }
        //Lista de tipo Disco de cada elemenento de la pila
        public List<Disco> Elementos { get; set; }

        public Pila()
        {
            Top = 0;

            Size = 0;

            Elementos = new List<Disco>();

        }

        public void push(Disco d)
        {

            //Introducimos dos condiciones si tamaño es 0 o 
            //el valor introducido es menor al valor mas alto de la pila registrado

            if (Size == 0 || d.Valor < Top)
            {
                Size++;

                Elementos.Add(d);

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

            return res; //Devolvemos el elemento deseado

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
