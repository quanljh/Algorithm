def count_sort(array):
    b = [0] * len(array)
    c = [0] * len(array)

    for i in range(0, len(array)):
        c[array[i]] += 1

    for i in range(1, len(c)):
        c[i] += c[i - 1]

    for i in range(len(array) - 1, -1, -1):
        b[c[array[i]] - 1] = array[i]
        c[array[i]] -= 1
    
    return b