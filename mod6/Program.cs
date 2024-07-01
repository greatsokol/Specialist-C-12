namespace Inheritance
{
    internal class Program
    {
        static void DrawScene(Shape[] scene)
        {
            string divider = new string('-', 20);
            Console.WriteLine($"{divider} SCENE {divider}");
            foreach (Shape shape in scene)
            {
                shape.Draw();
            }
        }

        static void Main(string[] args)
        {
            Point point = new Point(10, 10, "Red");
            point.Draw();
            point.MoveBy(10, 10);
            point.Draw();

            Circle circle = new Circle(10, 10, 20, "Blue");
            circle.Draw();
            circle.MoveBy(10, 10);
            circle.Scale(1.5);
            circle.Draw();

            Line line = new Line(0, 0, 100, 100);
            line.MoveBy(100, 100);
            line.Draw();
            line.Scale(1.5);
            line.Draw();

            Shape[] scene = {point, circle, line};
            DrawScene(scene);
            
        }
    }
}
