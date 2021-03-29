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
            //=====================================================================

            Pila ini = new Pila(); //Inicializamos las pilas

            Pila aux = new Pila();

            Pila fin = new Pila();

            //=====================================================================

            Console.WriteLine(" Indique el número de discos que va a utilizar: ");

            int cuantos = Convert.ToInt32(Console.ReadKey().KeyChar.ToString());

            for (int i = cuantos; i > 0; i--)
            {

                Disco disco = new Disco(); //Crea un disco vacio 

                disco.Valor = i; //Le asigna el valor o el tanyo al disco creado 

                ini.push(disco); //Mete el disco creado en la pila inicial

            }

            //Llamamos a la clase Hanoi y guardamos los movimientos

            int movimientos = Hanoi.iterativo(cuantos, ini, fin, aux);

            int movimientosRecursivo = Hanoi.recursivo(cuantos, ini, fin, aux);

            Console.WriteLine(" Movimientos realizados iterativo = " + movimientos);

            Console.WriteLine(" Movimientos realizados recursivo = " + movimientosRecursivo);

            //==============================================================================
            //Calculo de la formula de movimientos minimos
            //==============================================================================

            Console.WriteLine(" Minimo numero de movimientos = " + (Math.Pow(2, cuantos) - 1)); 

        }
    }
}
