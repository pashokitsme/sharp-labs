namespace Labs.Day10;

public class Lab3 : ILab
{
    public string Name => "Множества";
    public int Number => 3;

    public Action[] Tasks() => new[] { Task1 };

    private static void Task1()
    {
        Utils.WriteLineCenter("Посчитать в строке количество русских гласных букв. Вывести все русские гласные буквы строки в алфавитном порядке.\n");
        
        var val = Utils.Read("Введите строку") ?? "";
        var vowels = new [] { 'а', 'е', 'ё', 'и', 'о', 'у', 'ы', 'э', 'ю', 'я' };
        var filtered = val.ToLower().Where(c => vowels.Contains(c)).Order().ToArray();
        
        Utils.WriteLineCenter($"Гласные буквы: {string.Join(", ", filtered)}");
        Utils.WriteLineCenter($"Количество букв: {filtered.Length}");
    }
}