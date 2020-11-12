using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JoliBateau;

namespace TestsJoliBateau
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
            string a = System.Reflection.Assembly.GetExecutingAssembly().Location;
            
            Console.WriteLine(System.IO.Path.GetDirectoryName(a));
            Console.ReadKey();
        }
    }
}
