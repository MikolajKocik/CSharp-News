public static class MyExtensions
{
    public static int Multiple(this int x) => x * 2;
}

Console.WriteLine(5.Multiple()); // result 10
