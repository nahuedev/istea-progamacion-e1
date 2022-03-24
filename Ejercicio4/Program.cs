using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            double notaPrimerTrimestre, notaSegundoTrimestre,notaTercerTrimestre, promedio, trimestre=3;

            Console.WriteLine("Ingrese la nota del Primer trimestre");
                notaPrimerTrimestre = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la nota del Segundo trimestre");
                 notaSegundoTrimestre = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Ingrese la nota del Tercer trimestre");
                 notaTercerTrimestre = Convert.ToDouble(Console.ReadLine());

            promedio = (notaPrimerTrimestre + notaSegundoTrimestre + notaTercerTrimestre)/ trimestre;
            
            promedio = Math.Round(promedio,2);

            Console.WriteLine($"El Promedio del trimestre es : {promedio}");
        }
    }
}
