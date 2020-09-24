using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb2._4
{
  

   
    class Program
    {

        static void Main(string[] args)
        {
            Point Q = new Point(0, 0, "point1");
            Point W = new Point(0, 2, "point2");
            Point E = new Point(2, 2, "point3");
            Point R = new Point(0, 2, "point4");

            Figure figure = new Figure(Q, W, E, R);

            Console.WriteLine($"Фiгура: {figure.figurename}");
            figure.PerimeterCalculator();
            

        }
    }
}
