using System;
using System.Runtime.CompilerServices;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float money;
            int years;
            int percent;

            Console.Write("Enter amount of money,in order to invent:");
            money = Convert.ToSingle(Console.ReadLine());

            Console.Write("How many years open the cash");
            years = Convert.ToInt32(Console.ReadLine());
            Console.Write("How many percentage do you want?");
            percent = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < years; i++)
            {
                money += money / 100 * percent;
                Console.WriteLine("In this year you have" + money);
                Console.ReadKey();
            }
        }
    }
}
