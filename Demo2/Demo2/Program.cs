using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2
{
    class Program
    {
        static void FtoC()
        {
            Console.Write("Conversion FtoC");
            Console.WriteLine("");

            Console.WriteLine("Ingrese un Valor para la Conversion");
            double Dato1 = double.Parse(Console.ReadLine());

            double result = (Dato1-32) * (5/9);

            Console.WriteLine("La conversion es :" + result);
            
            
        }
    }
}
