using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kilos;
            int precio;
            int precioTotal;

            Console.WriteLine("¿Que cantidad de kilos va a comprar?");
            kilos = Convert.ToInt32(Console.ReadLine());

            if (kilos < 100)
            {
                precio = 4;
                precioTotal = kilos * precio;
            }
            else
                if (kilos >= 100 && kilos < 500)
            {
                precio = 3;
                precioTotal = kilos * precio;
            }
            else if (kilos >= 500 && kilos < 1000)
            {
                precio = 2;
                precioTotal = kilos * precio;
            }
            else
            {
                precio = 1;
                precioTotal = kilos * precio;
            }
           
            Console.WriteLine($"El precio total es: {precioTotal} euros.");
            Console.ReadKey();
        }
    }
}
