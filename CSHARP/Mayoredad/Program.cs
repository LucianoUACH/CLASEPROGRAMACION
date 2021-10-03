using System;

namespace Mayoredad
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;
            Console.WriteLine("Ingrese edad:");
            edad = Convert.ToInt32(Console.ReadLine());

            if(edad > 0 )
            { 
                if(edad >= 18)
                {
                    Console.WriteLine("MAYOR DE EDAD");
                }
                else
                {
                    Console.WriteLine("MENOR DE EDAD");
                }
            }
            else
            {
                Console.WriteLine("error");
            }
            

        
            

    
        
        
    
        }
    }
}
