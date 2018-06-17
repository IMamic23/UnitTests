using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class ReservationTests
    {
        [Test]
        public void CanBeCanceledBy_UserIsAdmin_ReturnsTrue()
        {
            // Arrange
            var reservation = new Reservation();

            // Act
            var result = reservation.CanBeCancelledBy(new User() {IsAdmin = true});

            // Assert
            Assert.IsTrue(result);
            Assert.That(result, Is.True);
            Assert.That(result == true);
        }

        [Test]
        public void CanBeCanceledBy_UserMadeReservation_ReturnsTrue()
        {
            // Arrange
            var user = new User();
            var reservation = new Reservation {MadeBy = user};

            // Act
            var result = reservation.CanBeCancelledBy(user);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void CanBeCanceledBy_UserCancelingOtherUsersReservation_ReturnsFalse()
        {
            // Arrange
            var user = new User();
            var user2 = new User();
            var reservation = new Reservation { MadeBy = user };

            // Act
            var result = reservation.CanBeCancelledBy(user2);

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void CanBeCanceledBy_UserIsNotAdmin_ReturnsFalse()
        {
            // Arrange
            var reservation = new Reservation();

            // Act
            var result = reservation.CanBeCancelledBy(new User() { IsAdmin = false });

            // Assert
            Assert.IsFalse(result);
        }
    }
}
