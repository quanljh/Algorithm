def sort(array, low, high):
    if low >= high:
        return
    pivot = parition(array, low, high)
    sort(array, low, pivot - 1)
    sort(array, pivot + 1, high)

def parition(array, low, high):
    pivot = array[high]
    i = low - 1
    for j in range(low, high):
        if array[j] < pivot:
            i += 1
            array[i], array[j] = array[j], array[i]
    array[i + 1], array[high] = array[high], array[i + 1]
    return i + 1