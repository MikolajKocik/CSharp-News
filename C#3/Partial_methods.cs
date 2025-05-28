public partial class MyClass
{
    partial void TestMethod();
}

public partial class MyClass
{
    partial void TestMethod() => Console.WriteLine("Method here");
}
