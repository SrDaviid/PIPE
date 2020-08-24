using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Contador: Programa que cuenta desde 1 hasta N
            // Donde N fue dada como un argumento de linea de comando
            int numero = 0;
            int i = 1;

            if(int.TryParse(args[0], out numero) && numero > 0){
                for (; i <= numero; i++)
                {
                    Console.WriteLine(i);
                }

            }else{
                Console.Error.WriteLine("El valor introducido es invalido (cero, negativo o no puede ser convertido a numero) ({0})", args[0]);
            }
        }
    }
}
