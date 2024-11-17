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

            string vowels = "aeiouy";
            int sum = 0;

            for (int i = 0; i < sentence.Length; i++)
            {
                if (vowels.Contains(sentence[i]))
                {
                    sum++;
                }
            }
            Console.WriteLine($"Amount of vowels in sentence: {sum}");
        }
    }
}
