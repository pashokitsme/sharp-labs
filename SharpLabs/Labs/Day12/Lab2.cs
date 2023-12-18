namespace Labs.Day12;

public class Lab2 : ILab
{
    public string Name =>
        "Заполнить файл file1.txt целыми числами, полученными с помощью генератора случайных чисел.";

    public int Number => 2;

    public Action[] Tasks() => new[] { Task1 };

    private static void Task1()
    {
        Utils.WriteLineCenter("Заполнить файл file1.txt целыми числами, полученными с помощью генератора случайных чисел.");
        Utils.WriteLineCenter("Найти количество удвоенных чисел, кратных 3 среди компонентов файла и записать их в новый файл file2.txt\n");

        var array = Enumerable.Range(0, 10).Select(_ => Random.Shared.Next(-10, 10)).ToArray();
        var filtered = array.Where(v => v % 3 == 0).Select(v => v * 2);
        
        File.WriteAllText("./file1.txt", string.Join(", ", array));
        File.WriteAllText("./file2.txt", string.Join(", ", filtered));
    }
}