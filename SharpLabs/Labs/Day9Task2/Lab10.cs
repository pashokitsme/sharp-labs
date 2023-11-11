namespace Labs.Day9Task2;

public class Lab10 : ILab
{
    public string Name => "Найдите наибольшую цифру в натуральном числе";
    public int Number => 10;

    public Action[] Tasks() => new[] { Task1 };

    private static void Task1()
    {
        Utils.WriteLineCenter("Найдите наибольшую цифру в натуральном числе");

        var val = Values(Utils.Read<int>("Введите число")).Max();
        Utils.WriteLineCenter($"Наибольшая цифра: {val}");
    }

    private static int[] Values(int val)
    {
        var vals = new List<int>();
        do
        {
            vals.Add(val % 10);
        } while ((val /= 10) > 0);
            
        return vals.ToArray();
    }
}