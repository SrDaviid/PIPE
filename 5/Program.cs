using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
           //5. Promedio: Programa que saca por el STDOUT el maximo numero recibido por el STDIN.  	
           //Hasta encontrar una linea vacia

           int numero = 0;
            int acum = 0;
            int counter = 0;
            bool success;

            do
            {
                success = int.TryParse(Console.ReadLine(), out numero);

                if(success){
                    acum += numero;
                    counter++;
                }           

            } while (success != false);

            Console.WriteLine(acum/counter);

        }
    }
}
