using System;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
       {
           //Maximo: Programa que saca por el STDOUT el maximo numero recibido por el STDIN. 
          
        
        int ma=0, me=0, num=0;
        Console.WriteLine ("Cuantos numeros va ingresar");
        int numeros=int.Parse(Console.ReadLine());
        for(int i =1;i<=numeros;i++){
        Console.WriteLine ("Digite un numero: ");
        num=int.Parse(Console.ReadLine()); 
            
            if(i==1){
            ma=num;
            me=num;
            }
            if(num>ma){ma=num;}
            if(num<me){me=num;}
            
            
            
        num=0; 
        }
        
        Console.WriteLine (" numero mayor es: "+ma);
  

       }
    }        
}            
       
    
        
        
        
        



        
    
