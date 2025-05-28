var bob = ("Bob", 12);
Console.WriteLine(bob.Item1);
Console.WriteLine(bob.Item2);

// 

static void Main()
{
    (int row, int column) = GetFilePosition(); // creates 2 local variables
    Console.WriteLine(row);
    Console.WriteLine(column);
}