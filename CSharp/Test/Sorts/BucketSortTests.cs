using Algorithm.Sorts;

namespace TestProject1.Sorts;

public class BucketSortTests
{
    [Fact]
    public void TestBucketSort()
    {
        decimal[] array = [0.78m, 0.17m, 0.39m, 0.26m, 0.72m, 0.94m, 0.21m, 0.12m, 0.23m, 0.68m];
        var result = new BucketSort().Sort(array);
        Assert.Equal([0.12m, 0.17m, 0.21m, 0.23m, 0.26m, 0.39m, 0.68m, 0.72m, 0.78m, 0.94m], result);
    }
}