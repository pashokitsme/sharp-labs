using System.Text;

namespace Labs.Day9Task2;

public class Lab1 : ILab
{
    public string Name => "Выведите на экран квадрат и нулей и единиц, нули только на диагонали";
    public int Number => 1;

    public Action[] Tasks() => new[] { Task1 };

    private static void Task1()
    {
        const int n = 100;
        var sb = new StringBuilder();
        
        for (var i = 0; i < n; i++)
        {
            for (var j = 0; j < n; j++)
            {
                sb.Append((i + j == n - 1 || j - i == 0) ? 0 : 1);
            }

            sb.AppendLine();
        }

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(sb);
    }
}