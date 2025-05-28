// we can declare variable on the fly

void Foo(object x)
{
    if (x is string s)
        Console.WriteLine(s.Length);
}