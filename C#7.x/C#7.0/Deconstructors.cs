public void Deconstruct(out string firstName, out string lastName)
{
    int spacePos = name.IndexOf(' ');
    firstName = name.Substring(0, spacePos);
    lastName = name.Substring(spacePos + 1);
}

// 

var joe = new Person("Johnny Bravo");
var (first, last) = joe;
Console.WriteLine(first);
Console.WriteLine(last);