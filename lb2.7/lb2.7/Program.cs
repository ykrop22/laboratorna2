using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb2._7
{
    class Employee
    {
        private string _name, _sname;
        private int _exp, _position;
        private double salary, tax;

        public void emplinf(string name, string sname, int exp, int position)
        {
            this._name = name;
            this._sname = sname;
            this._exp = exp;
            this._position = position;
        }
        public void salaryCalculator()
        {
            salary = 10000 + (500 * _exp * (_position + 1) * 0.7f);
            tax = salary * 0.2f;
        }
        public void writeinf()
        {
            Console.WriteLine($"\nIм'я спiвробiтника: {_name}\nПрiзвище спiвробiтника: {_sname}\nПосада: {_exp}\nЗарплата: {salary}\nПодаток: {tax}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee empl = new Employee();

            empl.emplinf("Iлля", "Гайдай", 1, 3);
            empl.salaryCalculator();

            empl.writeinf();
            Console.Read();
        }
    }
}
