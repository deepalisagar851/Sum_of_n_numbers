
using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Display(int n)
        {int sum=0;
            for (int i = 1; i <= n; i++)
            {
                sum = sum +i;
                Console.WriteLine(i);
            }
            Console.WriteLine("The Sum Of Numbers is :"+sum);
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Input the Limit of N numbers");
            int n = Convert.ToInt32(Console.ReadLine());
            
            Display(n);


        }
    }
}
