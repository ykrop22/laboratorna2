using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb2._4
{
    public class Point
    {
        private int I, K;

        
        public int i { get { return I; } }
        public int k { get { return K; } }
        public string name;
        public Point(int i, int k, string nname)
        {
            this.I = i;
            this.K = k;
            this.name = nname;
        }
    }
}
