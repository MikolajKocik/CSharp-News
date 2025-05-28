public interface IParsable<TSelf>
{
    static abstract TSelf Parse(string s);
}

/* 
   ...
    .
    .
    .
    .
    .
    .
*/

T ParseAny<T>(string s) where T : IParsable<T> => T.Parse(s);