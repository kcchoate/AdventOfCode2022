namespace QuestionSolutions.Day08;

public record Tree(int Height, int X, int Y)
{
    public bool IsVisible { get; set; }
    public int ScenicScore { get; set; }
}
