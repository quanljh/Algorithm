import os
from src.sorts.count_sort import count_sort

def test_count_sort():
    array = [2, 5, 3, 0, 2, 3, 0, 3]
    new_array = count_sort(array)
    print(f"{os.linesep}{new_array}")
    assert [0, 0, 2, 2, 3, 3, 3, 5] == new_array
