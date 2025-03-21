using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Point[] points = new Point[4]
{
                new Point(3, 4),
                new Point(7, 4),
                new Point(7, 6),
                new Point(3, 6)
        };
            for(int i = 0; i<points.Length; i++)
            {
                Console.WriteLine(ShowInfo[i]);
            }
        Console.ReadKey();

        }
    }
}
