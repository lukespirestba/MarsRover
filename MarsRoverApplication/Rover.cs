namespace MarsRoverApplication
{
    public class Rover
    {
        public Rover(int xCoordinate, int yCoordinate, string direction)
        {
            CurrentCoordinate = new()
            {
                X = xCoordinate,
                Y = yCoordinate
            };
            Direction = direction;
        }

        public Coordinate CurrentCoordinate { get; set; }
        public string Direction { get; set; } = "N";

        public class Coordinate 
         {
            public int X;
            public int Y;
         }
    }
}
