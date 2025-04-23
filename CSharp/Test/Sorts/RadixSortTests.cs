using Algorithm.Sorts;

namespace TestProject1.Sorts;

public class RadixSortTests
{
    [Fact]
    public void TestRadixSort()
    {
        int[] array = [329, 457, 657, 839, 436, 720, 355];
        
        new RadixSort().Sort(array);
        
        Assert.Equal([329, 355, 436, 457, 657, 720, 839], array);
    }
}