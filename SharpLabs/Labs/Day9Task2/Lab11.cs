namespace Labs.Day9Task2;

public class Lab11 : ILab
{
    public string Name => "Найдите количество чётных цифр в натуральном числе";
    public int Number => 11;

    public Action[] Tasks() => new[] { Task1 };

    private static void Task1()
    {
        Utils.WriteLineCenter("Найдите количество чётных цифр в натуральном числе");

        var val = Utils.Read<int>("Введите число");
        var count = 0;
        do
        {
            count += val % 10 % 2 == 0 ? 1 : 0;
        } while ((val /= 10) > 0);
        Utils.WriteLineCenter($"Количество чётных чисел: {count}");
    }
}