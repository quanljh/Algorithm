def bucket_sort(array):
    l = len(array)
    
    buckets = [[] for _ in range (l) ]

    for x in array:
        index = int(l * x)
        buckets[index].append(x)

    result = []
    for b in buckets:
        insertion_sort(b)
        result.extend(b)
    return result

def insertion_sort(array):
    l = len(array)
    for i in range(1, l):
        key = array[i]
        j = i - 1
        while j >= 0 and key < array[j]:
            array[j + 1] = array[j]
            j -= 1
        array[j + 1] = key
        
