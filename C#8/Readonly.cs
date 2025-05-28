// immutable functions

struct Point
{
    public int X, Y;
    public readonly void ResetX() => X = 0; // error
}