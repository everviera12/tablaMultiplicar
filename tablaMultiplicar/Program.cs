using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tablaMultiplicar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un color: " +
                "\n1.-Amarillo" + // tabla del 2
                "\n2.-Morado " + // tabla del 7
                "\n3.-Rosa " + // tabla del 9
                "\n4.-Azul " + // tabla del 6
                "\n5.-Blanco "); // tabla del 12

            string color = Console.ReadLine();

            Console.WriteLine("--- Utilizando la estructura IF ---");
            tablaIF(color);

            Console.WriteLine("--- Utilizando la estructura SWITCH ---");
            TablaSwitch(color);

            Console.ReadLine();
        }

        static void tablaIF(string color)
        {
            if (color == "Amarillo")
            {
                Console.WriteLine("Tabla del 2:");
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"2 x {i} = {2 * i}");
                }
            }
            else if (color == "Morado")
            {
                Console.WriteLine("Tabla del 7:");
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"7 x {i} = {7 * i}");
                }
            }
            else if (color == "Rosa")
            {
                Console.WriteLine("Tabla del 9:");
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"9 x {i} = {9 * i}");
                }
            }
            else if (color == "Azul")
            {
                Console.WriteLine("Tabla del 6:");
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"6 x {i} = {6 * i}");
                }
            }
            else if (color == "Blanco")
            {
                Console.WriteLine("Tabla del 12:");
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"12 x {i} = {12 * i}");
                }
            }
            else
            {
                Console.WriteLine("Color no reconocido.");
            }
        }

        static void TablaSwitch(string color)
        {
            switch (color)
            {
                case "Amarillo":
                    Console.WriteLine("Tabla del 2:");
                    for (int i = 1; i <= 10; i++)
                    {
                        Console.WriteLine($"2 x {i} = {2 * i}");
                    }
                    break;
                case "Morado":
                    Console.WriteLine("Tabla del 7:");
                    for (int i = 1; i <= 10; i++)
                    {
                        Console.WriteLine($"7 x {i} = {7 * i}");
                    }
                    break;
                case "Rosa":
                    Console.WriteLine("Tabla del 9:");
                    for (int i = 1; i <= 10; i++)
                    {
                        Console.WriteLine($"9 x {i} = {9 * i}");
                    }
                    break;
                case "Azul":
                    Console.WriteLine("Tabla del 6:");
                    for (int i = 1; i <= 10; i++)
                    {
                        Console.WriteLine($"6 x {i} = {6 * i}");
                    }
                    break;
                case "Blanco":
                    Console.WriteLine("Tabla del 12:");
                    for (int i = 1; i <= 10; i++)
                    {
                        Console.WriteLine($"12 x {i} = {12 * i}");
                    }
                    break;
                default:
                    Console.WriteLine("Color no reconocido.");
                    break;
            }
        }
    }
}
