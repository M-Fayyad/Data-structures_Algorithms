namespace Array_implementation;

class Array(int arrSize)
{
    public int Size { get; set; } = arrSize;
    public int Length { get; set; } = 0;
    public int[] Items { get; set; } = new int[arrSize];


    public void Fill()
    {
        Console.WriteLine("How many item you want to fill: ");
        int numOfItems = int.Parse(Console.ReadLine());
        if (numOfItems < Size)
        {
            for (int i = 0; i < numOfItems; i++)
            {
                Console.WriteLine($"Enter intdex {i}");
                Items[i] = int.Parse(Console.ReadLine());
                Length++;
            }
        }
        else
        {
            Console.WriteLine("You can't exceeded the array size.");
        };

    }
    public int GetSize()
    {
        return Size;
    }

    public int GetLength()
    {
        return Length;
    }

    public void PrintArray()
    {
        for (int i = 0; i < Length; i++)
        {
            Console.WriteLine(Items[i]);
        }
    }

}




class Program
{
    static void Main(string[] args)
    {
        Array myArray = new(10);
        myArray.Fill();
        myArray.PrintArray();


    }
}
