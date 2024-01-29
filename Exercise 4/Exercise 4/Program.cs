using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input random letters. Enter 0 to stop.");

            Dictionary<char, int> letters = new Dictionary<char, int>();
            try
            {
                while (true)
                {
                    char input = Convert.ToChar(Console.ReadLine());
                    if (input == 0)
                    {
                        break;
                    }
                    if (char.IsLetter(input))
                    {
                        if (letters.ContainsKey(input))
                        {
                            letters[input]++;
                        }
                        else
                        {
                            letters.Add(input, 1);
                        }
                    }
                }
            } 
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("Output: ");
            foreach (KeyValuePair<char, int> pair in letters)
            {
                Console.WriteLine($"{pair.Key} {pair.Value}");
            }
            Console.Read();
        }
    }
}
