using Algorithm.Sorts;

namespace TestProject1.Sorts;

public class QuickSortTests
{
    [Fact]
    public void TestSort()
    {
        int[] array = [5, 4, 1, 2, 3];

        new QuickSort().Sort(array, 0, array.Length - 1);

        Assert.Equal([ 1, 2, 3, 4, 5 ], array);
    }
}