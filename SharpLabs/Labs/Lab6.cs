namespace Labs;

public class Lab6 : ILab
{
    public string Name => "Обработка исключений";
    public int Number => 6;

    public Action[] Tasks() => new[] { Task1 };

    private static void Task1()
    {
        try
        {
            var str1 = Utils.Read("Введите a");
            var str2 = Utils.Read("Введита b");
            var a = double.Parse(str1);
            var b = double.Parse(str2);
            for (var x = a; x <= b; x++)
            {
                try
                {
                    var y = Math.Log2(x + 1) / (x - 1) - 1;
                    Utils.WriteLineCenter($"Y равен: {y:0.00}");
                }
                catch (DivideByZeroException ex)
                {
                    Utils.WriteLineCenter($"Ошибка деления на 0: {ex.Message}");
                }
            }
        }
        catch (FormatException ex)
        {
            Utils.WriteLineCenter($"Неправильное число. {ex.Message}");
        }
    }
}