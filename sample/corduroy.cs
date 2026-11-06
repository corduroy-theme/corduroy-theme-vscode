using System;
using System.Collections.Generic;

namespace Corduroy.Sample;

public interface IGreeter
{
    string Greet(string name);
}

public class Corduroy : IGreeter
{
    private readonly List<string> _messages = new();

    public string Title { get; set; } = "Corduroy";

    public string Greet(string name)
    {
        var message = $"Hello, {name} from {Title}";
        _messages.Add(message);
        return message;
    }

    public static void Main(string[] args)
    {
        Corduroy theme = new Corduroy();
        Console.WriteLine(theme.Greet("world"));
    }
}
