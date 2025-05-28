// Relational pattern

string GetWeightCategory(decimal bmi) => bmi switch
{
    < 18.5m => "niedowaga",
    < 25m => "norma",
    < 30m => "nadwaga",
    _ => "otyłość"
};

// Combinators pattern

bool isVowel(char c) => c is 'a' or 'e' or 'i'; // ...

bool isLetter(char c) => c is >= 'a' and <= 'z'
                           or >= 'A' and <= 'Z';

// also 'not' to check something

if (object is not string) ... 

