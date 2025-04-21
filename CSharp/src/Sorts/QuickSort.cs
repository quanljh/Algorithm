namespace Algorithm.Sorts;

public class QuickSort
{
    public void Sort(int[] array, int low, int high)
    {
        if (low >= high)
            return;
        
        var pivot = Partition(array, low, high);
        Sort(array, low, pivot - 1);
        Sort(array, pivot + 1, high);
    }

    private int Partition(int[] array, int low, int high)
    {
        var pivot = array[high];
        var i = low - 1;

        for (var j = low; j < high; j++)
        {
            if (array[j] < pivot)
            {
                i++;
                (array[i], array[j]) = (array[j], array[i]);
            }
        }
        (array[i + 1], array[high]) = (array[high], array[i + 1]);
        return i + 1;
    }
}