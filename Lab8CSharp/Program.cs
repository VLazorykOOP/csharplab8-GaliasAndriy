namespace Lab8CSharp;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lab8 C# ");
        Console.WriteLine("-------------------------------------------------------");
        Console.WriteLine("1. Regular expressions. Count domains cv.ua");
        Console.WriteLine("2. Regular expressions. Replace english words with dots");
        Console.WriteLine("3. Regular expressions. Remove duplicate words");
        Console.WriteLine("4. ");
        Console.WriteLine("-------------------------------------------------------");


        try
        {
            Console.Write("Choose a task: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            switch (choice)
            {
                case 1:
                    TasksUsage.Program1();
                    Console.WriteLine("");
                    break;
                case 2:
                    TasksUsage.Program2();
                    Console.WriteLine("");
                    break;
                case 3:
                    TasksUsage.Program3();
                    Console.WriteLine("");
                    break;
                default:
                    Console.WriteLine("Task not found.");
                    break;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }
}
