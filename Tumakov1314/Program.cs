using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov1314
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 14.1");
            BankAccount bankAccount1 = new BankAccount(AccountType.Actual, 100);
            BankAccount bankAccount2 = new BankAccount(AccountType.Savings, 250);
            Console.WriteLine($"Хеш = {bankAccount1.GetHashCode()}");
            Console.WriteLine($"acc1 == acc2 ({bankAccount1 == bankAccount2})");
            bankAccount1.DumpToScreen();

            Console.WriteLine("Задание 14.2");
            Rationals rational = new Rationals();
            object[] objArray = typeof(Rationals).GetCustomAttributes(false);
            foreach (var item in objArray)
            {
                DeveloperInfoAttribute attr = item as DeveloperInfoAttribute;
                if (attr != null)
                {
                    Console.WriteLine($"Имя разработчика: {attr.Developer}");
                    Console.WriteLine($"Дата разработки: {attr.Date}");
                }

            }

        }
    }
}
