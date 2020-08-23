using System;

namespace AllLongestStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array length: ");
            int length = int.Parse(Console.ReadLine());
            string[] array = new string[length];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Enter your string value: ");
                array[i] = Console.ReadLine();
            }
            Console.Write("All Longest Strings: ");
            for (int i = 0; i < allLongestStrings(array).Length; i++)
            {
                Console.Write(allLongestStrings(array)[i] + " "); 
            }
            Console.ReadLine();
        }
        static string[] allLongestStrings(string[] inputArray)
        {
            int length = 0;
            int count = 0;
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (length < inputArray[i].Length)
                {
                    length = inputArray[i].Length;
                }
            }

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i].Length == length)
                    count++;
            }

            string[] array = new string[count];
            int index = 0;

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i].Length == length)
                {
                    array[index] = inputArray[i];
                    index++;
                }
            }
            return array;
        }
    }
}
