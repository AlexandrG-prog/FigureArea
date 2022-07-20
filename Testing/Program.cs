using FigureArea;
using FigureArea.Figures;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            var circle = new Circle(10);
            var areaC = circle.GetArea();
            var triangle = new Triangle(10, 10, 10);
            var areaT = triangle.GetArea();
        }
    }
}
