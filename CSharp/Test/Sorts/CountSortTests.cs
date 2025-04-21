using Algorithm.Sorts;

namespace TestProject1.Sorts;

public class CountSortTests
{
    [Fact]
    public void TestCountSort()
    {
        int[] array = [2, 5, 3, 0, 2, 3, 0, 3];
        var sortedArray = new CountSort().Sort(array);
        Assert.Equal([0, 0, 2, 2, 3, 3, 3, 5], sortedArray);
    }
}