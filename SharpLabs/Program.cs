using System.Text;
using Labs;

Console.OutputEncoding = Encoding.UTF8;

var labs = new List<ILab>
{
    new Lab1(),
    new Lab2(),
    new Lab3()
};

do
{
    var lab = LabPicker();
    Console.Clear();
    Utils.WriteLineCenter($"Лабораторная работа {lab.Number}: {lab.Name}", top: 0); 
    var tasks = lab?.Tasks();
    if (tasks == null || tasks.Length == 0)
        Utils.WriteLineCenter("\n\nЭтой лабораторной ещё нет");

    for (var i = 0; i < tasks?.Length; i++)
    {
        Console.Write("\n\n");
        Utils.WriteLineCenter($"Задача {i + 1}");
        tasks[i]();
    }

    Console.WriteLine();
    Console.WriteLine();
    Utils.WriteLineCenter("Выйти? y/n >>> ", newLine: false);
} while (Console.ReadLine() != "y");
return;

ILab LabPicker()
{
    Console.Clear();
    Utils.WriteLineCenter("Содержание", top: Console.BufferHeight / 2 - 9);
    var count = 1;
    foreach (var lab in labs)
        Utils.WriteDottedLine($"{lab.Number}) {lab.Name}", $"{count++}", pad: 10);


    Utils.WriteLineCenter("Номер >>> ", newLine: false, Console.CursorTop);
    return int.TryParse(Console.ReadLine(), out var n) ? labs.FirstOrDefault(lab  => lab.Number == n) ?? new NoLab() : new NoLab();
}