using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Program
    {
        static void Main(string[] args)
        {

            Pila ini = new Pila(); //Inicializamos las pilas

            Pila aux = new Pila();

            Pila fin = new Pila();

            Console.WriteLine("Indique el número de discos que va a utilizar: ");

            int cuantos = Convert.ToInt32(Console.ReadKey().KeyChar.ToString());

            for (int i = cuantos; i > 0; i--)
            {

                Disco disco = new Disco(); //Crea un disco vacio 

                disco.Valor = i; //Le asigna el valor o el tanyo al disco creado 

                ini.push(disco); //Mete el disco creado en la pila inicial

            }

            int movimientos = Hanoi.iterativo(cuantos, ini, fin, aux);

            Console.WriteLine("Movimientos realizados = " + movimientos);

            Console.WriteLine("Movimientos realizados = " + (Math.Pow(2, cuantos) - 1)); 

        }
    }
}
