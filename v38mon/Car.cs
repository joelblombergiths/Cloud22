using System.Drawing;

namespace v38mon
{
    internal class Car
    {
        public string Model;
        public Color Color;
        public double Price;

        public Car() : this(string.Empty, Color.Black, 0) { }
        public Car(string model) : this(model, Color.Black, 0) { }
        public Car(string model, Color color) : this(model, color, 0) { }
        public Car(string model, Color color, double price)
        {
            Model = model;
            Color = color;
            Price = price;
        }

        public void HalfPrice() => Price /= 2;
    }
}
