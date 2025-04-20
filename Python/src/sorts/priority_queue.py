class PriorityQueue:
    def __init__(self, initial=None):
        if initial is None:
            self.heap = []
        else:
            self.heap = initial
            for i in range (len(initial) // 2 - 1, -1, -1):
                self._heapify(i)

    def parent(self, i): return (i - 1) // 2
    def left(self, i): return i * 2 + 1
    def right(self, i): return i * 2 + 2

    def insert(self, key, value):
        self.heap.append((key, value))
        self._increase_key(key)
        
    def maximum(self):
        if not self.heap:
            raise IndexError("Priority queue is empty")
        return self.heap[0]
    
    def extract_max(self):
        if not self.heap:
            raise IndexError("Priority queue is empty")
        max_item = self.heap[0]
        self.heap[0] = self.heap[-1]
        self.heap.pop()
        self._heapify(0)
        return max_item

    def _increase_key(self, next_key):
        i = len(self.heap) - 1

        if next_key < self.heap[i][0]:
            raise ValueError("New key is smaller than current key")
        
        while i > 0 and self.heap[self.parent(i)][0] < self.heap[i][0]:
            p = self.parent(i)
            self.heap[p], self.heap[i] = self.heap[i], self.heap[p]
            i = p
    
    def _heapify(self, i):
        l = self.left(i)
        r = self.right(i)
        largest = i
        
        if l < len(self.heap) and self.heap[l][0] > self.heap[largest][0]:
            largest = l
        if r < len(self.heap) and self.heap[r][0] > self.heap[largest][0]:
            largest = r
        
        if largest != i:
            self.heap[i], self.heap[largest] = self.heap[largest], self.heap[i]
            self._heapify(largest)

    def get_heap(self):
        return self.heap

