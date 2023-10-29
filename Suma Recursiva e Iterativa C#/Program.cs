//Erick Gamboa
//Suma de Recursividad y Iterativa

using System;

class Program
{
    static int SumaIterativa(int n)
    {
        int suma = 0;
        while (n > 9)
        {
            suma += n % 10;
            n /= 10;
        }
        return suma + n;
    }

    static int SumaRecursiva(int n)
    {
        if (n <= 9)
            return n;
        else
            return SumaRecursiva(n / 10) + n % 10;
    }

    static void Main()
    {
        int opcion;
        int digito;

        Console.WriteLine("1. Suma Recursiva");
        Console.WriteLine("2. Suma Iterativa");
        Console.Write("Ingrese una opcion: ");

        if (int.TryParse(Console.ReadLine(), out opcion))
        {
            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese un número para la suma: ");
                    if (int.TryParse(Console.ReadLine(), out digito))
                    {
                        Console.WriteLine("Suma recursiva: " + SumaRecursiva(digito));
                    }
                    else
                    {
                        Console.WriteLine("Entrada no válida.");
                    }
                    break;

                case 2:
                    Console.Write("Ingrese un número para la suma: ");
                    if (int.TryParse(Console.ReadLine(), out digito))
                    {
                        Console.WriteLine("Suma iterativa: " + SumaIterativa(digito));
                    }
                    else
                    {
                        Console.WriteLine("Entrada no válida.");
                    }
                    break;

                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Opción no válida.");
        }
    }
}