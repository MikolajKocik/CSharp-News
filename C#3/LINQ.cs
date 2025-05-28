var numbers = new List<int> { 1, 2, 3, 4, 5 };
var even = from number in numbers where number % 2 == 0 select number;
Console.WriteLine(string.Join(", ", even)); // Result: 2, 4
