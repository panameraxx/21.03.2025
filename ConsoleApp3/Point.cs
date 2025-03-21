using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Point
    {
        private double x;
        private double y;
        static int count = 1;
        public double X { get { return x; } set { x = value; } }
        public double Y { get { return y; } set { y = value; } }
        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
            count++;
        }  
        public void ShowInfo()
        {
            Console.WriteLine($"x = {X} y= {Y}");
        }
    }
}
