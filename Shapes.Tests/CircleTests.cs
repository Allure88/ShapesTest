using Shapes.Core;

namespace Shapes.Tests
{
    public class CircleTests
    {
        [Test]
        public void Circle_CalculateArea_ValidRadius()
        {
            // Arrange
            double expectedArea =Math.PI * 25;

            // Act
            var circle = new Circle(5);

            // Assert
            Assert.That(circle.GetArea(), Is.EqualTo(expectedArea).Within(0.001));
        }

        [Test]
        public void Circle_InvalidRadius_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => new Circle(-1));
        }
    }
}
