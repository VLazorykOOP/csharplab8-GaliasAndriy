using System.Text.RegularExpressions;

namespace Lab8CSharp
{
    public class Task1
    {
        public static int ExecuteTask1(string inputFilePath, string outputFilePath)
        {
            // Check if input file exists
            if (!File.Exists(inputFilePath))
            {
                Console.WriteLine("Input file does not exist.");
                return 404;
            }

            // Read lines from input file
            string[] lines = File.ReadAllLines(inputFilePath);

            // Count the occurrences of web addresses with the domain cv.ua
            int count = 0;
            using (StreamWriter writer = new(outputFilePath))
            {
                foreach (string line in lines)
                {
                    // Find all web addresses with the domain cv.ua using regular expression
                    MatchCollection matches = Regex.Matches(line, @"\b(?:https?://)?(?:www\.)?[^.\s]+\.cv\.ua\b", RegexOptions.IgnoreCase);
                    foreach (Match match in matches)
                    {
                        // Write the address to the output file
                        writer.WriteLine(match.Value);
                        count++;
                    }
                }
            }
            
            return count;
        }
    }
}
