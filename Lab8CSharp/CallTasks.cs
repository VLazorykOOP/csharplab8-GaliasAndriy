namespace Lab8CSharp
{
    public class TasksUsage
    {
        public static void Program1()
        {
            string inputFilePath = "./Task1/input.txt";
            string outputFilePath = "./Task1/output.txt";

            int count = Task1.ExecuteTask1(inputFilePath, outputFilePath);

            Console.WriteLine($"Total website addresses with domain cv.ua found: {count}");
        }

        public static void Program2()
        {
            string inputFilePath = "./Task2/input.txt";
            string outputFilePath = "./Task2/output.txt";

            int count = Task2.ExecuteTask2(inputFilePath, outputFilePath);

            Console.WriteLine($"Total English words replaced: {count}");
        }
    }
}
