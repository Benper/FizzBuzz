using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzBuisness
{
    /**Interface of FizzBuzzService with GetFizzBuzz method
     * to allow the use of IFizzBuzzService i the main program
     * I am not adding GetText method to show the difference between program and test abilities
    **/
    public interface IFizzBuzzService
    {
        List<string> GetFizzBuzz(int number);
    }

    public class FizzBuzzService : IFizzBuzzService
    {
        public List<string> GetFizzBuzz(int number)
        {
            List<string> returnlist = new List<string>();
            //Loop from 1 to number and add result to returnlist
            for (int i = 1; i <= number; i++)
                returnlist.Add(GetText(i));

            return returnlist;
        }
    
        //Method to determin the return value of a number
        public string GetText(int i)
        {
            String ret = "";

            //Divisible with 3 to add Fizz
            if (i % 3 == 0)
                ret = "Fizz";

            //Divisible with 5 to add Buzz
            if (i % 5 == 0)
                ret = ret + "Buzz";

            //Add number if not divisible by 3 or 5
            if (ret == "")
                ret = i.ToString();

            return ret;
        }
    }
}
