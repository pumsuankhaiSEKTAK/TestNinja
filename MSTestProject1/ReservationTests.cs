using TestNinja.Fundamentals;

namespace MSTestProject1
{
    [TestClass]
    public class ReservationTests
    {
        [TestMethod]
        public void CacelBy_IsAdmin_ReturnTrue()
        {
            //arrange
            var reservation = new Reservation();

            //act
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });

            //assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CacelBy_IsManageUser_ReturnTrue()
        {
            //arrange
            var user = new User();
            var reservation = new Reservation { MadeBy = user};

            //act
            var result = reservation.CanBeCancelledBy(user);

            //assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CacelBy_IsSomeOneElse_ReturnFalse()
        {
            //arrange
           var reservation = new Reservation { MadeBy = new User()};

            //act
            var result = reservation.CanBeCancelledBy(new User());

            //assert
            Assert.IsFalse(result);
        }
    }
}