using System.Text.RegularExpressions;

namespace Lab8CSharp
{
    public class Task2
    {
        public static int ExecuteTask2(string inputFilePath, string outputFilePath)
        {
            // Check if input file exists
            if (!File.Exists(inputFilePath))
            {
                Console.WriteLine("Input file does not exist.");
                return 0;
            }

            string[] lines = File.ReadAllLines(inputFilePath);
            
            string pattern = @"\b[A-Za-z]+\b";

            int count = 0;
            using (StreamWriter writer = new(outputFilePath))
            {
                foreach (string line in lines)
                {
                    string replacedLine = Regex.Replace(line, pattern, m =>
                    {
                        if (Regex.IsMatch(m.Value + " ", @"\d"))
                        {
                            return new string('.', m.Length - 1) + m.Value[m.Length - 1];
                        }
                        else
                        {
                            return new string('.', m.Length);
                        }
                    });

                    writer.WriteLine(replacedLine);

                    count += Regex.Matches(line, pattern).Count;
                }
            }

            return count;
        }
    }
}
