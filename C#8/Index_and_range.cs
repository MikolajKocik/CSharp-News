// operatos ^ to declare length of array parameters

char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u', 'y' };
char lastElement = vowels[^1]; // 'y'
char secondToLastElement = vowels[^2] // 'u'

// ranges allows to slice an array with ".." operator

char[] firstTwo = vowels[..2]; // 'a', 'e'
char[] lastThree = vowels[2..]; // 'i', 'e', 'u'
char[] middleOne = vowels[2..3]; // 'i'
char[] lastTwo = vowels[^2..]; // 'u', 'y'

// Index and Range types

Index last = ^1;
Range firstTwoRange = 0..2;
char[] firstTwo = vowels[firstTwoRange]; // 'a', 'e'

// own defined classes with parameter Index / Range
class Sentence
{
    string[] words = "Some text here".Split();

    public string this[Index index] => words[index];
    public string[] [Range range] => words[range];
}