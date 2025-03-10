namespace Algorithm.Sorts;

public class InsertionSort
{
    public void Sort(int[] array)
    {
        var n = array.Length;

        for (var i = 1; i < n; i++)
        {
            var key = array[i];
            var j = i - 1;

            while (j >= 0 && array[j] > key)
            {
                array[j + 1] = array[j];
                j -= 1;
            }
            array[j + 1] = key;
        }
    }
    
    public void SortByDescend(int[] array)
    {
        var n = array.Length;

        for (var i = 1; i < n; i++)
        {
            var key = array[i];
            var j = i - 1;

            while (j >= 0 && array[j] < key)
            {
                array[j + 1] = array[j];
                j -= 1;
            }
            array[j + 1] = key;
        }
    }
}