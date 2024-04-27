namespace Lab8CSharp
{
    public class Task4
    {
        public static void WriteNonMultiplesToFile(int[] numbers, int divisor, string fileName)
        {
            using (BinaryWriter writer = new(File.Open(fileName, FileMode.Create)))
            {
                foreach (int number in numbers)
                {
                    if (number % divisor != 0)
                    {
                        writer.Write(number);
                    }
                }
            }
        }

        public static void ReadAndDisplayNumbers(string fileName)
        {
            using (BinaryReader reader = new(File.Open(fileName, FileMode.Open)))
            {
                while (reader.BaseStream.Position < reader.BaseStream.Length)
                {
                    int number = reader.ReadInt32();
                    Console.Write(number + " ");
                }
            }
        }
    }
}
