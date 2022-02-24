
namespace MarsRover.Model
{
    public class Rover
    {

        public Rover(RoverPlateau roverPlateau, RoverPositioning roverPositioning, string movementCommand)
        {
            _ = movementCommand ?? throw new ArgumentNullException(nameof(movementCommand));

            if (!ValidateMovementCommand(movementCommand))
            {
                throw new Exception($"Invalid Input Characters {movementCommand}");
            }

            if (roverPlateau.EndingHorizantalPosition < roverPositioning.HorizontalPosition)
            {
                throw new Exception("Plateau horizontal size cannot be less than rover horizontal position");
            }

            if (roverPlateau.EndingVerticalPosition < roverPositioning.VerticalPosition)
            {
                throw new Exception("Plateau vertical size cannot be less than rover vertical position");
            }

            
            this.RoverPlateau = roverPlateau;
            this.RoverPositioning = roverPositioning;
            this.MovementCommand = movementCommand;
        }


        public RoverPlateau RoverPlateau { get; set; }

        public RoverPositioning RoverPositioning { get; set; }

        public string MovementCommand { get; set; }


        public bool ValidateMovementCommand(string movementCommand)
        {
            return movementCommand.All(c => "RLM".Contains(c));
        }

        /// <summary>
        /// GetPositionInfo method
        /// </summary>
        /// <returns></returns>
        public string GetPositionInfo()
        {
            return RoverPositioning.HorizontalPosition + " " +
                   RoverPositioning.VerticalPosition + " " + 
                   RoverPositioning.HeadingDirection;
        }

    }
}
