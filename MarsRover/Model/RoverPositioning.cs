
using MarsRover.Enum;

namespace MarsRover.Model
{
    public interface IRoverPositioning
    {
        RoverPositioning GetRoverPosition(int horizontalPosition, int verticalPosition, Directions headingDirection);
        void TurnLeft();
        void TurnRight();

        void Move();
    }
    public class RoverPositioning : IRoverPositioning
    {

        public RoverPositioning(int horizontalPosition, int verticalPosition, Directions headingDirection)
        {
            if (horizontalPosition <= 0)
            {
                throw new Exception("Rover horizontal position cannot be equal or less than zero");
            }
            if (verticalPosition <= 0)
            {
                throw new Exception("Rover vertical position cannot be equal or less than zero");
            }

            this.HorizontalPosition = horizontalPosition;
            this.VerticalPosition = verticalPosition;
            this.HeadingDirection = headingDirection;
        }

        public int HorizontalPosition { get; set; }

        public int VerticalPosition { get; set; }

        public Directions HeadingDirection { get; set; }

        public RoverPositioning GetRoverPosition(int horizontalPosition, int verticalPosition, Directions headingDirection)
        {
            return new RoverPositioning(horizontalPosition, verticalPosition, headingDirection);
        }

        public void TurnLeft()
        {
            switch (this.HeadingDirection)
            {
                case Directions.N:
                    this.HeadingDirection = Directions.W;
                    break;
                case Directions.S:
                    this.HeadingDirection = Directions.E;
                    break;
                case Directions.E:
                    this.HeadingDirection = Directions.N;
                    break;
                case Directions.W:
                    this.HeadingDirection = Directions.S;
                    break;
                default:
                    break;
            }
        }

        public void TurnRight()
        {
            switch (this.HeadingDirection)
            {
                case Directions.N:
                    this.HeadingDirection = Directions.E;
                    break;
                case Directions.S:
                    this.HeadingDirection = Directions.W;
                    break;
                case Directions.E:
                    this.HeadingDirection = Directions.S;
                    break;
                case Directions.W:
                    this.HeadingDirection = Directions.N;
                    break;
                default:
                    break;
            }
        }

        public void Move()
        {
            switch (this.HeadingDirection)
            {
                case Directions.N:
                    this.VerticalPosition += 1;
                    break;
                case Directions.S:
                    this.VerticalPosition -= 1;
                    break;
                case Directions.E:
                    this.HorizontalPosition += 1;
                    break;
                case Directions.W:
                    this.HorizontalPosition -= 1;
                    break;
                default:
                    break;
            }
        }


    }
}
