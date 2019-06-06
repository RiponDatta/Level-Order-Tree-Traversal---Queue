# Level Order Tree Traversal using Queue
Level Order Tree Traversal using Queue

## Algorithm
PrintLevelOrder(tree)
1) Create an empty queue q
2) Enqueue tree->Root into q
3) Loop while q is not empty<br/>
    a) temp -> Dequeue q <br/>
    b) Print temp->Data<br/>
    c) Enqueue q->LeftChild & q->RightChild<br/>
