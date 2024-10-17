class Program
{
    static void Main(string[] args)
    {

        // Declare and initialize an array
        int[] numbers = { 10, 20, 30, 40, 50 };
        
        // Access array elements
        Console.WriteLine("First element: " + numbers[0]);
        Console.WriteLine("Second element: " + numbers[1]);
        
        // Modify an element
        numbers[1] = 25;
        Console.WriteLine("Modified second element: " + numbers[1]);
        
        // Iterate through the array
        Console.WriteLine("Array elements:");
        foreach (int number in numbers) {
            Console.WriteLine(number);
        }
        
        // Find the length of the array
        Console.WriteLine("Length of array: " + numbers.Length);
    }
}