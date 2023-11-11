namespace Labs.Day9Task1;

public class Lab2 : ILab
{
    public string Name => "Оператор условия";
    public int Number => 2;

    public Action[] Tasks() => new[] { Task1, Task2 };

    private static void Task1()
    {
        Utils.WriteLineCenter("F(x) = -x^2 + x - 9 при x >= 8; 1 / (x^4 - 6) при x < 6");

        var x = Utils.Read<double>("Введите x");
        var y = x >= 8 ? Math.Pow(-x, 2) + x - 9 : 1 / (Math.Pow(x, 4) - 6);
        Utils.WriteLineCenter($"Ответ: {y:0.00}");
    }

    private static void Task2()
    {
        Utils.WriteLineCenter("Проанализировать возраст человека, чтобы отнести к одной из четырёх групп: дошкольник, ученик, работник, пенсионер");

        var age = Utils.Read<int>("Введите возраст");
        var group = age switch
        {
            <7 => "дошкольник",
            <18 => "ученик",
            <65 => "работник",
            _ => "пенсионер"
        };
        
        Utils.WriteLineCenter($"Группа: {group}");
    }
}