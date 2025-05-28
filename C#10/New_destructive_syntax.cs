// C#10 gave access to mix the declarations and initializations in the same deconstruction field

var point = (3, 4);
double x = 0;

(x, double y) = point;