namespace Labs.Day9Task2;

public class Lab9 : ILab
{
    public string Name => "Четырёхзначные числа, сумма цифр которых равна 15";
    public int Number => 9;

    public Action[] Tasks() => new[] { Task1 };

    private static void Task1()
    {
        Utils.WriteLineCenter("Найдите четырёхзначные числа, сумма которых равна 15");

        var values = string.Join(", ", Enumerable.Range(1000, 9000).Where(v => Sum(v) == 15));
        Utils.WriteLineCenter($"Числа: {values}");
    }

    private static int Sum(int val)
    {
        var sum = 0;
        do
        {
            sum += val % 10;
        } while ((val /= 10) > 0);
            
        return sum;
    }
}