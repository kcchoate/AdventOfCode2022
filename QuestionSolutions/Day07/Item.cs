namespace QuestionSolutions.Day07;

public abstract record Item
{
    public string Name { get; init; }

    public abstract int GetSize();
}
