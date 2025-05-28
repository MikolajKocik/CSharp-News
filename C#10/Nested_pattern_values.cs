// Instead making of

var obj = new Uri("...");
if (obj is Uri { Scheme.Length: 5 }) ...

// C#10 alternative

if (obj is Uri {Scheme: {Length: 5}}) ...
