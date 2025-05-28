int[] numbers = { 1, 2, 3, 4, 5 };

Console.WriteLine(numbers is [1, 2, 3, 4, 5]); // true

// _ = single element with any type / .. = zero or more elements

Console.WriteLine(numbers is [_,2,..,5]); // true