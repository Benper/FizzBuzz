using FizzBuzzBuisness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create FizzBuzzService as IFizzBuzzService
            IFizzBuzzService fizzbuzzervice = new FizzBuzzService();

            //Loop through resultlist
            foreach (var item in fizzbuzzervice.GetFizzBuzz(100))
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
