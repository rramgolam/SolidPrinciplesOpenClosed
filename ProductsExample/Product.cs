namespace ProductsExample
{
    public enum Color
    {
        Red, Green, Blue, Brown
    }

    public enum Size
    {
        Small, Medium, Large, Huge
    }
    public class Product
    {
        public string name;
        public Color color;
        public Size size;

        public Product(string name, Color color, Size size)
        {
            this.name = name;
            this.color = color;
            this.size = size;
        }

        public override string ToString()
        {
            return name;
        }
    }
}