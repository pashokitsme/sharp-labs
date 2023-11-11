namespace Labs.Day9Task2;

public class Lab14 : ILab
{
    public string Name => "N-е число Фибоначчи";
    public int Number => 14;

    public Action[] Tasks() => new[] { Task1 };

    private static void Task1()
    {
        Utils.WriteLineCenter("N-е число Фибоначчи");

        var n = Utils.Read<int>("Введите N");
        Utils.WriteLineCenter($"Fib({n}): {Fib(n)}");
    }
    
    
    private static long Fib(int n)
    {
        if (n <= 1)
            return n;

        return Fib(n - 1) + Fib(n - 2);
    }
}