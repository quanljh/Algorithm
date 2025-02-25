import os
from src.InsertionSort import sort

def test_helloWorld():
    array = [2,3,6,5,12,1]
    sort(array)
    print(f"{os.linesep}New array: {array}")
    assert array == [1,2,3,5,6,12]