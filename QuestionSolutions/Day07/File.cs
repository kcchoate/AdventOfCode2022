namespace QuestionSolutions.Day07;

public record File : Item
{
    private readonly int _size;

    public File(string name, int size)
    {
        Name = name;
        _size = size;
    }

    public override int GetSize()
    {
        return _size;
    }
}
