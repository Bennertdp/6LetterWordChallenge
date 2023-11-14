using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6LetterWordChallenge.Models
{
    public static class Constants
    {
        public static int WordLength = 6;
        public static string BasePath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", ".." , "Files"));
    }
}
