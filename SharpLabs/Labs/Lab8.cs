namespace Labs;

public class Lab8 : ILab
{
    public string Name => "Одномерный массив";
    public int Number => 8;

    public Action[] Tasks() => new[] { Task1, Task2 };

    private static void Task1()
    {
        var n = Utils.Read<int>("Введите длину массива");
        var arr = MakeArray(n, 1, 31);
        Utils.WriteLineCenter("Сгенерированный массив:");
        Utils.WriteLineCenter(string.Join(" ", arr));
        var min = Utils.Read<int>("Введите минимальное число");
        Utils.WriteLineCenter($"Количество элементов <{min}: {arr.Count(x => x < min)}");

        var color = Console.ForegroundColor;
        foreach (var val in arr)
        {
            Console.ForegroundColor = val < min ? ConsoleColor.Green : color;
            Console.Write(val + " ");
        }
        Console.WriteLine();
        
        Console.ForegroundColor = color;
    }

    private static void Task2()
    {
        var n = Utils.Read<int>("Введите длину массива");
        var arr = MakeArray(n, 1, 31);
        Utils.WriteLineCenter("Сгенерированный массив:");
        Utils.WriteLineCenter(string.Join(" ", arr));
        var k = Utils.Read<int>("Введите k", k => k < arr.Length - 1);
        for (var i = 0; i <= k; i++)
            arr[i] = 0;
        Utils.WriteLineCenter("Результат:");
        Utils.WriteLineCenter(string.Join(" ", arr.Reverse()));
    }

    private static int[] MakeArray(int n, int a, int b) 
        => Enumerable.Range(0, n).Select(_ => Random.Shared.Next(a, b)).ToArray();
}