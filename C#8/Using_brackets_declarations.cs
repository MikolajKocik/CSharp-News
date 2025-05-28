// old declaration with brackets

using (var StreamWriter writer = new StreamWriter(...)) { }

// new declaration

using var StreamWriter writer = new StreamWriter();

