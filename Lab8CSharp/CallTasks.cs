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

        public static void Program3()
        {
            string inputFilePath = "./Task3/input.txt";
            string outputFilePath = "./Task3/output.txt";

            Task3.RemoveDuplicates(inputFilePath, outputFilePath);

            Console.WriteLine("Duplicate words removed.");
        }

        public static void Program4()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int divisor = 3;

            // Write numbers to a binary file
            Task4.WriteNonMultiplesToFile(numbers, divisor, "./Task4/output.bin");
            // Read numbers from the binary file and display them
            Task4.ReadAndDisplayNumbers("./Task4/output.bin");
        }

        public static void Program5() {
            Task5.ExecuteTask5();
        }
    }
}
