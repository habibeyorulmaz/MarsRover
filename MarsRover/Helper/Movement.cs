
using MarsRover.Model;

namespace MarsRover.Helper
{
    /// <summary>
    /// Helper class for movement of Rover
    /// </summary>
    public static class Movement
    {
        /// <summary>
        /// Executes given <see cref="Rover.MovementCommand"/> by using  <see cref="RoverPlateau"/> and <see cref="RoverPositioning"/> data
        /// </summary>
        /// <param name="rover"> Input Information of <see cref="Rover"/> that contains <see cref="RoverPlateau"/> and <see cref="RoverPositioning"/> and <see cref="Rover.MovementCommand"/></param>
        /// <returns>Returns <see cref="Rover"/> after execution of <see cref="Rover.MovementCommand"/> </returns>
        /// <exception cref="Exception">Position out of bounderies (0 , 0) and ( <see cref="Rover.RoverPlateau.EndingHorizantalPosition"/>,<see cref="Rover.RoverPlateau.EndingVerticalPosition"/></exception>
        public static Rover ExecuteMovementCommand(Rover rover)
        { 
            foreach (var move in rover.MovementCommand)
            {
                switch (move)
                {
                    case 'M':
                        rover.RoverPositioning.Move();
                        break;
                    case 'L':
                        rover.RoverPositioning.TurnLeft();
                        break;
                    case 'R':
                        rover.RoverPositioning.TurnRight();
                        break;
                    default:
                        break;
                }

                // Control boundaries of rover plateau
                if (rover.RoverPositioning.HorizontalPosition < rover.RoverPlateau.StartingHorizantalPosition ||
                    rover.RoverPositioning.HorizontalPosition > rover.RoverPlateau.EndingHorizantalPosition ||
                    rover.RoverPositioning.VerticalPosition < rover.RoverPlateau.StartingVerticalPosition ||
                    rover.RoverPositioning.VerticalPosition > rover.RoverPlateau.EndingVerticalPosition)
                {
                    throw new Exception($"Position out of boundaries (0 , 0) and ({rover.RoverPlateau.EndingHorizantalPosition} , {rover.RoverPlateau.EndingVerticalPosition})");
                }
            }

            return rover;
        }
    }
}
