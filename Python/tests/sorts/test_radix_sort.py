import os
from src.sorts.radix_sort import radix_sort

def test_radix_sort():
    array = [329, 457, 657, 839, 436, 720, 355]
    radix_sort(array)
    print(f"{os.linesep}{array}")
    assert [329, 355, 436, 457, 657, 720, 839] == array

