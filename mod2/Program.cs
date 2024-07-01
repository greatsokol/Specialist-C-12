namespace Figures
{
    enum FigureTypes
    {
        Circle,
        Square,
        Rectangle,
        Triangle
    };

    struct Figure 
    {
        public FigureTypes ftype;
        public int perimeter, x, y;
        public String color;


        public Figure(FigureTypes ftype, int perimeter, String color = "red", int x = 5, int y = 5)
        {
            this.ftype = ftype;
            this.perimeter = perimeter;
            this.color = color;
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return $"Type: {this.ftype}; Perimeter: {perimeter}; Color: {color}; Coords: {x}:{y}";
        }
    };

    internal class Program
    {
        static void Main(string[] args)
        {
            Figure circle = new Figure(FigureTypes.Circle, 100);
            Figure square = new Figure(FigureTypes.Square, 200, "blue");
            Figure triangle = new Figure 
            { 
                ftype = FigureTypes.Triangle,
                color = "orange",
                perimeter = 300,
                x = 15,
                y = 10
            };

            Console.WriteLine(circle);
            Console.WriteLine(square);
            Console.WriteLine(triangle);
        }
    }
}
