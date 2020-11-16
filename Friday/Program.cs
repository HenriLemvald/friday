using System;
using System.IO;

namespace Friday
{
    class Program
    {
        static void Main(string[] args)
        {
            files();
            directory();
        }

        public static void files()
        {
            string filepath = @"C:\Users\opilane\Friday\directories.txt";


            string directoryPath = @"C:\Users\opilane\Samples";


            string[] files = Directory.GetFiles(directoryPath, "*.*", SearchOption.AllDirectories);

            File.WriteAllLines(filepath, files);
        }

        public static void directory()
        {
            string root = @"C:\Users\opilane\Samples";


            string folders = @"C:\Users\opilane\Friday\files.txt";


            string[] allDirectories = Directory.GetDirectories(root);


            File.WriteAllLines(folders, allDirectories);

            string[] includeNestedDirectories = Directory.GetDirectories(root, "*.*", SearchOption.AllDirectories);


            File.WriteAllLines(folders, includeNestedDirectories);
        }

    }
}
