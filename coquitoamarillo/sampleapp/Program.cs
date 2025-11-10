using System;

namespace sampleapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola, este es mi primer ejercicio con C# desde Visual Studio Code!");
            // Declaración de variables
            int edad = 25;
            string nombre = "Ana";
            double salario = 1500000;
            Console.WriteLine($"Nombre: {nombre}, Edad: {edad}, Salario: {salario}");
            // Estructura de control
            if (edad >= 18)
            {
                Console.WriteLine("Eres mayor de edad.");
            }
            else
            {
                Console.WriteLine("Eres menor de edad.");
            }

            Console.WriteLine("Demostración de tipos de datos en C#\n");
            Helper helper = new Helper();
            helper.MostrarTiposDeDatos();
            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();

            helper.Menu();
        }
    }
}
