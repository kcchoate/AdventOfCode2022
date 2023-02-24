namespace QuestionSolutions.Day07;

public class Directory : Item
{
    public List<Item> SubItems { get; } = new();

    public Directory(string name)
    {
        Name = name;
    }

    public override int GetSize() => SubItems.Sum(x => x.GetSize());
}
