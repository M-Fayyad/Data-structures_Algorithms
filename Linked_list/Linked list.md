## characteristics of linked list

A linked list is a linear data structure that consists of a sequence of nodes, where each node contains data and a reference (or pointer) to the next node in the sequence. Here are some characteristics of linked lists:

1. **Dynamic Size**: Linked lists have a dynamic size, meaning that they can grow or shrink as elements are added or removed. Unlike arrays, which have a fixed size, linked lists can accommodate an arbitrary number of elements.

2. **Node Structure**: Each node in a linked list contains two components:
   - Data: This is the actual value or information stored in the node.
   - Next Pointer: This is a reference to the next node in the sequence. It indicates the memory location of the next node.

3. **Head and Tail**: A linked list has a head and a tail.
   - Head: The head is the first node in the linked list. It serves as the starting point for traversing the list.
   - Tail: The tail is the last node in the linked list. It always points to null, indicating the end of the list.

4. **Traversal**: Linked lists can be traversed by starting at the head and following the next pointers until reaching the tail. This allows for sequential access to the elements of the list.

5. **Flexibility**: Linked lists offer flexibility in terms of insertion and deletion operations. Elements can be easily inserted or removed from any position in the list by updating the appropriate pointers.

6. **Types of Linked Lists**: Linked lists can be categorized into different types based on their structure:
   - Singly Linked List: Each node has a reference to the next node.
   - Doubly Linked List: Each node has references to both the previous and next nodes.
   - Circular Linked List: The last node points back to the first node, creating a circular structure.
