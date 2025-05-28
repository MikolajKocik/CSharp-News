bool successful = int.TryParse("123", out int result);
Console.WriteLine(result);

// with large method where we dont need some parameters we can deny it

SomeBigMethod(out _, out _, out _, out int x, out _, out _, out _);
Console.WriteLine(x);