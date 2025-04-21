namespace Algorithm.Sorts;

public class CountSort
{
    public int[] Sort(int[] array)
    {
        var b = new int[array.Length];
        var c = new int[array.Length];

        for (var i = 0; i < array.Length; i++)
        {
            c[array[i]] += 1;
        }

        for (var i = 1; i < b.Length; i++)
        {
            c[i] += c[i - 1];
        }

        for (var i = array.Length - 1; i >= 0; i--)
        {
            b[c[array[i]] - 1] = array[i];
            c[array[i]] -= 1;
        }

        return b;
    }
}