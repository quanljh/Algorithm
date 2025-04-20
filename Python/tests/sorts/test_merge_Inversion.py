from src.sorts.merge_inversion import merge_inversion 

def test_merge_inversion():
    array = [3,2,4,3,7,9]
    inversion = merge_inversion(array, 0, len(array)-1)
    assert inversion == 2