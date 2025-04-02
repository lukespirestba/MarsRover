using MarsRoverApplication;

namespace MarsRoverTests
{
    public class RoverTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(0, 0)]
        [TestCase(1, 1)]
        public void InitialiseMarsRoverCoordinates(int initalXCoordinate, int initalYCoordinate)
        {
            Rover rover = new Rover(xCoordinate: initalXCoordinate, yCoordinate: initalYCoordinate, "N");

            Assert.That(rover.CurrentCoordinate.X, Is.EqualTo(initalXCoordinate));
            Assert.That(rover.CurrentCoordinate.Y, Is.EqualTo(initalYCoordinate));
        }

        [TestCase("N")]
        [TestCase("S")]
        [TestCase("E")]
        [TestCase("W")]
        public void InitialiseMarsRoverDirection(string direction)
        {
            Rover rover = new Rover(0, 0, direction);

            Assert.That(rover.Direction, Is.EqualTo(direction));
        }
    }
}