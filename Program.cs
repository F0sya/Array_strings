using System.Text;

namespace Array_strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {7,6,5,8,4,7,6,5,8,7,6,5};

            string str = "";
            foreach(var item in arr)
            {
                str += item + " ";
            }

            Console.WriteLine("The array is: ");
            Console.WriteLine(str);

            Console.WriteLine("\nEnter a number:");

            string number = Console.ReadLine();
            int count = 0;
            int i = 0;
            
            while( (i = str.IndexOf(number,i, StringComparison.Ordinal)) != -1)
            {
                count++;
                i += number.Length;

            }
            
            Console.WriteLine($"Amount of substrings : {count}");

        }
    }
}
