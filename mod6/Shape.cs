namespace Inheritance
{
    public abstract class Shape
    {
        protected const string DEFAULT_COLOR = "Black";
        public string Color { get; set; }

        public Shape(string Color = DEFAULT_COLOR)
        {
            this.Color = Color;
        }

        public abstract void Draw();
    }
}
