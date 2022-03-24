using System;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceHour, cantHoursWeek, saturdayHours, weeklySalary,cantHourDay ;
            
            const int BUSINESS_DAYS = 5;
            const int COEF_SATURDAY = 2;
            
             Console.WriteLine("******Bienvenido********");
             Console.WriteLine("Presione enter para comenzar");


             if (Console.ReadKey().Key == ConsoleKey.Enter)
             {
                 Console.WriteLine("Ingrese el valor de la hora trabajada: ");
                    priceHour = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Ingrese el total de horas trabajadas en un dia: ");
                    cantHourDay = Convert.ToDouble(Console.ReadLine());

                cantHoursWeek = cantHourDay * BUSINESS_DAYS;
                saturdayHours =  cantHourDay / COEF_SATURDAY ;
                weeklySalary = priceHour*(cantHoursWeek + saturdayHours);    
                
                Console.WriteLine($"El salario semanal es : ${weeklySalary}");

             } else
             {
                 Console.WriteLine("\nBye!");
             }  


        }
    }
}
