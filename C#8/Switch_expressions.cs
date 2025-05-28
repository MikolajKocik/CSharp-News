string cardName = cardNumber switch
{
    13 => "King",
    12 => "Queen",
    11 => "Jack",
    _ => "Other cards" // equal to "default"
};

// shorts

string cardNumber = 12; string suite = "pik";
string cardName = (cardNumber, suite) switch
{
    (13, "spades") => "King spades",
    (13, "clubs") => "King clubs",
    ...
};