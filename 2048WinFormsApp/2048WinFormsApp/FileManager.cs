
namespace _2048WinFormsApp
{
    public static class FileManager
    {
        public static bool Exists(string fileName)
        {
            return File.Exists(fileName);
        }

        public static List<string> ReadAllLines(string fileName)
        {
            if (!File.Exists(fileName))
            {
                return new List<string>();
            }

            return new List<string>(File.ReadAllLines(fileName));
        }

        public static void WriteAllLines(string fileName, List<string> lines)
        {
            File.WriteAllLines(fileName, lines);
        }
    }
}
