
using MarsRover.Model;
using System;
using Xunit;

namespace MarsRover.Test.Unit
{

    public class RoverPositioningTest
    {
        [Fact]
        public void RoverPositioningIsNotNull()
        {
            var roverPositioning = new RoverPositioning(3, 4, Enum.Directions.N);
            Assert.NotNull(roverPositioning);
        }

        [Fact]
        public void RoverPositioningAreEqual()
        {
            var roverPositioning1 = new RoverPositioning(3, 4, Enum.Directions.N);
            var roverPositioning2 = new RoverPositioning(3, 4, Enum.Directions.N);

            var areEqual1 = roverPositioning1.HeadingDirection.Equals(roverPositioning2.HeadingDirection);
            var areEqual2 = roverPositioning1.HorizontalPosition.Equals(roverPositioning2.HorizontalPosition);
            var areEqual3 = roverPositioning1.VerticalPosition.Equals(roverPositioning2.VerticalPosition);
           
            Assert.True(areEqual1);
            Assert.True(areEqual2);
            Assert.True(areEqual3);
        }


        [Fact]
        public void RoverPositioningWithNegativeHorizontalPosition()
        {
            var exception = Assert.Throws<Exception>(() => new RoverPositioning(-1, 4, Enum.Directions.N));
            Assert.Equal($"Rover horizontal position cannot be equal or less than zero", exception.Message);
        }

        [Fact]
        public void RoverPositioningWithNegativeVerticalPosition()
        {
            var exception = Assert.Throws<Exception>(() => new RoverPositioning(3, -4, Enum.Directions.N));
            Assert.Equal($"Rover vertical position cannot be equal or less than zero", exception.Message);
        }

    }
}
