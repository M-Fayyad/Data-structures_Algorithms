using System.Security.Cryptography;

namespace Stack_implementation;

//<T> represent to Generic Stack that can work with any data type.
public class Stack_Array_based<T>(int size)
{
    public int Top { get; set; } = -1;
    public T[] Itmes { get; set; } = new T[size];

    public void Push(T value)
    {

        if (Top == size - 1)
        {
            Console.WriteLine("Stack Overflow");
        }
        else
        {
            Top++;
            Itmes[Top] = value;
        }
    }

    public void PrintStack()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Stack is empty");
        }
        else
        {
            Console.Write("[ ");
            for (int i = Top; i >= 0; i--)
            {
                Console.Write($"{Itmes[i]} ");
            }
            Console.Write("]");
        }
    }

    public bool IsEmpty()
    {
        return Top < 0;
    }
    
    public void Pop()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Stack is empty");
        }
        else
        {
            Top--;
        }
    }
    public int Peek()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Stack is empty");
            return -1;
        }
        else
        {
            return Top;
        }
    }
}
