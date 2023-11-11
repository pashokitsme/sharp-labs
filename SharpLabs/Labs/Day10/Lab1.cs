namespace Labs.Day10;

public class Lab1 : ILab
{
    public string Name => "Массивы";
    public int Number => 1;

    public Action[] Tasks() => new[] { Task1, Task2, Task3 };

    private static void Task1()
    {
        Utils.WriteLineCenter("В последовательности действительных чисел a1, a2, ..., an есть только положительные и отрицательные члены.");
        Utils.WriteLineCenter("Вычислить произведение P1 отрицательных членов этой последовательности и произведение P2 положительных ее членов. Сравнить P1 и P2 и указать, какое из произведений по модулю больше.\n");

        var n = Utils.Read<int>("Введите N");
        var array = Enumerable.Range(0, n).Select(_ => Random.Shared.Next(-9, 10)).ToArray();
        
        Utils.WriteLineCenter($"Сгенерированный массив: {string.Join(", ", array)}");

        var p1 = Math.Abs(array.Where(v => v < 0).Aggregate((acc, val) => acc * val));
        var p2 = Math.Abs(array.Where(v => v >= 0).Aggregate((acc, val) => acc * val));
        
        Utils.WriteLineCenter($"{(p1 > p2 ? "P1 (отрицательные)" : "P2 (положительные)")} больше по модулю");
    }

    private static void Task2()
    {
        Utils.WriteLineCenter("Дана матрица B[N,M]. Найти в каждой строке этой матрицы максимальный и минимальный элементы и поменять их местами.\n");

        var array = MakeArray();

        foreach (var row in array)
        {
            var min = row.IndexOf(row.Min());
            var max = row.IndexOf(row.Max());
            (row[min], row[max]) = (row[max], row[min]);
        }

        Console.WriteLine();
        Utils.WriteLineCenter("Полученный массив");
        foreach (var arr in array)
            Utils.WriteLineCenter(string.Join(" ", arr.Select(v => $"{v,2}")));

    }

    private static void Task3()
    {
        Utils.WriteLineCenter("Для каждой строки подсчитать количество положительных элементов и записать данные в новый массив.\n");

        var array = MakeArray();

        var res = array.Select(vs => vs.Where(v => v >= 0).Sum()).ToArray();
        Console.WriteLine();
        for (var i = 0; i < res.Length; i++)
            Utils.WriteLineCenter($"{i + 1}) Количество положительных элементов: {res[i]}");
    }

    private static List<List<int>> MakeArray()
    {
        var n = Utils.Read<int>("Введите N");
        var m = Utils.Read<int>("Введите M");
        var array = Enumerable.Range(0, n).Select(_ => Enumerable.Range(0, m).Select(_ => Random.Shared.Next(-9, 10)).ToList()).ToList();
        Utils.WriteLineCenter("Сгенерированный массив");
        foreach (var arr in array)
            Utils.WriteLineCenter(string.Join(" ", arr.Select(v => $"{v,2}")));

        return array;
    }
}