namespace Lab8CSharp
{
    public class Task3
    {
        public static void RemoveDuplicates(string inputFilePath, string outputFilePath)
        {
            if (!File.Exists(inputFilePath))
            {
                Console.WriteLine("Input file does not exist.");
                return;
            }

            string[] lines = File.ReadAllLines(inputFilePath);

            HashSet<string> uniqueWords = new();
            List<string> modifiedLines = new();

            // Process each line
            foreach (string line in lines)
            {
                string[] words = line.Split(
                    new char[] { ' ', ',', '.', '!', '?', ';', ':', '-', '\n', '\r' }, 
                    StringSplitOptions.RemoveEmptyEntries
                );

                List<string> modifiedWords = new();

                foreach (string word in words)
                {
                    // Check if the lowercase version of the word is already in the uniqueWords set
                    if (!uniqueWords.Contains(word.ToLower()))
                    {
                        // If not, add the lowercase version to the set
                        uniqueWords.Add(word.ToLower());
                        // Add the original version of the word to the modifiedWords list
                        modifiedWords.Add(word);
                    }
                }

                // Join the modified words back into a line and add it to the modifiedLines list
                modifiedLines.Add(string.Join(" ", modifiedWords));
            }

            File.WriteAllLines(outputFilePath, modifiedLines);
        }
    }
}
