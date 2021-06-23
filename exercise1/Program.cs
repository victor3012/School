using System;

namespace homework
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input - array's length
            int n = Convert.ToInt32(Console.ReadLine());
            // Declaring the array (with "n" elements)
            int[] array = new int[n];
            // Filling the array
            for (int i = 0; i < n; i++)
            {
                // for each line -> filling the array's element ("i")
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Creating a sum variable (will be used to store the total sum)
            int sum = 0;

            // Going through every element in the array
            foreach (int element in array)
            {
                // Check: if the number is even ( % 2 == 0)
                if (element % 2 == 0)
                {
                    // If it is even -> adding its squared value to the sum
                    sum += element * element;
                }
            }
            
            // Priting the sum 
            Console.WriteLine(sum);
        }
    }
}