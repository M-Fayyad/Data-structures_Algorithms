namespace Stack_implementation;

class Program
{
    static void Main(string[] args)
    {
        Stack_Array_based<int> obj = new(10);
        obj.Push(10);
        obj.Push(24);
        obj.Push(25);
        obj.Push(70);
        obj.Push(19);
        obj.PrintStack();
        
    }
}
