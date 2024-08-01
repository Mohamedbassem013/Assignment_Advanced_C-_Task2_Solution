using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Advanced_C__Task2
{
    internal class Helper
    {
        public static ArrayList SetArray()
        {
            ArrayList array = new ArrayList();

            Console.Write("Please Enter the size of your Ordinary Array: ");
            if (int.TryParse(Console.ReadLine(), out int size))
            {
                array = new ArrayList(size);
                Console.WriteLine($"Please Enter your array elements?");
                for (int i = 0; i < size; i++)
                {
                    Console.Write($"Element No.{i + 1}: ");
                    string? input = Console.ReadLine();

                    if (input == null)
                    {
                        Console.WriteLine("Invalid input. Please try again.");
                        i--;
                        continue;
                    }
                    if (int.TryParse(input, out int intValue))
                    {
                        array.Add(intValue);
                    }
                    else if (double.TryParse(input, out double doubleValue))
                    {
                        array.Add(doubleValue);
                    }
                    else
                    {
                        array.Add(input);
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer size number for your array!");
            }

            return array;
        }

        public static void ReverseArrayList(ArrayList array)
        {
            int count = array.Count;
            for (int i = 0; i < count / 2; i++)
            {
                Swap(array, i, count - i - 1);
            }
        }

        public static void Swap(ArrayList array, int index1, int index2)
        {
            if (array is not null)
            {
                object? temp = array[index1];
                array[index1] = array[index2];
                array[index2] = temp;
            }
        }

        public static void PrintArrayList(ArrayList array)
        {
            foreach (var element in array)
            {
                Console.Write($"{element} ");
            }
        }
    }
}
