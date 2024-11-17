using System.Text;

namespace Array_strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = 10;
            var first_arr = new int[size];
            var second_arr = new int[size];
            var copy_arr = new int[size*2];
            var random = new Random();
            Console.WriteLine("Enter the lower bound of the random number: ");
            var lowerMaxRandomBound = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the upper bound of the random number: ");
            var upperMaxRandomBound = Convert.ToInt32(Console.ReadLine());

            if (lowerMaxRandomBound > upperMaxRandomBound)
            {
                (lowerMaxRandomBound, upperMaxRandomBound) = (upperMaxRandomBound, lowerMaxRandomBound);
            }

            for (int i = 0; i < size; i++)
            {
                first_arr[i] = random.Next(lowerMaxRandomBound, upperMaxRandomBound);
                second_arr[i] = random.Next(lowerMaxRandomBound, upperMaxRandomBound);
            }

            Console.WriteLine("The first array is: ");
            foreach (var item in first_arr)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\nThe second array is: ");
            foreach (var item in second_arr)
            {
                Console.Write(item + " ");
            }

            first_arr.CopyTo(copy_arr, 0);
            second_arr.CopyTo(copy_arr, size);

            var result_arr = from num in copy_arr.Distinct() select num;

            Console.WriteLine("\nThe Result array is: ");
            foreach (var item in result_arr)
            {
                Console.Write(item + " ");
            }
        }
    }
}
