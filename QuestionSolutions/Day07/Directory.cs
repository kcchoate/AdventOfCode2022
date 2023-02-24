namespace QuestionSolutions.Day07;

public class Directory : Item
{
    public List<Item> SubItems { get; } = new();
    public Directory? ParentDirectory { get; set; }

    public Directory(string name)
    {
        Name = name;
    }

    public override int GetSize() => SubItems.Sum(x => x.GetSize());

    public Directory GetSubDirectory(string name) => SubItems.OfType<Directory>().First(x => x.Name == name);
}
