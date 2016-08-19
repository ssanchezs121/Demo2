﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Conversión de temperatura";

            bool continuar = true;

            while (continuar)
            {
                Console.Clear();

                Console.WriteLine("Seleccione una opción: ");

                Console.WriteLine("1. Celsius a Fahrenheit");
                Console.WriteLine("2. Fahrenheit a Celsius");

                string opcion = Console.ReadLine();

                if (opcion == "1")
                {
                    CtoF();
                }

                if (opcion == "2")
                {
                    //FtoC();
                }

                Console.WriteLine("\nSeleccione una opción: ");
                Console.WriteLine("1. Volver al menú principal");
                Console.WriteLine("2. Salir");

                opcion = Console.ReadLine();

                if (opcion != "1")
                {
                    continuar = false;
                }
            }
        }
        static void CtoF() 
        {
            Console.Clear();

            Console.WriteLine("Celsius a Fahrenheit");
            Console.WriteLine("");

            Console.WriteLine("Ingrese el valor de Celsius a convertir: ");
            double cels = double.Parse(Console.ReadLine());
            

            double resFahr = (cels*(9/5))+32;

            Console.WriteLine("El resultado es: " + resFahr);
        }
    }
}
