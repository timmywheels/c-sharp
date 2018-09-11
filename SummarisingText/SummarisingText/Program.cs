using System;


namespace SummarisingText
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentence = "This is going to be a really really really really really long long piece of text";
            var summary = StringUtility.SummarizeText(sentence, 50);
            Console.WriteLine(summary);
        }
    }
}
