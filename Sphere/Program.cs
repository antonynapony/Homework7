namespace Sphere
{
    static class Program
    {
        static void Main(string[] args)
        {
            Sphere sphere = new Sphere();
            Console.WriteLine("Введите значение радиуса: ");
            bool isCorrectRadius = double.TryParse(Console.ReadLine(), out double radius);
            if (isCorrectRadius )
            {
                sphere.Radius = radius;
            }
            else
            {
                Console.WriteLine("Некорректное значение радиуса, радиус должен быть больше 0! Присвоено значение 1 по умолчанию.");
            }
            Console.WriteLine("Объем сферы равен: ");
            sphere.GetVolume();
            Console.WriteLine("Площадь сферы равна: ");
            sphere.GetSquare();
            sphere.GetCenter();
            sphere.SetCenter(1, 2, 3);
            sphere.GetCenter();
            sphere.IsPointInside(4, 5, 6);
        }
    }
}