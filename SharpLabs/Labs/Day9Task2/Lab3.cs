namespace Labs.Day9Task2;

public class Lab3 : ILab
{
    public string Name => "Вывести 30 строк";
    public int Number => 3;

    public Action[] Tasks() => new[] { Task1 };

    private static void Task1()
    {
        Utils.WriteLineCenter("Вывести 30 строк. Нечётные строки содержат натуральные числа от 1 до номера строки с шагом 1, чётные состоят и 5 единиц");

        var even = string.Join(" ", Enumerable.Range(0, 5).Select(_ => 5));
        var output = string.Join("\n", Enumerable.Range(1, 31).Select(i => $"{i})" + (i % 2 == 0 ? even : string.Join(" ", Enumerable.Range(1, i)))));
        Console.WriteLine(output);
    }
}