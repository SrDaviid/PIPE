using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
           //2. Cuadrado: Programa que eleva al cuadrado todo numero que recibe por el STDIN
           // Hasta encontrar la linea vacia
            int numero = 0;
            int acum = 0;
            bool success;

            do
            {
                success = int.TryParse(Console.ReadLine(), out numero);

                if(success){
                    acum = numero * numero;
                    Console.WriteLine(acum);
                }

                
                
            } while (success != false);

        }
    }
}
