namespace QuestionSolutions.Day04;

public class Day04Tests
{
    private readonly Day04Solution _sut = new();
    
    [Fact]
    public async Task Question1()
    {
        var input = await File.ReadAllLinesAsync(Path.Combine("Day04", "input.txt"));

        var result = _sut.CalculateTotalOverlaps(input);
        
        result.Should().Be(494);
    }

    [Theory]
    [InlineData("2-4,1-5")]
    [InlineData("1-5,2-4")]
    public void TotalOverlaps_GivenOnePairContainingAFullRangeIntersection_ReturnsOne(string input)
    {
        var result = _sut.CalculateTotalOverlaps(new[] {input});

        result.Should().Be(1);
    }

    [Fact]
    public async Task Question2()
    {
        var input = await File.ReadAllLinesAsync(Path.Combine("Day04", "input.txt"));

        var result = _sut.CalculatePartialOverlaps(input);
        
        result.Should().Be(833);
    }

    [Fact]
    public void PartialOverlaps_GivenFirstContainsOtherRange_ReturnsOne()
    {
        const string input = "1-5,2-4";
        var result = _sut.CalculatePartialOverlaps(new []{input});
        result.Should().Be(1);
    }

    [Fact]
    public void PartialOverlaps_GivenFirstIsContainedByOtherRange_ReturnsOne()
    {
        const string input = "2-4,1-5";
        var result = _sut.CalculatePartialOverlaps(new []{input});
        result.Should().Be(1);
    }

    [Fact]
    public void PartialOverlaps_GivenFirstContainsOtherStart_ReturnsOne()
    {
        const string input = "1-5,2-9";
        var result = _sut.CalculatePartialOverlaps(new []{input});
        result.Should().Be(1);
    }

    [Fact]
    public void PartialOverlaps_GivenFirstContainsOtherEnd_ReturnsOne()
    {
        const string input = "2-9,1-5";
        var result = _sut.CalculatePartialOverlaps(new []{input});
        result.Should().Be(1);
    }

    [Fact]
    public void PartialOverlaps_GivenFirstEndEqualsOtherStart_ReturnsOne()
    {
        const string input = "1-2,2-7";
        var result = _sut.CalculatePartialOverlaps(new []{input});
        result.Should().Be(1);
    }

    [Fact]
    public void PartialOverlaps_GivenFirstStartEqualsOtherEnd_ReturnsOne()
    {
        const string input = "2-7,1-2";
        var result = _sut.CalculatePartialOverlaps(new []{input});
        result.Should().Be(1);
    }
    
    [Fact]
    public void PartialOverlaps_GivenFirstStartEqualsOtherStart_ReturnsOne()
    {
        const string input = "1-2,1-7";
        var result = _sut.CalculatePartialOverlaps(new []{input});
        result.Should().Be(1);
    }
}