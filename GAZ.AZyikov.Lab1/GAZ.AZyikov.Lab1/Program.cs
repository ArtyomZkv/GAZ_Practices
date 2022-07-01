using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace GAZ.AZyikov.Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("DataFIle.txt");
            string line = reader.ReadLine();
            while (line != null)
            {
                line = line.Replace(",", " y:");
                Console.WriteLine("x:" + line);
                line = reader.ReadLine();
            }
            Console.Read();

        }
    }
}
