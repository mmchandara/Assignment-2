using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input numbers: ");
            string input = Console.ReadLine();
            try
            {
                char[] inputArray = input.ToCharArray();

                int[] num = Array.ConvertAll(inputArray, i => int.Parse(i.ToString()));

                Console.WriteLine("Elements in Array: ");
                foreach (int i in num)
                {
                    Console.WriteLine(i);
                }

                Console.WriteLine("Reversed Array: ");
                Array.Reverse(num);
                Array.ForEach<int>(num, i => Console.WriteLine(i));

                Console.WriteLine($"The sum is: {num.Sum()}");
            }
            catch (Exception e)
            {
                {
                    Console.WriteLine(e.Message);
                }
            }
            Console.Read();
        }
    }
}
