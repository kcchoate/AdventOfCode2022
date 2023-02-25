namespace QuestionSolutions.Extensions;

public static class StringExtensions
{
    public static string[] SplitOnNewLine(this string @this) =>
        @this.Contains('\r')
            ? @this.Split("\r\n", StringSplitOptions.RemoveEmptyEntries)
            : @this.Split('\n', StringSplitOptions.RemoveEmptyEntries);
}
