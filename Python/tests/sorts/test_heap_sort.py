import os
from src.sorts.heap_sort import heap_sort

def test_heap_sort():
    array = [1, 3, 2, 7, 4, 5]
    heap_sort(array)
    print(f"{os.linesep}New array: {array}")
    assert array == [1, 2, 3, 4, 5, 7]