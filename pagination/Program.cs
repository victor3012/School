using System;

namespace pagination
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] array =
            {
                "University", "Java", "JavaScript", "PHP", "HTML",
                "CSS", "Spring", "Vue", "Angular", "CSS", "CSS"
            };

            int wordsPerPage = Convert.ToInt32(Console.ReadLine());
            int selectedPage = Convert.ToInt32(Console.ReadLine());
            String searchingPhrase = Console.ReadLine();

            Boolean hasFound = false;
            for (int i = (selectedPage - 1) * wordsPerPage; i < selectedPage * wordsPerPage; i++)
            {
                if (array[i].Contains(searchingPhrase))
                {
                    Console.WriteLine("Found this element: " + array[i]);
                    hasFound = true;
                }
            }

            if (!hasFound)
            {
                Console.WriteLine("No result.");
            }
            int totalElements = array.Length;
            Console.WriteLine("Total Items: " +totalElements);
            int pages = Convert.ToInt32(Math.Floor(totalElements * 1.0 / wordsPerPage));
            Console.WriteLine("Total Pages: " +pages);
        }
    }
}