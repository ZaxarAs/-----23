namespace MyProject.Tests;

public class MathTests
{
    [Fact]
    public void Add_ShouldReturnCorrectSum()
    {
        var result = MathOperations.Add(2.5, 3.5);
        Assert.Equal(6.0, result);
    }
}
//1 commit