namespace Labs.Day12;

public class Lab2 : ILab
{
    public string Name =>
        "Дан текстовый файл (файл text.txt должен содержать английский текст). Напечатать все нечетные строки";

    public int Number => 1;

    public Action[] Tasks() => new[] { Task1 };

    private static void Task1()
    {
        Utils.WriteLineCenter("Заполнить файл file1.txt целыми числами, полученными с помощью генератора случайных чисел.");
        Utils.WriteLineCenter("Найти количество удвоенных чисел, кратных 3 среди компонентов файла и записать их в новый файл file2.txt\n");

        const string path = "./file1.txt";

        var array = Enumerable.Range(0, 10).Select(_ => Random.Shared.Next(-10, 10)).ToArray();
        var filtered = array.Where(v => v % 3 == 0).Select(v => v * 2);
        
        File.WriteAllText(path, string.Join(", ", array));
        File.WriteAllText(path, string.Join(", ", filtered));
    }
}