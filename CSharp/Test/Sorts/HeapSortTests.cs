using Algorithm.Sorts;

namespace TestProject1.Sorts;

public class HeapSortTests
{
    [Fact]
    public void TestHeapSort()
    {
        var array = new[] { 5, 2, 4, 6, 1, 3 };
        
        new HeapSort().Sort(array);
        
        Assert.Equal([1, 2, 3, 4, 5, 6 ], array);
    }
}