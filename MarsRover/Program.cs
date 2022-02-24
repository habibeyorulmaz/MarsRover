//
// This program is written by using .Net 6.0
// Created by Habibe Yorulmaz
// 
using MarsRover.Helper;
using MarsRover.Model;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Setting rover
                var roverPlateau = new RoverPlateau(5, 5);
                var roverPositioning = new RoverPositioning(1, 2, Enum.Directions.N);
                string movementCommand = "LMLMLMLMM";
                Rover rover = new Rover(roverPlateau, roverPositioning, movementCommand);

                //Processing
                var resultRoverInfo = Movement.ExecuteMovementCommand(rover);

                //Displaying
                Console.WriteLine(resultRoverInfo.GetPositionInfo());

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

    }
}