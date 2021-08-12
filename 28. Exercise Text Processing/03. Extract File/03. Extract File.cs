using System;

namespace _03._Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullPath = Console.ReadLine();
            int lastIndexOfLeftPipe = fullPath.LastIndexOf('\\');

            string fileNameWithExtension = fullPath
                .Substring(lastIndexOfLeftPipe + 1, fullPath.Length - 1 - lastIndexOfLeftPipe);

            int extensionIndex = fileNameWithExtension.LastIndexOf('.');

            string extension = fileNameWithExtension.Substring(extensionIndex + 1, fileNameWithExtension.Length - 1 - extensionIndex);

            string name = fileNameWithExtension.Substring(0, extensionIndex);

            Console.WriteLine($"File name: {name}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}
