import os
from src.MergeSort import merge, mergeSort

def testMerge():
    array = [2,3,6,5,7,9]
    merge(array, 0, 2, 5)
    print(f"{os.linesep}New array: {array}")
    assert array == [2,3,5,6,7,9]

def testMergeSort():
    array = [12, 3, 7, 9, 14, 6, 11]
    mergeSort(array, 0, len(array)-1)
    print(f"{os.linesep}Sorted array: {array}")
    assert array == [3, 6, 7, 9, 11, 12, 14]
