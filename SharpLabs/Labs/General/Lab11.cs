using System.Text.Json;

namespace Labs.General;

public struct Phone
{
    public int Id;
    public string Model;
    public string Manufacturer;
    public int Price;

    public static Phone ReadStdin()
    {
        var model = Utils.Read("Введите название модели")!;
        var manufacturer = Utils.Read("Введите производителя")!;
        var price = Utils.Read<int>("Введите цену");
        return new Phone { Id = model.GetHashCode() + manufacturer.GetHashCode() + price, Model = model, Manufacturer = manufacturer, Price = price };
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
        using var writer = new StreamWriter("phones.lab11.json", true);
        do
        {
            var phone = Phone.ReadStdin();
            writer.Write(JsonSerializer.Serialize(phone));
        } while (Utils.Read("Добавить ещё один телефон? y/n") == "y");
        writer.Flush();
    }

    private static void Task2()
    {
        Utils.WriteLineCenter("Чтение файла");
        var manufacturer = Utils.Read("Производитель?");
        var money = Utils.Read<int>("Бюджет?");
        
        using var reader = new StreamReader("phones.lab11.json");
        while(true)
        {
            var line = reader.ReadLine();
            if (line is null) break;
            var phone = JsonSerializer.Deserialize<Phone>(line);
            if (phone.Price <= money && phone.Manufacturer == manufacturer)
                Utils.WriteLineCenter(phone.ToString());
        }
    }
}