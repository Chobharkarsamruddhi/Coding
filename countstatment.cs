using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace countingstring
{
    using System;

    class Program
    {
        static int CountStatements(string paragraph)
        {
            string[] sentences = paragraph.Split('.', '!', '?');
            int statementCount = 0;

            foreach (string sentence in sentences)
            {
                if (!string.IsNullOrWhiteSpace(sentence))
                    statementCount++;
            }

            return statementCount;
        }

        static void Main(string[] args)
        {
            string paragraph = "C# is a powerful and versatile programming language. It is widely used in software development!.hiii what a wonderfull chatbgpt";
            int numStatements = CountStatements(paragraph);
            Console.WriteLine("Number of statements: " + numStatements);
            Console.ReadLine();

        }
    }




}
