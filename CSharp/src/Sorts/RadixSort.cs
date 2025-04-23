namespace Algorithm.Sorts;

public class RadixSort
{
    public void Sort(int[] array)
    {
        var max = GetMax(array);

        for (var exp = 1; max / exp > 0; exp *= 10)
            CountingSort(array, exp);
    }

    private int GetMax(int[] array)
    {
        var max = array[0];
        for (var i = 1; i < array.Length; i++)
            if (array[i] > max)
                max = array[i];
        return max;
    }

    private void CountingSort(int[] array, int exp)
    {
        var n = array.Length;
        var output = new int[n];
        var count = new int[10];

        for (var i = 0; i < n; i++)
        {
            var digit = (array[i] / exp) % 10;
            count[digit]++;
        }

        for (var i = 1; i < 10; i++)
        {
            count[i] += count[i - 1];
        }

        for (var i = n - 1; i >= 0; i--)
        {
            var digit = (array[i] / exp) % 10;
            output[count[digit] - 1] = array[i];
            count[digit]--;
        }

        for (var i = 0; i < n; i++)
        {
            array[i] = output[i];
        }
    }
}