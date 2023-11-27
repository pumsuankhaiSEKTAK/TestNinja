using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

//Testing void method

namespace NUnitTestProject1
{
    [TestFixture]
    public class ErrorLoggerTests
    {
        [Test]
        public void Log_WhenCalled_SetThaLastErrorProperty()
        {
            var logger = new ErrorLogger();
            logger.Log("a");

            Assert.That(logger.LastError, Is.EqualTo("a"));
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void Log_InvalidError_ThrowArgumentNullException(string error)
        {
            var logger = new ErrorLogger();

            //logger.Log(error);

            Assert.That(() => logger.Log(error), Throws.ArgumentNullException);
     

        }

        [Test]
        public void Log_ValidErrors_RaiseErrorLoggedEvent()
        {
            var logger = new ErrorLogger();

            var Id = Guid.Empty;

            logger.ErrorLogged += (sender, args) => { Id = args; };

            logger.Log("a");

            Assert.That(Id, Is.Not.EqualTo(Guid.Empty));
        }

        //[Test]
        //public void OnErrorLogged_WhenCalled_RaiseEvent()
        //{
        //    var logger = new ErrorLogger();

        //    logger.OnErrorLogged();

        //    Assert.That(true);
        //}
    }
}
