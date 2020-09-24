using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb2._8
{
    class Invoice
    {
        private int _account, _quantity, _price;
        private string _customer, _provider, _article;

        public void info(int account, string customer, string provider)
        {
            this._account = account;
            this._customer = customer;
            this._provider = provider;
        }

        public void item(string article, int quantity, int price)
        {
            this._article = article;
            this._quantity = quantity;
            this._price = price;
        }

        public int pricenotax()
        {
            int price = _quantity * _price;
            return price;
        }
        public double pricetax()
        {
            double price = _quantity * _price * 1.2f;
            return price;
        }

        public void write()
        {
            Console.WriteLine($"Акаунт: {_account}\nПокупець: {_customer}\nПродавець: {_provider}\nIнформацiя про продукт:\nПредмет: {_article}\nКiлькiсть: {_quantity}\nЦiна за штуку: {_price}\nЦiна без податку: {pricenotax()}\nЦiна з податком: {pricetax()}");
            Console.Read();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Invoice zakaz1 = new Invoice();
            zakaz1.info(63456, "Iлля", "Владислав");
            zakaz1.item("Автомобiль", 1, 10000);

            zakaz1.write();
        }
    }
}
