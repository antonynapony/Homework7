namespace Sphere
{
    static class Program
    {
        static void Main(string[] args)
        {
            Sphere sphere = new Sphere();
            sphere.GetVolume();
            sphere.GetSquare();
            sphere.GetCenter();
            sphere.SetCenter(1, 3, 4);
            sphere.GetCenter();
            sphere.IsPointInside(1, 2, 3);
        }
    }
}