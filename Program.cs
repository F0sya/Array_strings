namespace Array_strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = 10;
            var arr = new int[size];
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
                arr[i] = random.Next(lowerMaxRandomBound,upperMaxRandomBound);
            }

            Console.WriteLine("The array is: ");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\nEnter a number:");
            int number = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for(int i = 0; i < size; i++)
            {
                if (arr[i] < number)
                {
                    count++;
                }
            }

            Console.WriteLine($"Amount of numbers in array smaller than {number} : {count}");

        }
    }
}
