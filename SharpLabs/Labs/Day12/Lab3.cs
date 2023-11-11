namespace Labs.Day12;

public class Lab3: ILab
{
    public string Name => "Стуктура Lib";
    public int Number => 3;

    private struct Lib
    {
        public string Name { get; init; }
        public string Author { get; init; }
        public int PublishYear { get; init; }
        public int Pages { get; init; }

        public override string ToString() => $"Книга: {Name}. Автор: {Author}. Год публикации: {PublishYear}. Количество страниц: {Pages}";
    }

    public Action[] Tasks() => new[] { Task1 };

    private static void Task1()
    {
        const string path = "books.txt";
        const int year = 2023;
        
        var books = GenerateBooks(100).ToList();
        File.WriteAllLines(path, books.Select(b => b.ToString()));

        Utils.WriteLineCenter("Книги, которые не будут списаны:");
        foreach (var book in books.Where (b => year - b.PublishYear <= 20))
            Utils.WriteLineCenter(book.ToString());
    }

    private static IEnumerable<Lib> GenerateBooks(int n)
        => Enumerable.Range(0, n).Select(v => new Lib
            {
                Name = $"Книга_{Random.Shared.Next(0, 5)}",
                Author = $"Автор_${Random.Shared.Next(0, 5)}",
                Pages = Random.Shared.Next(100, 1000),
                PublishYear = Random.Shared.Next(1970, 2023)
            }).ToList();
}