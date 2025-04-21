import os
from src.sorts.quick_sort import sort

def test_quick_sort():
    array = [5, 4, 1, 2, 3]
    sort(array, 0, len(array) - 1)
    print(f"{os.linesep}{array}")
    assert [1, 2, 3, 4, 5] == array