namespace Labs.Day9Task2;

public class Lab2 : ILab
{
    public string Name => "Вывести 20 строк";
    public int Number => 2;

    public Action[] Tasks() => new[] { Task1 };

    private static void Task1()
    {
        Utils.WriteLineCenter("Вывести на экран 20 строк. В строках с чётными номерами вывести по 10 чисел, равных номеру строки.");
        Utils.WriteLineCenter("В строках с нечётными вывести десять единиц");
        var odd = string.Join(" ", Enumerable.Range(0, 10).Select(_ => 1));
        
        var output = string.Join("\n", Enumerable.Range(0, 20).Select(v => $"{v}) " + (v % 2 == 0 ? string.Join(" ", Enumerable.Range(0, 10).Select(_ => v)) : odd)));
        Console.WriteLine(output);
    }
}