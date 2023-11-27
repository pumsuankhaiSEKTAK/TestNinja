using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace NUnitTestProject1
{
    [TestFixture]
    public class MathTest
    {
        private TestNinja.Fundamentals.Math _math;

        //Setup
        //Teardown

        [SetUp]
        public void Setup()
        {
            _math = new TestNinja.Fundamentals.Math();
        }



        [Test]
        public void Add_WhenCalled_ReturnSumOfArguments()
        {
           
            //act
            var result = _math.Add(1, 2);

            //assert
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void Max_FirstArguymentIsGreater_ReturnFirstArgument()
        {
           
            var result = _math.Max(2, 1);

            Assert.That(result, Is.EqualTo(2));

        }

        [Test]
        public void Max_SecondArgumentIsGreater_ReturnSecondArgument()
        {
            
            var result = _math.Max(1, 3);

            Assert.That(result, Is.EqualTo(3));

        }

        [Test]
        public void Max_ArgumentsAreEqual_ReturnSameArgument()
        {

            var result = _math.Max(2, 2);

            Assert.That(result, Is.EqualTo(2));

        }
    }
}
