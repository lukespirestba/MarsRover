namespace MarsRoverApplication
{
    public class Rover
    {
        private int xCoordinate;
        private int yCoordinate;

        public Rover(int xCoordinate, int yCoordinate)
        {
            this.xCoordinate = xCoordinate;
            this.yCoordinate = yCoordinate;
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
