namespace ConsoleApp1.SessionThree;
using System.Collections;

public static class RunAppPoly
{
    public static void RunDictionary()
    {
        Dictionary<string, int> ages = new Dictionary<string, int>();

        ages["John"] = 30;
        ages["Alex"] = 25;
        ages["Tom"] = 45;
        
        // Accessing the value by key
        Console.WriteLine($"John's age: {ages["John"]}");
        Console.WriteLine($"John's age: {ages["Alex"]}");
        
        // Iterating over the dictionary and printing key-value pairs
        foreach (KeyValuePair<string, int> entry in ages)
        {
            Console.WriteLine($"{entry.Key} is {entry.Value} years old");
        }
        
        // checking if a key exists
        if(ages.TryGetValue("Tom", out int value)) Console.WriteLine($"Tom's age: {value}");
    }

    public static void RunQueue()
    {
        Queue<int> queue = new Queue<int>();
        
        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);
        
        // Peek at the front element without removing
        Console.WriteLine($"\nFront element: {queue.Peek()}");
        
        // Dequeue elements
        Console.WriteLine($"Dequeued: {queue.Dequeue()}");
        Console.WriteLine($"Dequeued: {queue.Dequeue()}");
        
        // Check the number of elements left
        Console.WriteLine($"Number of element is queue: {queue.Count()}");
        
        // Iterate over the remaining elements
        foreach (int item in queue)
        {
            Console.WriteLine(item);
        }
    }

    public static void RunStack()
    {
        Stack<int> stack = new Stack<int>();
        
        // push element onto the stack
        stack.Push(10);
        stack.Push(20);
        stack.Push(30);
        
        // peek at the top element without removing it
        Console.WriteLine($"\nTop element: {stack.Peek()}");
        
        // pop elements from the stack
        Console.WriteLine($"Popped: {stack.Pop()}");
        Console.WriteLine($"Popped: {stack.Pop()}");
        
        // Check the number of elements left
        Console.WriteLine($"Number of element is stack: {stack.Count()}");
        
        // Iterate over the remaining elements
        foreach (int item in stack)
        {
            Console.WriteLine(item);
        }
    }
    
    public static void RunArrayList()
    {
        ArrayList list = new ArrayList();

        list.Add(10);
        list.Add("hello");
        list.Add(3.14);
        list.Add(true);
        list.Add(DateTime.Now);
        
        // accessing elements by index
        Console.WriteLine($"\nElement at index 1: {list.Count}");
        
        // removing an element
        list.Remove(true);
        
        // checking the number of elements left
        Console.WriteLine($"Number of element is ArrayList: {list.Count}");
        
        // iterating over the elements
        foreach (object item in list)
        {
            Console.WriteLine($"{item} >> {item.GetType()}");
        }
    }
}