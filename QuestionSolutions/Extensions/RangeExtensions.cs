namespace QuestionSolutions.Extensions;

public static class RangeExtensions
{
    public static bool Contains(this Range @this, Range other) =>
        @this.Contains(other.Start.Value) && @this.Contains(other.End.Value);

    public static bool Overlaps(this Range @this, Range other) =>
        @this.Contains(other.Start.Value) || other.Contains(@this.Start.Value);
    
    public static bool Contains(this Range @this, int other) => 
        @this.Start.Value <= other && @this.End.Value >= other;
}