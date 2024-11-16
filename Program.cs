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

            int even_amount = 0,odd_amount=0,unique;

            Console.WriteLine("The array is: ");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }

            for (int i =0; i < size; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    even_amount++;
                }
                if (arr[i] % 2 != 0)
                {
                    odd_amount++;
                }
            }

            Console.WriteLine($"\nAmount of even: {even_amount}\nAmount of odd: {odd_amount}\nAmount of unique: {arr.Distinct().Count()}");
        }
    }
}
