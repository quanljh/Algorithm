import os
from src.sorts.priority_queue import PriorityQueue


def test_priority_queue():
    array = [(5, "5"), (3, "3"), (4, "4"), (2, "2"), (1, "1")]
    pq = PriorityQueue(array)
    max_item = pq.extract_max()
    assert "5" == max_item[1]
    output1 = pq.get_heap()
    assert [(4, "4"), (3, "3"), (1, "1"), (2, "2")] == output1
    pq.insert(6, "6")
    output2 = pq.get_heap()
    assert [(6, "6"), (4, "4"), (1, "1"), (2, "2"), (3, "3")] == output2
