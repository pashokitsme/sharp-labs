namespace Labs;

public class NoLab : ILab
{
    public string Name => "Название";
    public int Number => -1;
    public Action[] Entry() => Array.Empty<Action>();
}