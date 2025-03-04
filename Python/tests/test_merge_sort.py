import os
from src.merge_sort import merge, merge_sort

def test_merge():
    array = [2,3,6,5,7,9]
    merge(array, 0, 2, 5)
    print(f"{os.linesep}New array: {array}")
    assert array == [2,3,5,6,7,9]

def test_merge_sort():
    array = [12, 3, 7, 9, 14, 6, 11]
    merge_sort(array, 0, len(array)-1)
    print(f"{os.linesep}Sorted array: {array}")
    assert array == [3, 6, 7, 9, 11, 12, 14]
