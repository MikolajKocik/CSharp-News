// switch instruction based on type cases

switch (x)
{
    case int 1:
        Console.WriteLine("its int");
        break;
    case string s:
        Console.WriteLine(s.Length);
        break;
    case bool b when b == true:
        Console.WriteLine("true");
        break;
    case null:
        Console.WriteLine("Nothing");
        break;
}