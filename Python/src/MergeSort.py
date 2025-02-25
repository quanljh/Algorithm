def mergeSort(A, p, r):
    if p >= r:
        return
    q = (p + r) // 2
    mergeSort(A, p, q)
    mergeSort(A, q+1, r)
    merge(A, p, q, r)

def merge(A, p, q, r):
    nL = q - p + 1
    nR = r - q
    L = A[p:q+1]
    R = A[q+1:r+1]

    i = 0
    j = 0
    k = p

    while i < nL and j < nR:
        if L[i] < R[j]:
            A[k] = L[i]
            i += 1
        else:
            A[k] = R[j]
            j += 1
        k += 1
    
    while i < nL:
        A[k] = L[i]
        i += 1; 
        k += 1

    while j < nR:
        A[k] = R[j]
        j += 1; 
        k += 1
