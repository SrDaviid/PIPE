using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            //4. Sumatoria: Programa que saca por el STDOUT la sumatoria de todos los numeros leidos por el STDIN.
            // Hasta encontrar una linea vacia
            

            int numero = 0;
            int acum = 0;
            bool success;

            do
            {
                success = int.TryParse(Console.ReadLine(), out numero);

                if(success){
                    acum += numero;
                }
                
            } while (success != false);

            Console.WriteLine(acum);
        }
    }
}
