namespace Sphere
{
    public class Sphere
    {
        private double _coordinateX = 0;
        private double _coordinateY = 0;
        private double _coordinateZ = 0;

        public double Radius { get; set; } = 1;

        public Sphere() { }

        public Sphere(double radius, double coordinateX, double coordinateY, double coordinateZ)
        {
            _coordinateX = coordinateX;
            _coordinateY = coordinateY;
            _coordinateZ = coordinateZ;
            Radius = radius;
        }
        public void GetVolume()
        {
            double volume = Radius * Radius * Radius * Math.PI * 3 / 4;
            Console.WriteLine(volume);
        }

        public void GetSquare()
        {
            double square = Radius * Radius * Math.PI * 4;
            Console.WriteLine(square);
        }

        public void GetCenter()
        {
            Console.WriteLine($"{_coordinateX} {_coordinateY} {_coordinateZ}");
        }

        public void SetCenter(double newCoordinateX, double newCoordinateY, double newCoordinateZ)
        {
            _coordinateX = newCoordinateX;
            _coordinateY = newCoordinateY;
            _coordinateZ = newCoordinateZ;
        }

        public void IsPointInside(double someCoordinateX, double someCoordinateY, double someCoordinateZ)
        {
            double comparison = Math.Sqrt((_coordinateX - someCoordinateX) * (_coordinateX - someCoordinateX) + (_coordinateY - someCoordinateY) * (_coordinateY - someCoordinateY) + (_coordinateZ - someCoordinateZ) * (_coordinateZ - someCoordinateZ));
            if (comparison <= Radius)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
