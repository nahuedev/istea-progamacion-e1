/* 
Dados dos valores numéricos enteros a y b, calcular e informar la suma: a+b, la diferencia:
a-b, y el producto: a*b entre dichos valores. 
*/

using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 7;
            int b = 7;

            int suma = a+b;
            int resta = a-b;
            int producto = a*b;
            int division = a/b;

            Console.WriteLine("********** Respuestas **********");    
            Console.WriteLine($"La suma es: {suma}. \nLa resta es: {resta}.\nEl producto es {producto}.\nLa division es {division}");

            
        }
    }
}
