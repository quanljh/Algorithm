import os
from src.sorts.bucket_sort import bucket_sort

def test_bucket_sort():
    array = [0.78, 0.17, 0.39, 0.26, 0.72, 0.94, 0.21, 0.12, 0.23, 0.68]
    result = bucket_sort(array)
    print(f"{os.linesep}{array}")
    assert [0.12, 0.17, 0.21, 0.23, 0.26, 0.39, 0.68, 0.72, 0.78, 0.94] == result