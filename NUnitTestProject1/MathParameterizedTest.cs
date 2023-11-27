using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTestProject1
{
    [TestFixture]
    public class MathParameterizedTest
    {
        private TestNinja.Fundamentals.Math _math;

        //Setup
        //Teardown

        [SetUp]
        public void Setup()
        {
            _math = new TestNinja.Fundamentals.Math();
        }


        //write simple test parameterize with testcase
        [Test]
        [TestCase(1, 2, 2)]
        [TestCase(2, 1, 2)]
        [TestCase(1, 1, 1)]
        public void Add_WhenCalled_ReturnSumOfArguments(int a, int b, int expectedResult)
        {

            //act
            var result = _math.Max(a, b);

            //assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }


        //testing an Arrays, check existing of item in arrays
        [Test]
        public void GetOddNumbers_LimitISGreaterThanZero_ReturnOddNumber()
        {
            var result = _math.GetOddNumbers(5);

            //Assert.That(result, Is.Not.Empty);
            //Assert.That(result.Count(), Is.EqualTo(3));

            //Assert.That(result, Does.Contain(1));
            //Assert.That(result, Does.Contain(3));
            //Assert.That(result, Does.Contain(5));

            Assert.That(result, Is.EquivalentTo(new[] { 1, 5, 3, }));

            //to sort the items
            //Assert.That(result, Is.Ordered);

            //chect an item is not duplicate
            //Assert.That(result, Is.Unique);
        }

        
    }
}
