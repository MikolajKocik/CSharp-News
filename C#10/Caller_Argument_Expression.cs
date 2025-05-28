// captures arguments from the called location

Print(Math.PI * 2);

void Print(double number,
        [CalledArgumentExpression("number")] string expr == null)
        => Console.WriteLine(exp);

// result: Math.PI * 2