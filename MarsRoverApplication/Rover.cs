namespace MarsRoverApplication
{
    public class Rover
    {
        public Rover(int xCoordinate, int yCoordinate)
        {
            CurrentCoordinate = new()
            {
                X = xCoordinate,
                Y = yCoordinate
            };
        }

        public Coordinate CurrentCoordinate { get; set; }

        public class Coordinate 
         {
            public int X;
            public int Y;
         }
    }
}
