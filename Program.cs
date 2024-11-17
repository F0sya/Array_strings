using System.Diagnostics.Tracing;
using System.Text;

namespace Array_strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a sentence:");
            string sentence = Console.ReadLine();
            Console.Write("Enter a word to find:");
            string substring = Console.ReadLine();

            string[] words = sentence.Split(' ');

            int sum = 0;

            foreach (var word in words)
            {
                if(word == substring)
                {
                    sum++;
                }
            }
            Console.WriteLine($"Amount of words in this sentence: {sum}");
        }
    }
}
