namespace QuestionSolutions.Day07;

public abstract class Item
{
    public string Name { get; init; }

    public abstract int GetSize();
}
