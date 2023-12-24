using System.IO;

namespace DriveMapper
{


    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Listing contents of C Drive...");
                Console.WriteLine($"\tDIRECTORIES");
                foreach (var dir in Directory.EnumerateDirectories(@"C:\"))
                {
                    Console.WriteLine($"\t\t{dir}");
                }
                Console.WriteLine($"\tFILES");
                //foreach (var file in Directory.GetFiles(@"C:\"))
                foreach (var file in Directory.GetFiles(@"C:\"))
                {
                    Console.WriteLine($"\t\t{file}");
                }
            }
            else
            {
                string currDir = Directory.GetCurrentDirectory();

                Console.WriteLine("Listing contents of current directory...");
                Console.WriteLine($"\tDIRECTORIES");
                foreach (var dir in Directory.EnumerateDirectories(currDir))
                {
                    Console.WriteLine($"\t\t{dir}");
                }
                Console.WriteLine($"\tFILES");
                foreach (var file in Directory.GetFiles(currDir))
                {
                    Console.WriteLine($"\t\t{file}");
                }
            }

        }
    }
}