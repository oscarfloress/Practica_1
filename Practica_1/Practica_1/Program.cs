using System;

namespace Practica_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Practica_1";
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            int primero, segundo;
            float radio;
            Console.WriteLine("1 suma\n2 resta\n3 multiplicacion\n4 division\n5 area triangulo\n6 area circulo\n7 area cuadrado\n");
            int opcion = int.Parse(Console.ReadLine());

            Console.Write("\nPress any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
