using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter number of columns(N): ");
                int n = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter number of rows(M): ");
                int m = Convert.ToInt32(Console.ReadLine());

                int[,] array = ReadArray(n, m);
                Console.WriteLine("Array: ");
                print(array);
                int minRow = findRow(array);
                Console.WriteLine($"Row with smallest sum: {minRow}");
            } 
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.Read();
        }
        static int[,] ReadArray(int column, int row)
        {
            int[,] array = new int[row, column];

            Console.WriteLine($"Enter {column}x{row} elements for the array:");

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write($"Element at row {i + 1}, column {j + 1}: ");
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            return array;
        }
        static void print(int[,] array)
        {
            int row = array.GetLength(0);
            int column = array.GetLength(1);

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static int findRow(int[,] array)
        {
            int row = array.GetLength(0);
            int column = array.GetLength(1);

            int minSum = int.MaxValue;
            int minRow = -1;

            for (int i = 0; i < row; i++)
            {
                int rowSum = 0;
                for (int j = 0; j < column; j++)
                {
                    rowSum += array[i, j];
                }

                if (rowSum < minSum)
                {
                    minSum = rowSum;
                    minRow = i;
                }
            }

            return minRow;
        }
    }
}
