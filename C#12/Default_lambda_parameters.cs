// generally methods has default value as definition of parameter

void Print(string message = "") => Console.WriteLine(message);

// now lambda has also this functionality

var print = (string message = "") => Console.WriteLine(message);