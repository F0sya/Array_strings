using System.Text;

namespace Array_strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            Console.WriteLine("Enter the lower bound of the random number: ");
            var lowerMaxRandomBound = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the upper bound of the random number: ");
            var upperMaxRandomBound = Convert.ToInt32(Console.ReadLine());
            if (lowerMaxRandomBound > upperMaxRandomBound)
            {
                (lowerMaxRandomBound, upperMaxRandomBound) = (upperMaxRandomBound, lowerMaxRandomBound);
            }
            Console.WriteLine("Enter the size of the array: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    arr[i, j] = random.Next(lowerMaxRandomBound, upperMaxRandomBound);
                }
            }

            Console.WriteLine("The array is: ");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        
            float max = arr[0, 0];
            float min = arr[0, 0];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (arr[i, j] > max)
                    {
                        max = arr[i, j];
                    }
                    if (arr[i, j] < min)
                    {
                        min = arr[i, j];
                    }
                }
            }
            Console.WriteLine($"Max = {max}");
            Console.WriteLine($"Min = {min}");
        }
    }
}
