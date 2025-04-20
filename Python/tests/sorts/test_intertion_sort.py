import os
from src.sorts.insertion_sort import sort

def test_insertion_sort():
    array = [2,3,6,5,12,1]
    sort(array)
    print(f"{os.linesep}New array: {array}")
    assert array == [1,2,3,5,6,12]