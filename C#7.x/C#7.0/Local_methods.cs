// method declared in another method

void WriteCubes()
{
    Console.WriteLine(Cube(3));
    Console.WriteLine(Cube(3));
    Console.WriteLine(Cube(3));

    int Cube(int value) => value * value * value;
}