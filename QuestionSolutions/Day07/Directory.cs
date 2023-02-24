namespace QuestionSolutions.Day07;

public record Directory : Item
{
    public List<Item> SubItems { get; } = new();
    public Directory? ParentDirectory { get; set; }

    public Directory(string name)
    {
        Name = name;
    }

    public override int GetSize() => SubItems.Sum(x => x.GetSize());
    public IEnumerable<Directory> GetSubDirectories() => SubItems.OfType<Directory>();
    public Directory GetSubDirectory(string name) => GetSubDirectories().First(x => x.Name == name);

    public IEnumerable<Directory> GetAllDirectories()
    {
        yield return this;
        foreach (var subDirectory in GetSubDirectories().SelectMany(x => x.GetAllDirectories()))
        {
            yield return subDirectory;
        }
    }
}
