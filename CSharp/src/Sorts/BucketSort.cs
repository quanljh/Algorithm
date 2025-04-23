namespace Algorithm.Sorts;

public class BucketSort
{
    public decimal[] Sort(decimal[] arr)
    {
        var buckets = arr.Select(_ => (List<decimal>) []).ToList();

        foreach (var d in arr)
        {
            var index = (int)(d * arr.Length);
            buckets[index].Add(d);
        }

        foreach (var b in buckets)
        {
            InsertionSort(b);
        }
        
        var result= buckets.SelectMany(x=> x).ToArray();
        return result;
    }

    public void InsertionSort(List<decimal> arr)
    {
        for (var i = 1; i < arr.Count; i++)
        {
            var key = arr[i];
            var j = i - 1;

            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j -= 1;
            }
            arr[j + 1] = key;
        }
    }
}