using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace _11.file_io_input_output
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string fullPath = "data.txt";
            using (StreamWriter writer = new StreamWriter(fullPath))
            {
                writer.WriteLine("Monica Rathbun");
                writer.WriteLine("Vidya Agarwal");
                writer.WriteLine("Mahesh Chand");
                writer.WriteLine("Vijay Anand");
                writer.WriteLine("Jignesh Trivedi");
            }
            string readText = File.ReadAllText(fullPath);
            Console.WriteLine(readText);
        }
    }
}
