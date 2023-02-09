/*
    Author: SM Zaman
    Date: 02/09/2023
    Describtion: Methods
*/

using System;

namespace Methods_Application
{
    class Program
    {

        static int[] random_array(int array_len)
        {
            Random random = new Random();
            int[] MyArray = new int[array_len];
            for (int i = 0; i < array_len; i++)
            {
                MyArray[i] = random.Next(10,50);
            }
            return MyArray;
        }

        static int sum(int[] array)
        {
            int sum = 0;
            foreach (int item in array)
            {
                sum = sum + item;
            }
            return sum;
        }

        static void Main(string[]  args)
        {
            try
            {

                Console.WriteLine("Enter an integer Between 5 and 15");
                int input = int.Parse(Console.ReadLine());

                if (input >= 5 && input <= 15)
                {

                    int[] sampleArray = random_array(input);

                    Console.WriteLine("The elment in the random array are: ");
                    foreach (int elment in sampleArray)
                    {
                        Console.Write(elment + " ");
                    }

                    Console.WriteLine(" ");
                    Console.WriteLine("The sum is: " + sum(sampleArray));
                }
                else

                {
                    Console.Write("The entered value is not within the range of 5 and 15");
                }

                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("Please enter an integer value!");
            }
        }
    }
}

