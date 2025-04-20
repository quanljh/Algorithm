def merge_inversion(A, p, r):
    inversion = 0
    if p >= r:
        return inversion
    q = (p + r) // 2
    inversion += merge_inversion(A, p, q)
    inversion += merge_inversion(A, q+1, r)
    inversion += merge(A, p, q, r)
    return inversion

def merge(A, p, q, r):
    inversion = 0
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
            inversion += 1
        k += 1
    
    while i < nL:
        A[k] = L[i]
        i += 1; 
        k += 1

    while j < nR:
        A[k] = R[j]
        j += 1; 
        k += 1
    return inversion