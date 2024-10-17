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

        dynamic leslie = "leslie";

          int num = 42;
        int* ptr = &num;

        Console.WriteLine("Value of num: " + num);           // Output: 42
        Console.WriteLine("Address of num: " + (int)ptr);    // Outputs memory address
        Console.WriteLine("Value using pointer: " + *ptr);   // Output: 42

        *ptr = 50; // Modify value using pointer
        Console.WriteLine("Modified value of num: " + num);  // Output: 50
    }
}