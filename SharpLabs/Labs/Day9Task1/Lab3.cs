namespace Labs.Day9Task1;

public class Lab3 : ILab
{
    public string Name => "Оператор множественного выбора";
    public int Number => 3;

    public Action[] Tasks() => new[] { Task1 };

    private static void Task1()
    {
        Utils.WriteLineCenter("По введённому номеру времени года (1 - зима, 2 - весна, 3 - лето, 4 - осень)");
        Utils.WriteLineCenter("Получить соответствующие этому времени года месяцы и число дней в каждом месяце");

        var season = Utils.Read<int>("Введите время года (1 - зима, 2 - весна, 3 - лето, 4 - осень)", v => v is > 0 and < 5);
        var message = season switch
        {
            1 => "Зима: Декабрь (31 дней), Январь (31 дней), Февраль (28 или 29 дней)",
            2 => "Весна: Март (31 дней), Апрель (30 дней), Май (31 дней)",
            3 => "Лето: Июнь (30 дней), Июль (31 дней), Август (31 дней)",
            4 => "Осень: Сентябрь (30 дней), Октябрь (31 дней), Ноябрь (30 дней)",
            _ => throw new ArgumentOutOfRangeException()
        };
        
        Utils.WriteLineCenter(message);
    }
}