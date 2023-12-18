using System.Text.Json;

namespace Labs.General;

public struct Toy
{
    public int Id;
    public string Model;
    public string Manufacturer;
    public string Material;
    public int Year;
    public int Amount;
    public int Price;

    public static Toy ReadStdin()
    {
        var model = Utils.Read("Введите название модели")!;
        var manufacturer = Utils.Read("Введите производителя")!;
        var material = Utils.Read("Введите материал")!;
        var year = Utils.Read<int>("Введите год");
        var amount = Utils.Read<int>("Введите количество");
        var price = Utils.Read<int>("Введите цену");
        return new Toy
        {
            Id = model.GetHashCode() + manufacturer.GetHashCode() + price + amount + year + material.GetHashCode(),
            Model = model, Manufacturer = manufacturer, Price = price, Amount = amount, Material =  material, Year = year
        };
    }

    public override string ToString() => $"Id: {Id} - {Model} {Manufacturer}, {Price}р";
}

public class Lab11 : ILab
{
    public int Number => 11;
    public string Name => "Структура и файлы";


    public Action[] Tasks() => new[] { Task1, Task2 };

    private static void Task1()
    {
        Utils.WriteLineCenter("Запись файла");
        using var writer = new StreamWriter("toys.lab11.json", true);
        do
        {
            var toy = Toy.ReadStdin();
            writer.Write(JsonSerializer.Serialize(toy));
        } while (Utils.Read("Добавить ещё одну игрушку? y/n") == "y");

        writer.Flush();
    }

    private static void Task2()
    {
        Utils.WriteLineCenter("Чтение файла");
        var year = Utils.Read<int>("Год?");

        using var reader = new StreamReader("toys.lab11.json");
        var total = 0;
        while (true)
        {
            var line = reader.ReadLine();
            if (line is null) break;
            var toy = JsonSerializer.Deserialize<Toy>(line);
            total += toy.Price;
            if (toy.Year == year && toy.Material == "Дерево")
                Utils.WriteLineCenter(toy.ToString());
        }
        Utils.WriteLineCenter($"Суммарная цена: {total}");
    }
}