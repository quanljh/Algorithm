def radix_sort(array):
    max = array[0]
    for i in range(1, len(array)):
        if array[i] > max:
            max = array[i]

    exp = 1
    while max // exp > 0:
        _count_sort(array, exp)
        exp *= 10

def _count_sort(array, exp):
    n = len(array)
    output = [0] * n
    count = [0] * 10

    for i in range(0, n):
        digit = (array[i] // exp) % 10
        count[digit] += 1
    
    for i in range(1, 10):
        count[i] += count[i - 1]

    for i in range(n - 1, -1, -1):
        digit = (array[i] // exp) % 10
        output[count[digit] - 1] = array[i]
        count[digit] -= 1

    for i in range(0, n):
        array[i] = output[i]

