namespace Labs.Day9Task2;

public class Lab12 : ILab
{
    public string Name => "Найдите количество цифр >3 & <8 в натуральном числе";
    public int Number => 12;

    public Action[] Tasks() => new[] { Task1 };

    private static void Task1()
    {
        Utils.WriteLineCenter("Найдите количество цифр >3 & <8 в натуральном числе");

        var val = Utils.Read<int>("Введите число");
        var count = 0;
        do
        {
            count += val % 10 is > 3 and < 8 ? 1 : 0;
        } while ((val /= 10) > 0);
        Utils.WriteLineCenter($"Количество чётных чисел: {count}");
    }
}