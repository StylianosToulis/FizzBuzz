using System;

namespace Fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Checks if the number is divisilbe by both of them
            for(int i = 1; i<=100;i++)
            {
                if(i%3==0 && i%5==0)
                {
                    Console.WriteLine("Fizzbuzz");
                
                }
               //checks if its a multiple of 3
                else if(i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if(i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
                
            }
            Console.ReadKey();
        }
    }
}
