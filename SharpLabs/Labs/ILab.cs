namespace Labs;

public interface ILab
{
    string Name { get; }
    int Number { get; }
    Action[] Entry();
}