using FizzBuzzBuisness;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzTester
{
    public class FizzBuzzTester
    {

        [TestFixture]
        public class FizzBuzzTest
        {
            FizzBuzzService fizzbuzzservice = new FizzBuzzService();

            [Test]
            public void Divisibleby3()
            {
                string ret = fizzbuzzservice.GetText(3);
                Assert.AreEqual("Fizz", ret);
            }

            [Test]
            public void Divisibleby5()
            {
                string ret = fizzbuzzservice.GetText(5);
                Assert.AreEqual("Buzz", ret);
            }

            [Test]
            public void Divisibleby3and5()
            {
                string ret = fizzbuzzservice.GetText(15);
                Assert.AreEqual("FizzBuzz", ret);
            }

            [Test]
            public void Notdivisibleby3or5()
            {
                string ret = fizzbuzzservice.GetText(13);
                Assert.AreEqual("13", ret);
            }
        }
    }
}
