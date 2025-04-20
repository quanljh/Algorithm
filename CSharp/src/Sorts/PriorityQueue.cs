namespace Algorithm.Sorts;

public class PriorityQueue<TValue>
{
    private (int Key, TValue Value)[] _array;
    
    private int _size;

    private int Parent(int i) => (i + 1) / 2 - 1;
    private int Left(int i) => (i + 1) * 2 - 1;
    private int Right(int i) => (i + 1) * 2;
    
    public PriorityQueue(int capacity)
    {
        _array = new (int, TValue)[capacity];
        _size = 0;
    }

    public PriorityQueue((int Key, TValue Value)[] array, int capacity)
    {
        _array = array;
        _size = capacity;
        for (var i = _size / 2 - 1; i >= 0; i--)
            MaxHeapify(i);
    }

    private void MaxHeapify(int i)
    {
        var left = Left(i);
        var right = Right(i);
        var largest = i;
        if (left <= _size && _array[largest].Key < _array[left].Key)
            largest = left;

        if (right <= _size && _array[largest].Key < _array[right].Key)
            largest = right;

        if (largest != i)
        {
            (_array[i], _array[largest]) = (_array[largest], _array[i]);
            MaxHeapify(largest);
        }
    }
    
    public (int Key, TValue Value) MaxHeapMaximum()
    {
        if (_array.Length == 0)
            throw new ArgumentException("Array is empty");
        return _array[0];
    }

    public (int Key, TValue Value) MaxHeapExtractMax()
    {
        var max = MaxHeapMaximum();
        _array[0] = _array[_size - 1];
        _size--;
        MaxHeapify(0);
        return max;
    }

    public void MaxHeapIncreaseKey(int k)
    {
        var index = _size - 1;
        
        if (k < _array[index].Key)
            throw new ArgumentException("new key is smaller then the current key");
        
        // Loop until reach the left child of root node
        while (index > 0 && _array[Parent(index)].Key < _array[index].Key)
        {
            var p = Parent(index);
            (_array[p], _array[index]) = (_array[index], _array[p]);
            index = p;
        }
    }

    public void MaxHeapInsert(int key, TValue value)
    {
        _size++;
        
        if (_size > _array.Length)
        {
            throw new ArgumentException("heap overflow");
        }
        
        _array[_size - 1] = (key, value);
        MaxHeapIncreaseKey(key);
    }

    public (int key, TValue value)[] OutputQueue()
    {
        return _array[.._size];
    }
}