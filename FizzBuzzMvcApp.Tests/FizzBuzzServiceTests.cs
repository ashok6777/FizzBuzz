using FizzBuzzMvcApp.Services;

namespace FizzBuzzMvcApp.Tests;

public class FizzBuzzServiceTests
{
    private readonly IFizzBuzzService _fizzBuzzService;

    public FizzBuzzServiceTests()
    {
        _fizzBuzzService = new FizzBuzzService();
    }

    [Theory]
    [InlineData(new string[] { "1", "3", "5", "15", "A" }, new string[] { "Divided 1 by 3", "Divided 1 by 5", "Fizz", "Buzz", "FizzBuzz", "Invalid item" })]
    [InlineData(new string[] { "1", "3#", "5@", "15$", "A*" }, new string[] { "Divided 1 by 3", "Divided 1 by 5", "Invalid item", "Invalid item", "Invalid item", "Invalid item" })]
    public void ProcessArray_ValidInput_ReturnsExpectedResults(string[] input, string[] expected)
    {
        var result = _fizzBuzzService.ProcessArray(input);
        Assert.Equal(expected, result);
    }
}
