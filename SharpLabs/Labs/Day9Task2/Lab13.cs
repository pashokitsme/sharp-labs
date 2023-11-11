namespace Labs.Day9Task2;

public class Lab13 : ILab
{
    public string Name => "Число в обратном порядке";
    public int Number => 13;

    public Action[] Tasks() => new[] { Task1 };

    private static void Task1()
    {
        Utils.WriteLineCenter("Найдите число в обратном порядке");

        var val = Utils.Read<int>("Введите число");
        var reverse = 0;
        do
        {
            reverse *= 10;
            reverse += val % 10;
        } while ((val /= 10) > 0);
        Utils.WriteLineCenter($"Количество чётных чисел: {reverse}");
    }
}