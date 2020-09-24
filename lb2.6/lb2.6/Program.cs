using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb2._6
{
    public class Converter
    {
        private double usd = 28.2549f;
        private double eur = 32.9026f;
        private double rub = 0.366554f;


        public double count;

        public void usdtouahConv()
        {
            Console.WriteLine($"UAH: {this.count * this.usd}");
        }
        public void eurtouahConv()
        {
            Console.WriteLine($"UAH: {this.count * this.eur}");
        }
        public void rubtouahConv()
        {
            Console.WriteLine($"UAH: {this.count * this.rub}");
        }
        public void uahtousdConv()
        {
            Console.WriteLine($"USD: {this.count / this.usd}");
        }
        public void uahtoeurConv()
        {
            Console.WriteLine($"EUR: {this.count / this.eur}");
        }
        public void uahtorubConv()
        {
            Console.WriteLine($"RUB: {this.count / this.rub}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Converter converter = new Converter();
            Console.Write("Перевести можна з гривнi(UAH) в USD,EUR,RUB; або з USD,EUR,RUB в гривню(UAH)!!!\n З якої валюти переводити?(1-USD, 2-EUR, 3-RUB, 4-UAH)");
            int from = Int32.Parse(Console.ReadLine());

           
            
            Console.Write(" В яку валюту?(1-USD, 2-EUR, 3-RUB, 4-UAH)");
            int to = Int32.Parse(Console.ReadLine());
            
            

            Console.Write("Яку кiлькiсть валюти перевести: ");
            converter.count = Convert.ToDouble(Console.ReadLine());



            if (from == 1 & to == 4)
            {
                converter.usdtouahConv();
            }
            else if (from == 2 & to == 4)
            {
                converter.eurtouahConv();
            }
            else if (from == 3 & to == 4)
            {
                converter.rubtouahConv();
            }
            else if (from == 4 & to == 1)
            {
                converter.uahtousdConv();
            }
            else if (from == 4 & to == 2)
            {
                converter.uahtoeurConv();
            }
            else if (from == 4 & to == 3)
            {
                converter.uahtorubConv();
            }
            else
            {
                Console.Write("Ви щось зробили неправильно!!!");
            }
            Console.Read();
        }
    }
}
