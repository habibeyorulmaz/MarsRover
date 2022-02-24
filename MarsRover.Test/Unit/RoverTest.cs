
using MarsRover.Model;
using System;
using Xunit;

namespace MarsRover.Test.Unit
{

    public class RoverTest
    {
        [Fact]
        public void RoverIsNotNull()
        {
            var rover = new Rover(new RoverPlateau(3, 4), new RoverPositioning(1, 2, Enum.Directions.N), "LMLMLMLMM");
           
            Assert.NotNull(rover);
        }


        [Fact]
        public void PlateauHorizontalSizeLessThanRoverHorizontalPozition()
        {
            var exception = Assert.Throws<Exception>(() => new Rover(new RoverPlateau(3, 3), new RoverPositioning(4, 1, Enum.Directions.N), "LMLMLMLMM"));
            Assert.Equal($"Plateau horizontal size cannot be less than rover horizontal position", exception.Message);
        }

        [Fact]
        public void PlateauVerticalSizeLessThanRoverVerticalPozition()
        {
            var exception = Assert.Throws<Exception>(() => new Rover(new RoverPlateau(3, 3), new RoverPositioning(1, 4, Enum.Directions.N), "LMLMLMLMM"));
            Assert.Equal($"Plateau vertical size cannot be less than rover vertical position", exception.Message);
        }

        [Fact]
        public void MovementCommandIsNull()
        {
            var value = default(string);
            var exception = Assert.Throws<ArgumentNullException>(() => new Rover(new RoverPlateau(3, 3), new RoverPositioning(1, 4, Enum.Directions.N), value));
            Assert.Equal($"Value cannot be null. (Parameter 'movementCommand')", exception.Message);
        }
    }
}
