namespace OutAndRef;

public class PointExample
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public override string ToString()
        {
            return $"X: {X}, Y: {Y}";
        }

        public Point Clone()
        {
            return new Point { X = this.X, Y = this.Y };
        }
    }

    private Point location;

    public Point Location => location.Clone();
}