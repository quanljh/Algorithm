namespace Algorithm.Sorts;

public class MergeSort
{
    public void Merge(int[] array, int left, int middle, int right)
    {
        var nL = middle - left + 1; // length of Array[left ... middle]
        var nR = right - middle; // length of Array[middle + 1 ... right]
        
        var leftArray = array[left..(middle+1)];
        var rightArray = array[(middle+1)..(right+1)];
        
        var i = 0;
        var j = 0;
        var k = left;

        while (i < nL && j < nR)
        {
            if (leftArray[i] < rightArray[j])
            {
                array[k] = leftArray[i];
                i++;
            }
            else
            {
                array[k] = rightArray[j];
                j++;
            }

            k++;
        }

        while (i < nL)
        {
            array[k] = leftArray[i];
            k++;
            i++;
        }
  
        while (j < nR)
        {
            array[k] = rightArray[j];
            k++;
            j++;
        }
    }

    public void Sort(int[] array, int left, int right)
    {
        if (left >= right) 
            return;
        var middle = (left + right) / 2;
        Sort(array, left, middle);
        Sort(array, middle + 1, right);
        Merge(array, left, middle, right);
    }
}