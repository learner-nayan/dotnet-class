namespace ConsoleApp1.SessionOne.AppBasic
{
    using System;
    
    public class Foo {}

    public static class Jump
    {
        public static void Run()
        {
            int count = 1, number = 1;
            int[] numbers = new int[] { 2, 4, 6, 12, 8, 10 };

            // using break to terminate a loop 
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 10)
                {
                    Console.WriteLine($"\nNumber greater than 10 found: {numbers[i]}");
                    break;
                }

                Console.WriteLine($"\nNumber : {numbers[i]} at index {i}");
            }

            Console.WriteLine();
            Console.WriteLine("Odd numbers:");

            while (count < 10)
            {
                if (count % 2 == 0)
                {
                    count++;
                    continue;
                }

                count++;
                Console.WriteLine(count + " ");
            }

            Console.WriteLine();
            ProcessNumbers();
            Console.WriteLine();

            Console.WriteLine("From goto statement:");

            startLoop:
            if (number <= 5)
            {
                Console.Write(number + " ");
                number++;
                goto startLoop;
            }
        }

        private static void ProcessNumbers()
        {
            Console.WriteLine("\nEnter number:");
            for (int i = 0; i <= 10; i++)
            {
                if (i == 5)
                {
                    break;
                }

                Console.Write(i + " ");
            }

            Console.WriteLine("\nThe breaking condition has been encountered");
        }
    }

    namespace Inner
    {
        public class Foo {}

        public class Test
        {
            Foo? innerFoo; // from the foo class of Inner namespace
            AppBasic.Foo? outerFoo; // from the foo class of AppBasic namespace
        }
    }
}
