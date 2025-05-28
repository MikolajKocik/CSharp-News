// Records as immutable classes also to create a save copy of objects by '(with)'

(with):
Point p1 = new Point(2, 3);
Point p2 = p1 with (Y = 4);

Console.WriteLine(p2);
record Point
{
    public Point(double x, double y) => (X, Y) = (x, y);
    public double X { get; init; }
    public double y { get; init; }
}