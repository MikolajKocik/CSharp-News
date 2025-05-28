// In C#12 we can put directly list of parameters after class declaration or struct

class Person(string firstName, string lastName)
{
    public void Print() => Console.WriteLine(firstName + " " + lastName);
}

