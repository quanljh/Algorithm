using Algorithm.Sorts;

namespace TestProject1.Sorts;

public class InsertionSortTests
{
    [Fact]
    public void SortTest()
    {
        var array = new[] { 5, 2, 4, 6, 1, 3 };

        new InsertionSort().Sort(array);

        Assert.Equal(new[] { 1, 2, 3, 4, 5, 6 }, array);
    }
    
    [Fact]
    public void SortByDescendTest()
    {
        var array = new[] { 5, 2, 4, 6, 1, 3 };

        new InsertionSort().SortByDescend(array);

        Assert.Equal(new[] { 6, 5, 4, 3, 2, 1 }, array);
    }
}