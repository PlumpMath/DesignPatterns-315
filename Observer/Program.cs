using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Numbers numbers = new Numbers();
            Number number = new Number(1908);
            numbers.RegisterObserver(number);

            Number number2 = new Number(8);
            numbers.RegisterObserver(number2);
         
            Number number3 = new Number(908);
            numbers.RegisterObserver(number3);

            Number number4 = new Number(1515);
            numbers.RegisterObserver(number4);

            Number number5=numbers.ConfigurationOfNumbers();
            numbers.RegisterObserver(number5);

            Console.WriteLine("Collection of numbers:");
            Console.WriteLine();

            foreach (var item in numbers)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine();
            numbers.RemoveObserver(number5);
            Console.WriteLine("Collection of numbers without number {0}:", number5);
            Console.WriteLine();

            foreach (var item in numbers)
            {
                Console.WriteLine(item.ToString());
            }
          
            Console.Read();
        }
    }
}
