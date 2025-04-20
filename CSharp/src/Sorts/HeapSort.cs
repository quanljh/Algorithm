namespace Algorithm.Sorts;

public class HeapSort
{
    private void MaxHeapify(int[] array, int n, int i)
    {
        var left = 2 * i;
        var right = 2 * i + 1;
        var largest = i;
        if (left <= n && array[i - 1] < array[left - 1])
        {
            largest = left;
        }

        if (right <= n && array[right - 1] > array[largest - 1])
        {
            largest = right;
        }

        if (largest != i)
        {
            (array[i - 1], array[largest - 1]) = (array[largest - 1], array[i - 1]);
            MaxHeapify(array, n, largest);
        }
    }

    private void BuildMaxHeap(int[] array, int n)
    {
        for (var j = n / 2; j >= 1; j--)
        {
            MaxHeapify(array, n, j);
        }
    }

    public void Sort(int[] array)
    {
        var length = array.Length;
        BuildMaxHeap(array, length);
        for (var i = array.Length; i >= 2; i--)
        {
            (array[0], array[i - 1]) = (array[i - 1], array[0]);
            length--;
            MaxHeapify(array, length, 1);
        }
    }
}