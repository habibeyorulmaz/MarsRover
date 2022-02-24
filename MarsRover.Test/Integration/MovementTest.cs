
using MarsRover.Helper;
using MarsRover.Model;
using System;
using Xunit;

namespace MarsRover.Test.Integration
{

    public class MovementTest
    {
        [Fact]
        public void MovementWorksWithoutAnyProblem()
        {
            //Arrange
            var roverPlateau = new RoverPlateau(5, 5);
            var roverPositioning = new RoverPositioning(3, 3, Enum.Directions.E);
            string movementCommand = "MMRMMRMRRM";
            Rover rover = new Rover(roverPlateau, roverPositioning, movementCommand);

            //Act
            var resultRoverInfo = Movement.ExecuteMovementCommand(rover);

            //Assert
            Assert.Equal("5 1 E", resultRoverInfo.GetPositionInfo());
        }
        
        [Fact]
        public void RoverPositionIsOutOfPlateau()
        {
            //Arrange
            var roverPlateau = new RoverPlateau(5, 5);
            var roverPositioning = new RoverPositioning(3, 3, Enum.Directions.E);
            string movementCommand = "MMMMMMMMMM";
            Rover rover = new Rover(roverPlateau, roverPositioning, movementCommand);

            //Act
            var exception = Assert.Throws<Exception>(() => Movement.ExecuteMovementCommand(rover));

            //Assert
            Assert.Equal($"Position out of boundaries (0 , 0) and ({rover.RoverPlateau.EndingHorizantalPosition} , {rover.RoverPlateau.EndingVerticalPosition})", exception.Message);
            
        }
    }
}