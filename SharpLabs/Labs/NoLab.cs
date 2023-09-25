namespace Labs;

public class NoLab : ILab
{
    public string Name => "Название";
    public int Number => -1;
    public void Entry()
    {
        Utils.WriteLineCenter("Этой лабораторной работы ещё нет");
    }
}