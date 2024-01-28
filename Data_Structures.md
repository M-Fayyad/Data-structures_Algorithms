
>[!Tip]
>You don't write Algorithms, you write a program.
The program is a data structure surrounded by algorithms that manipulate and modify the data inside the data structures.
## A data structure is a specialized format for organizing and storing data 

- Data structures are designed in different forms in order to help organize data in a logical and effective manner, 
- thus improving performance and speed of access to data, read and written to storage units, and modifying them in the most appropriate manner. 
- They help enhance performance in various algorithms and manage resources such as memory efficiently.


> [!Note]
> From a purpose to another, we may arrange data in different ways 
> That is, it is NOT one way to implement a data structure

## Common data structures
People noticed some data structures that repeat much So :
- instead of each one keep re-implementing them, They are already implemented for you to use,
- Hence, in real life projects, you build more complex data structures based on the common data structures.
- Through this study, we learn how to build a data structure, Hence, we learn how to use them the commons properly

> [!Tip]
> the common ones are already coded
> - In C++, **STL library** provides its data structures 
> - Java and C# name them: **Collections** 

--- 
## Data structures are divided into two types

### Basic Data structures

- are usually based on easy logic, Hence, overall data and operations are easy  
- These are very good from teaching perspectives, We also use them much in reality
>[!Note]
>**Examples**
>
> **Lists, Stack, Queues and Trees**

### Advanced Data structures

- These were **more critical or complex scenarios** are needed.
>[!Note]
>**Examples**
>
> **Heaps, Hash tables and Red Black trees**

>[!important]
>### Hash Table
>Arrays uses key as integer. What if want the index be another data structure? or a string? **Hashtable does this magic**. One way is by converting a complex input to a single integer index and use it to return the target object.

---- 
## Abstract data type (ADT)

**Data abstraction** is a programming (and design) technique, that relies on the separation of interface (what) and implementation(How).

### ADT Interface 
1. Basic Data elements (E.g. Queue item) 
2. Operations list (name, input, output)
### Data Structure implements ADT
- Its own variables to implement the functionality 
- Methods details (specific time/memory efficiency) 
- Sub-methods that main methods need it

>[!note]
>#### What is a queue? 
>- A data structure to enqueue and dequeue items respecting FIFO principle 
>- This is a logical view (Abstract Data Type) 
>
>#### How a queue is implemented? 
>1. Using an array internally of items .
>2. Index to know where we are .
>3. Add element put in the array, index++. 
>4. Remove element, do index-- .
>5. Can we implement in different ways? SURE.
>6. List ADT might be implemented using **linked list** or **array-based list**

## Reference
[Data Structures - What and Why (Arabic)](https://www.youtube.com/watch?v=N-vU8VZ5ukA&list=PLPt2dINI2MIZX2EtY81WI-lDkvhKziLKM&index=1)
