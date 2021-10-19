using System;

namespace _2.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = Convert.ToInt32(Console.ReadLine());
            int numbermin = 0 ;
            int numbermax = 3 ;
            for (int num2 = 0; num1 != num2;)
            {
                while (numbermin < numbermax)
                {

                    num2 = Convert.ToInt32(Console.ReadLine());
                    numbermin++;
                
                    
                    if (num1 == num2)
                    {
                        Console.WriteLine($"{num2} existing in the list");
                    }
                    else
                    {
                        Console.WriteLine($"{num2} not existing in the list");
                    }

                }
            }          
        }
    }
}
