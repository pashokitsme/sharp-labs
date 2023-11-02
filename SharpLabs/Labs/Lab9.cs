using System.Text;

namespace Labs;

public class Lab9 : ILab
{
    public string Name => "Матрицы и собственная библиотека";
    public int Number => 9;

    public Action[] Tasks() => new[] { Task1, Task2 };

    private static void Task1()
    {
        var n = Utils.Read<int>("Введите N");
        var arr = MakeArray(n);
        var sum = 0;
        for (var i = 0; i < n; i++)
            sum += arr[n - i - 1][i];

        Utils.WriteLineCenter($"Сумма: {sum}. Среднее: {(double)sum / n}");
        for (var i = 0; i < n; i++)
        {
            for (var j = 0; j < n; j++)
            {
                Console.ForegroundColor = i + j == n - 1 ? ConsoleColor.Green : ConsoleColor.White;
                Console.Write($"{arr[i][j],4}");   
            }
            Console.WriteLine();
        }
    }

    private static void Task2()
    {
        var n = Utils.Read<int>("Введите N");
        var arr = MakeArray(n);
        arr.Select(row => $"Сумма столбца [{string.Join(", ", row)}]: {row.Sum()}").ToList().ForEach(val => Utils.WriteLineCenter(val));
    }
    
    private static int[][] MakeArray(int n)
    {
        const int a = -20;
        const int b = 21;
        var arr = Enumerable.Range(0, n)
            .Select(_ => Enumerable.Range(0, n).Select(_ => Random.Shared.Next(a, b)).ToArray()).ToArray();
        
        Utils.WriteLineCenter("Сгенерированный массив:");
        foreach (var row in arr)
        {
            var sb = new StringBuilder();
            foreach (var val in row)
                sb.Append($"{val,4}");
            Utils.WriteLineCenter(sb.ToString());
        }
        
        Console.WriteLine();
        
        return arr;
    }
}