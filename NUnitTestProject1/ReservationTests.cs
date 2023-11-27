using TestNinja.Fundamentals;

namespace NUnitTestProject1
{
    [TestFixture]
    public class ReservationTests
    {
        [SetUp]
        public void Setup()
        {
            var reservation = new Reservation();
            var user = new User();
        }

        [Test]
        public void CacelBy_IsAdmin_ReturnTrue()
        {
            //arrange
            var reservation = new Reservation();

            //act
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true }); 

            //assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void CacelBy_IsManageUser_ReturnTrue()
        {
            //arrange
            var user = new User();
            var reservation = new Reservation { MadeBy = user};

            //act
            var result = reservation.CanBeCancelledBy(user);

            //assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void CacelBy_IsSomeOneElse_ReturnFalse()
        {
            //arrange
            var reservation = new Reservation { MadeBy = new User()};

            //act
            var result = reservation.CanBeCancelledBy(new User());

            //assert
            Assert.That(result, Is.False);
        }
    }
}