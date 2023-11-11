namespace Labs;

public class NoLab : ILab
{
    public string Name => "Название";
    public string Description => "";
    public int Number => -1;
    public Action[] Tasks() => Array.Empty<Action>();
}