public class Person
{
    string name;
    public Person(string name) => Name = name;
    public string Name
    {
        get => name;
        set => name = value ?? "";
    }
    ~Person() => Console.WriteLine("final");
}