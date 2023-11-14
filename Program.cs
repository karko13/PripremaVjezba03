using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PripremaVjezba03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upisite neku recenicu ");
            string x = Console.ReadLine();
            string[] x1 = x.Split(' ');
            int b = x1.Length;
            Console.WriteLine(x1[0]);
            Console.WriteLine(x1[b-1]);
            Console.ReadKey();

        }
    }
}
