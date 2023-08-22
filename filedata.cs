using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace copy_data_fromone
{
    using System;
    using System.IO;

    class Program
    {
        static void CopyFile(string sourceFile, string destinationFile)
        {
            try
            {
                string data = File.ReadAllText(sourceFile);
                File.WriteAllText(destinationFile, data);
                Console.WriteLine("File copied successfully!");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Source file not found.");
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Enter the source file location: ");
            string sourceFile = Console.ReadLine();

            Console.Write("Enter the destination file location and name: ");
            string destinationFile = Console.ReadLine();

            CopyFile(sourceFile, destinationFile);
        }
    }

}
