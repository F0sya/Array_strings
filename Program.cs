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

            StringBuilder sb = new StringBuilder();

            string[] words = sentence.Split(' ');
            int sum = 0;
            string new_word = "";
            foreach(var word in words)
            {
                for(int i = word.Length - 1; i >= 0; i--)
                {
                    new_word = new_word + word[i];
                }
                sb.Append(new_word + " ");
                new_word = "";
            }
            Console.WriteLine($"Amount of words in this sentence: {sb}");
            }
    }
}
