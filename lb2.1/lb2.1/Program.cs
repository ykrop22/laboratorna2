using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb2._1
{
    public class Address
    {
        public string country { get; set; }
        public string city { get; set; }
        public string street { get; set; }
        public string index { get; set; }
        public string house { get; set; }
        public string apartment { get; set; }

        public void writeAddress()
        {
            Console.WriteLine($"Ваша адреса: {street}, будинок №{house}, кв.{apartment}, {country}, {city}, {index}");
            Console.Read();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address();
            Console.WriteLine("Ваша країна: ");
            address.country = Console.ReadLine();
            Console.WriteLine("Ваше мiсто: ");
            address.city = Console.ReadLine();
            Console.WriteLine("Поштовий iндекс: ");
            address.index = Console.ReadLine();
            Console.WriteLine("Назва вулицi: ");
            address.street = Console.ReadLine();
            Console.WriteLine("Номер будинку: ");
            address.house = Console.ReadLine();
            Console.WriteLine("Квартира №: ");
            address.apartment = Console.ReadLine();

            address.writeAddress();

        }

    }
    
    
}
