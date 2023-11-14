using _6LetterWordChallenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _6LetterWordChallenge.Core.File
{
    public class FileReader : IFileReader
    {
        public List<string> Read(string filaName)
        {
            var filePath = Path.Combine(Constants.BasePath, filaName);
            if (System.IO.File.Exists(filePath))
            {
                return System.IO.File.ReadAllLines(filePath).ToList();
            }
            else
            {
                Console.WriteLine($"File not found {filePath}");
                return new List<string>();
            }
        }
    }
}
