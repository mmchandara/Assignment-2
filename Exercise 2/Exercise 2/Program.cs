using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of array(N): ");
            int n;
            
            try
            {
                n = Convert.ToInt32(Console.ReadLine());
                if (n <= 0)
                {
                    Console.WriteLine("Invalid input.");
                    return;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }

            int[] array = ReadArray(n);
            Console.WriteLine("Array Elements: ");
            print(array);
            int small = smallest(array);
            Console.WriteLine($"Smallest position element: {small}");
            Console.Read();
        }
        static int[] ReadArray(int size)
        {
            int[] array = new int[size];

            Console.WriteLine($"Enter {size} elements for the array: ");

            for (int i = 0; i < size; i++)
            {
                Console.Write($"Element {i + 1}: ");
                try
                {
                    array[i] = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    i--;
                }
            }
            return array;
        }

        static void print(int[] array)
        {
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        static int smallest(int[] array)
        {
            int min = array[0];
            int position = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    position = i;
                }
            }
            return position + 1;
        }
    }
}
