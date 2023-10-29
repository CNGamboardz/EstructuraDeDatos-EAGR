//Erick Gamboa
//Ejercicios de Recursividad e Iteración

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TABLA_DE_MULTIPLICAR_CON_WHILE
{
    class Program
    {
        static void Main(string[] args)
        {
            int NUM, I, RESULT;
            string linea;
            Console.Write("DIGITE NUMERO: "); 
            linea = Console.ReadLine();
            NUM = int.Parse(linea);
            I = 1;
            while ((I <= 12))
            {
                RESULT = NUM * I;
                Console.WriteLine("{0} * {1} = {2}", NUM, I, RESULT);
                I = I + 1;
            }
            Console.Write("Pulse una tecla: "); Console.ReadLine();

        }
    }
}