using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb2._4
{
    class Figure
    {

        private Point Q,W,E,R,T;


        public string figurename;

        public Figure(Point Q, Point W, Point E)
        {
            this.Q = Q;
            this.W = W;
            this.E = E;
            this.figurename = "Трикутник";
        }
        public Figure(Point Q, Point W, Point E, Point R)
        {
            this.Q = Q;
            this.W = W;
            this.E = E;
            this.R = R;
            this.figurename = "Чотирикутник";
        }
        public Figure(Point Q, Point W, Point E, Point R, Point T)
        {
            this.Q = Q;
            this.W = W;
            this.E = E;
            this.R = R;
            this.T = T;
            this.figurename = "Пятикутник";
        }

        public double LengthSide(Point Q, Point W)
        {
            double length = Math.Sqrt(Math.Pow((Q.i - W.i), 2) + Math.Pow(Q.k - W.k, 2));
            return length;
        }

        public void PerimeterCalculator()
        {
            if (T != null)
            {
                Console.WriteLine($"Периметр: {(LengthSide(Q, W) + LengthSide(W, E) + LengthSide(E, R) + LengthSide(R, T) + LengthSide(T, Q))}");
            }
            else if (R != null)
            {
                Console.WriteLine($"Периметр: {(LengthSide(Q, W) + LengthSide(W, E) + LengthSide(E, R) + LengthSide(R, T))}");
            }
            else
            {
                Console.WriteLine($"Периметр: {(LengthSide(Q, W) + LengthSide(W, E) + LengthSide(E, R))}");
            }


        }
    }

}
