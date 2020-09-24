using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb2._2
{
    public class Rectangle
    {
        public double side1, side2;

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        public double AreaCalculator()
        {
            double ploshcha = this.side1 * this.side2;
            return ploshcha;
        }

        public double PerimeterCalculator()
        {
            double perimeter = (this.side1 + this.side2) * 2;
            return perimeter;
        }

        public double Area
        {
            get { return AreaCalculator(); }
        }
        public double Perimeter
        {
            get { return PerimeterCalculator(); }
        }

        
    }

    class Program
    {
    
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть довжину першої сторони: ");
            double side1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введiть довжину другої сторони: ");
            double side2 = Convert.ToDouble(Console.ReadLine());

            var rectangle = new Rectangle(side1, side2) ;
            Console.WriteLine("Площа: {0} \nПериметр: {1}", rectangle.Area, rectangle.Perimeter) ;
            Console.ReadLine();
        }
    }
}
