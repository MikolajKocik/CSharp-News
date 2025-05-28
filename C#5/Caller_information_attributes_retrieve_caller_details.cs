public void Log(string message, 
    [CallerMemberName] string methodName = "",
    [CallerFilePath] string filePath = "",
    [CallerLineNumber] int lineNumber = 0)
{
    Console.WriteLine($"[{methodName} - {filePath}:{lineNumber}] {message}");
}
