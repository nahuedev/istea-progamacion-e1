using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 4;
            int b = 0;
            int division;

            if (b!=0)
            {
                division = a/b;
                Console.WriteLine($"El cociente es : {division}");
            }else
            {
                Console.WriteLine($"ERROR: El divisor no puede ser {b}");
            }
        }
    }
}
