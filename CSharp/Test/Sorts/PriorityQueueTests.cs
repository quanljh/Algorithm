using Algorithm.Sorts;

namespace TestProject1.Sorts;

public class PriorityQueueTests
{
    
    [Fact]
    public void MaxPriorityQueueTest()
    {
        var array = new (int key, string value)[]
        {
            (5, "5"),
            (3, "3"),
            (4, "4"),
            (2, "2"),
            (1, "1"),
            (int.MaxValue, "Max"),
        };
        
        var priorityQueue = new PriorityQueue<string>(array, 5);
        var max = priorityQueue.MaxHeapExtractMax();
        Assert.Equal("5", max.Value);
        var output1 = priorityQueue.OutputQueue();
        Assert.Equal(new (int key, string value) []{
            (4, "4"),
            (3, "3"),
            (1, "1"),
            (2, "2")
        }, output1);
        
        priorityQueue.MaxHeapInsert(6, "6");
        var output2 = priorityQueue.OutputQueue();
        Assert.Equal(new (int key, string value) [] {
            (6, "6"),
            (4, "4"),
            (1, "1"),
            (2, "2"),
            (3, "3")
        }, output2);
    }
}