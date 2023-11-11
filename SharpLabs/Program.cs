using System.Text;
using Labs;

#if DAY_9_TASK_1
using Labs.Day9Task1;
#endif

#if DAY_9_TASK_2
using Labs.Day9Task2;
#endif

#if DAY_10
using Labs.Day10;
#endif

Console.OutputEncoding = Encoding.UTF8;

var labs = new List<ILab>
{
    #if DAY_9_TASK_1
    new Lab1(),
    new Lab2(),
    new Lab3(),
    new Lab4()
    #endif
    
    #if DAY_9_TASK_2
    new Lab1(),
    new Lab2(),
    new Lab3(),
    new Lab4(),
    new Lab5(),
    new Lab6(),
    new Lab7(),
    new Lab8(),
    new Lab9(),
    new Lab10(),
    new Lab11(),
    new Lab12(),
    new Lab13(),
    new Lab14()
    #endif
    
    #if DAY_10
    new Lab1(),
    new Lab2()
    #endif
};

do
{
    var lab = LabPicker();
    Console.Clear();
    Console.ResetColor();
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


    Console.Write("\n\n");
    Utils.WriteLineCenter("Номер >>> ", newLine: false, Console.CursorTop);
    return int.TryParse(Console.ReadLine(), out var n) ? labs.FirstOrDefault(lab  => lab.Number == n) ?? new NoLab() : new NoLab();
}