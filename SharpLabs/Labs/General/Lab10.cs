namespace Labs.General;

public class Lab10 : ILab
{
    public string Name => "Рекурсивные функции";
    public int Number => 10;

    public Action[] Tasks() => new[] { Task1, Task2 };

    private static void Task1()
    {
        Utils.WriteLineCenter("Описать рекурсивную функцию power7(N), которая вычисляет, какой степенью числа 7 является натуральное число N. Если N не степень 7, функция должна вернуть число -1.");
        var val = Utils.Read<int>("Введите N");
        var ans = Power7(val);
        Utils.WriteLineCenter($"Число {val} является степенью {ans} числа 7");
    }

    private static int Power7(int val)
    {
        if (val == 1) return 0;
        if (val < 1 || val % 7 != 0) return -1;
        return 1 + Power7(val / 7);
    }

    private static void Task2()
    {
        Utils.WriteLineCenter("Дано натуральное число n. Выведите все числа от 1 до n");
        var val = Utils.Read<int>("Введите N");
        PrintToN(1, val);
        Console.WriteLine();
    }

    private static void PrintToN(int current, int val)
    {
        if (current > val) return;
        Console.Write(current);
        PrintToN(current + 1, val);
    }
}