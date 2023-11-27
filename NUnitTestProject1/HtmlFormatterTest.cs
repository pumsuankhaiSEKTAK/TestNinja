using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace NUnitTestProject1
{
    [TestFixture]
    public class HtmlFormatterTest
    {

        //Write a test for String
        [Test]
        public void FormateBold_WhenCalled_ShouldEnclosedString()
        {
            var formmater = new HtmlFormatter();

            var result = formmater.FormatAsBold("abc");

            Assert.That(result, Is.EqualTo("<strong>abc</strong>"));
            //Assert.That(result, Does.StartWith("<strong>"));
        }
    }
}
