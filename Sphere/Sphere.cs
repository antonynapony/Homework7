namespace Sphere
{
    public class Sphere
    {
        private double _coordinateX;
        private double _coordinateY;
        private double _coordinateZ;

        private double radius = 1;
        public double Radius
        {
            get { return radius; }
            set
            {
                if (value > 0)
                {
                    radius = value;
                }
                else
                {
                    radius = 1;
                    Console.WriteLine("Некорректное значение радиуса, радиус должен быть больше 0! Присвоено значение 1 по умолчанию.");
                }
            }
        }

        public Sphere() { }

        public Sphere(double radius, double coordinateX, double coordinateY, double coordinateZ)
        {
            Radius = radius;
            _coordinateX = coordinateX;
            _coordinateY = coordinateY;
            _coordinateZ = coordinateZ;
        }
        public void GetVolume()
        {
            double volume = radius * radius * radius * Math.PI * 3 / 4;
            Console.WriteLine(volume);
        }

        public void GetSquare()
        {
            double square = radius * radius * Math.PI * 4;
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
            bool IsPointInside = (_coordinateX - someCoordinateX) * (_coordinateX - someCoordinateX) + (_coordinateY - someCoordinateY) * (_coordinateY - someCoordinateY) + (_coordinateZ - someCoordinateZ) * (_coordinateZ - someCoordinateZ) <= radius * radius;
            Console.WriteLine(IsPointInside);
        }
    }
}
