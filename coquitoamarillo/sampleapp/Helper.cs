using System;
using System.Collections.Generic;

namespace sampleapp
{
    public class Helper
    {
        public void Menu()
        {
            int op = 0;
            while (op != 999999)
            {

                Console.WriteLine("Hola, bienvenido a nuestro sistema.\n\t Selecciona una opción:");

                //Console.WriteLine($"var: {mensaje}");
                //valido el valor de la opcion del usuario apra evitar ciclos inifnitos.
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                    Console.WriteLine("uno");
                        break;
                    case 2:
                    Console.WriteLine("dos");
                        break;
                    default:
                        Console.WriteLine("Seleciona una opcion valida.");
                        break;
                }
            }

            
        }
        public void MostrarTiposDeDatos()
        {
            // Tipos numéricos
            int entero = 25;
            double decimalDoble = 3.1416;
            float decimalFlotante = 1.5f;
            long enteroLargo = 123456789L;
        
            // Tipos de texto
            char caracter = 'A';
            string texto = "Hola, C#";

            // Booleano
            bool esVerdadero = false;

            // Tipo DateTime
            DateTime fechaActual = DateTime.Now;

            // Tipo var (inferido)
            var mensaje = "Tipo inferido";

            // Tipo array
            int[] numeros = { 1, 2, 3, 4, 5 };

            // Lista genérica
            List<string> frutas = new List<string> { "Manzana","Pera", "Banano" };
        
            // Mostrar resultados
            Console.WriteLine("===== TIPOS DE DATOS EN C# =====");
            Console.WriteLine($"int: {entero}");
            Console.WriteLine($"double: {decimalDoble}");
            Console.WriteLine($"float: {decimalFlotante}");
            Console.WriteLine($"long: {enteroLargo}");
            Console.WriteLine($"char: {caracter}");
            Console.WriteLine($"string: {texto}");
            Console.WriteLine($"bool: {esVerdadero}");
            Console.WriteLine($"DateTime: {fechaActual}");
            Console.WriteLine($"var: {mensaje}");
            //Console.WriteLine($"array: {string.Join(',\',numeros)}");
            //Console.WriteLine($"List<string>: {string.Join(',\', frutas)}");
        }//metodo
    }//class helper
}//namespace