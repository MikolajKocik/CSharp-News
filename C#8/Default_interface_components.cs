// instead of writing 

((ILogger)new Logger()).Log("message");

// it is possible to write code like this

interface ILogger
{
    void Log(string text) => Console.WriteLine(text);
}

// static components with values

interface ILogger
{
    void Log(string text) => Console.WriteLine(text);
    static string Prefix = ""
}