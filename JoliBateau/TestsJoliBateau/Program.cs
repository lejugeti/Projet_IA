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
            Point p = new Point(100, 100);
            Point.DistNoeuds = 1;
            Point.Pavage = 1;

            List<GenericNode> l = p.GetListSucc();
            l.Cast<Point>();
            foreach(Point n in l)
            {
                Console.WriteLine($"({n.X}, {n.Y})");
            }
            Console.ReadKey();
        }
    }
}
