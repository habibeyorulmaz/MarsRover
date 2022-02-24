
namespace MarsRover.Model
{
    public class RoverPlateau
    {
        public RoverPlateau(int horizontalPosition, int verticalPosition)
        {
            if (horizontalPosition <= 0 )
            {
                throw new Exception("Plateau ending horizontal position cannot be equal or less than zero");
            }
            if (verticalPosition <= 0)
            {
                throw new Exception("Plateau ending vertical position cannot be equal or less than zero");
            }

            this.StartingHorizantalPosition = 0;
            this.StartingVerticalPosition = 0;
            this.EndingHorizantalPosition = horizontalPosition;
            this.EndingVerticalPosition = verticalPosition;
        }
        public int StartingHorizantalPosition { get; set; }
        public int StartingVerticalPosition { get; set; }
        public int EndingHorizantalPosition { get; set; }
        public int EndingVerticalPosition { get; set; }

    }
}
