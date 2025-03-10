using Algorithm.Sorts;

namespace TestProject1.Sorts;

public class MergeSortTests
{
    [Fact]
    public void MergeTest()
    {
        var array = new[] { 1, 2, 3, 2, 3, 6 };

        new MergeSort().Merge(array, 0, 2, 5);

        Assert.Equal(new[] { 1, 2, 2, 3, 3, 6 }, array);
    }
    
    [Fact]
    public void MergeSortTest()
    {
        var array = new[] { 1, 2, 4, 7, 2, 3, 5, 6 };

        new MergeSort().Sort(array, 0, array.Length - 1);

        Assert.Equal(new[] { 1, 2, 2, 3, 4, 5, 6, 7 }, array);
    }
}