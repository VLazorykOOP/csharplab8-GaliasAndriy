namespace Lab8CSharp
{
    public class Task5
    {
        public static void ExecuteTask5()
        {
            // Step 1: Create folders
            Console.WriteLine("Step 1");
            string folder1Path = $"d:\\temp\\shevchenko";
            string folder2Path = $"d:\\temp\\komar";   
            Directory.CreateDirectory(folder1Path);
            Directory.CreateDirectory(folder2Path);
            WaitForAction();

            // Step 2: Create files in folder1
            Console.WriteLine("Step 2");
            string t1Content = "<Шевченко Степан Іванович, 2001> року народження, місце проживання <м. Суми>";
            string t2Content = "<Комар Сергій Федорович, 2000> року народження, місце проживання <м. Київ>";
            File.WriteAllText(Path.Combine(folder1Path, "t1.txt"), t1Content);
            File.WriteAllText(Path.Combine(folder2Path, "t2.txt"), t2Content);
            WaitForAction();

            // Step 3: Copy content from t1.txt and t2.txt to t3.txt in folder2
            Console.WriteLine("Step 3");
            string t1Path = Path.Combine(folder1Path, "t1.txt");
            string t2Path = Path.Combine(folder2Path, "t2.txt");
            string t3Path = Path.Combine(folder2Path, "t3.txt");
            File.Copy(t1Path, t3Path, true); // Overwrite if t3.txt exists
            File.AppendAllText(t3Path, Environment.NewLine); // Add a new line before appending content from t2.txt
            File.AppendAllText(t3Path, File.ReadAllText(t2Path));
            WaitForAction();

            // Step 4: Display information about created files
            Console.WriteLine("Step 4");
            Console.WriteLine("Information about created files:");
            DisplayFileInfo(t1Path);
            DisplayFileInfo(t2Path);
            DisplayFileInfo(t3Path);
            WaitForAction();

            // Step 5: Move t2.txt to folder2
            Console.WriteLine("Step 5");
            string newT2Path = Path.Combine(folder1Path, "t2.txt");
            File.Move(t2Path, newT2Path);
            WaitForAction();

            // Step 6: Copy t1.txt to folder2
            Console.WriteLine("Step 6");
            string newT1Path = Path.Combine(folder2Path, "t1.txt");
            File.Copy(t1Path, newT1Path);
            WaitForAction();

            // Step 7: Rename folder2 to "ALL" and delete folder1
            Console.WriteLine("Step 7");
            string allFolderPath = $"d:\\temp\\ALL";
            Directory.Move(folder2Path, allFolderPath);
            Directory.Delete(folder1Path);
            WaitForAction();

            // Step 8: Display full information about files in folder ALL
            Console.WriteLine("Step 8");
            Console.WriteLine("Information about files in ALL folder:");
            string[] allFiles = Directory.GetFiles(allFolderPath);
            foreach (string file in allFiles)
            {
                DisplayFileInfo(file);
            }
        }
        
        static void DisplayFileInfo(string filePath)
        {
            FileInfo fileInfo = new(filePath);
            Console.WriteLine($"File Name: {fileInfo.Name}");
            Console.WriteLine($"Full Path: {fileInfo.FullName}");
            Console.WriteLine($"Size: {fileInfo.Length} bytes");
            Console.WriteLine($"Created: {fileInfo.CreationTime}");
            Console.WriteLine($"Last Modified: {fileInfo.LastWriteTime}");
            Console.WriteLine();
        }

        static void WaitForAction()
        {
            Console.WriteLine("Enter 'y' or 'Y' to continue...");
            while (true)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                if (keyInfo.KeyChar == 'y' || keyInfo.KeyChar == 'Y')
                    break;
            }
        }
    }
}