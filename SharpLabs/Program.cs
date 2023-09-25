using Labs;

var labs = CollectLabs()!.ToList();

do
{
    Intro();
    var lab = LabPicker();
    Console.Clear();
    Utils.WriteLineCenter($"Лабораторная работа {lab.Number}: {lab.Name}\n\n", top: 0);
    lab?.Entry();

    Console.WriteLine();
    Console.WriteLine();
    Utils.WriteLineCenter("Выйти? y/n >>> ", newLine: false);
} while (Console.ReadLine() != "y");
return;

void Intro()
{
    // Console.BackgroundColor = ConsoleColor.White;
    // Console.ForegroundColor = ConsoleColor.Black;
    Utils.WriteBufferCenter("""
МЦК-ЧЭМК Минобразования Чувашии
Дисциплина разработка кода информационных систем

КОНСОЛЬНОЕ ПРИЛОЖЕНИЕ
по лабораторным работам

ЛР.ИР3-21.21.МДК.05.02.ОТ
Выполнил студент З курса, группы ИрЗ-21
Смирнов Павел Николаевич

Преподаватель: Павловская Ирина Геннадьевна
2023

Далее Enter >>>
""".Split('\n'));
}

ILab LabPicker(int min = 9)
{
    Console.Clear();
    Utils.WriteLineCenter("Содержание", top: Console.BufferHeight / 2 - Math.Abs(min - labs.Count));
    var count = 1;
    foreach (var lab in labs)
        Utils.WriteDottedLine($"{lab.Number}) Лабораторная работа: {lab.Name}", $"{count++}");

    if (count <= min)
    {
        for (; count <= min; count++)
            Utils.WriteDottedLine($"{count}) Лабораторная работа: Название", $"{count}");
    }


    Utils.WriteLineCenter("Номер >>> ", newLine: false, Console.BufferHeight / 2 + Math.Abs(min - labs.Count));
    return int.TryParse(Console.ReadLine(), out var n) ? labs.FirstOrDefault(lab  => lab.Number == n) ?? new NoLab() : new NoLab();
}

IEnumerable<ILab> CollectLabs() =>
    AppDomain.CurrentDomain.GetAssemblies()
        .SelectMany(asm => asm
            .GetTypes()
            .Where(type => type.IsAssignableTo(typeof(ILab)) && !type.IsInterface)
        )
        .Select(type => Activator.CreateInstance(type) as ILab)
        .Where(lab => lab is not null && lab.Number > 0)!
        .OrderBy(lab => lab!.Number)!;