

namespace TaskMindBox
{
    class Program
    {
        static void Main(string[] args)
        {
            IFigure triang = new Triang(13, 40, 30);

            IFigure figure = new Circle(10.34434);

            IFigure circle = new Circle(10);

            Triang triang1 = new Triang(30, 30, 30);

            FigureDefinition.GetDefinition(triang);
            FigureDefinition.GetDefinition(figure);
            FigureDefinition.GetDefinition(circle);
            FigureDefinition.GetDefinition(triang1);
        }

    }
}