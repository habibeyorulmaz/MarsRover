using MarsRover.Model;
using System;
using Xunit;

namespace MarsRover.Test.Unit
{

    public class RoverPlateauTest
    {
        [Fact]
        public void RoverPlateauIsNotNull()
        {
            var roverPlateau = new RoverPlateau(3, 4);
            Assert.NotNull(roverPlateau);
        }

        [Fact]
        public void RoverPlateauAreEqual()
        {
            var roverPlateau1 = new RoverPlateau(3, 4);
            var roverPlateau2 = new RoverPlateau(3, 4);

            var areEqual1 = roverPlateau1.StartingHorizantalPosition.Equals(roverPlateau2.StartingHorizantalPosition);
            var areEqual2 = roverPlateau1.StartingVerticalPosition.Equals(roverPlateau2.StartingVerticalPosition);
            var areEqual3= roverPlateau1.EndingHorizantalPosition.Equals(roverPlateau2.EndingHorizantalPosition);
            var areEqual4 = roverPlateau1.EndingVerticalPosition.Equals(roverPlateau2.EndingVerticalPosition);

            Assert.True(areEqual1);
            Assert.True(areEqual2);
            Assert.True(areEqual3);
            Assert.True(areEqual4);
        }

        
        [Fact]
        public void RoverPlateauWithNegativeHorizontalSize()
        {
            var exception = Assert.Throws<Exception>(() => new RoverPlateau(-1, 4));
            Assert.Equal($"Plateau ending horizontal position cannot be equal or less than zero", exception.Message);

        }

        [Fact]
        public void RoverPlateauWithNegativeVerticalSize()
        {
            var exception = Assert.Throws<Exception>(() => new RoverPlateau(3, -4));
            Assert.Equal($"Plateau ending vertical position cannot be equal or less than zero", exception.Message);

        }
    }
}
