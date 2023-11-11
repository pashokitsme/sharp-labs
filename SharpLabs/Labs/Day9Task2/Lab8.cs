namespace Labs.Day9Task2;

public class Lab8 : ILab
{
    public string Name => "Количество введённых чётных чисел";
    public int Number => 8;

    public Action[] Tasks() => new[] { Task1 };

    private static void Task1()
    {
        var count = 0;
        Utils.Read<int>("Введите чётное число. 0 для завершения ввода", v =>
        {
            if (v % 2 == 0) count++;
            return v == 0;
        });
        Utils.WriteLineCenter($"Количество введёных чисел: {count}");
    }
}