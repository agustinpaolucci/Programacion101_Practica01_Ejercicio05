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
            /*
             CONSIGNA: 
             Una tienda al por mayor de manzanas hace un descuento mientras mas comprés.
             Si compras menos de 100 kilos el precio es 4 euros.
             Si compras entre 100 y 500 kilos el precio es 3 euros.
             Si compras entre 500 y 1000 kilos el precio es 2 euros.
             Si compras más de 1000 kilos el kilo sale 1 euro.
             Haz un programa que calcule el precio según los kilos que compres. 
             */
            
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
