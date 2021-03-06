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
                Console.WriteLine("3. Kilometros a Millas");
                Console.WriteLine("4. Millas a Kilometros");

                string opcion = Console.ReadLine();

                if (opcion == "1")
                {
                    CtoF();
                }

                if (opcion == "2")
                {
                    FtoC();
                }
                if (opcion == "3")
                {
                    KmtoMll();
                }
                if (opcion == "4")
                {
                    MlltoKm();
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
            

            double resFahr = (cels*(9.0/5.0))+32;

            Console.WriteLine("El resultado es: " + resFahr);
        }

        static void FtoC()
        {
            Console.Clear();

            Console.Write("Conversion FtoC");
            Console.WriteLine("");

            Console.WriteLine("Ingrese un Valor para la Conversion");
            double Dato1 = double.Parse(Console.ReadLine());
            double result = ((Dato1 - 32) * (5.0 / 9.0));

            Console.WriteLine("La conversion es :" + result);
        }
        static void MlltoKm()
        {
            Console.Clear();

            Console.WriteLine("Kilometros a Millas");
            Console.WriteLine("");

            Console.WriteLine("Ingrese el valor de Millas a convertir: ");
            double mll = double.Parse(Console.ReadLine());


            double resKm = mll * 0.62137;

            Console.WriteLine("El resultado es: " + resKm);
        }

        static void KmtoMll()
        {
            Console.Clear();

            Console.Write("Conversion KmtoMll");
            Console.WriteLine("");

            Console.WriteLine("Ingrese un Valor para la Conversion");
            double Dato1 = double.Parse(Console.ReadLine());
            double result = Dato1 / 0.62137;

            Console.WriteLine("La conversion es :" + result);



        }
    }
}
