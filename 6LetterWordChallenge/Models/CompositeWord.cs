using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _6LetterWordChallenge.Models
{
    public class CompositeWord
    {
        public List<string> Parts { get; set; }
        public string Word { get; set; }

        public CompositeWord(List<string> parts) {
            Word = string.Join("", parts);
            Parts = parts;
        }

        public void Print()
        {
            Console.WriteLine($"{string.Join(" + ", Parts)}={Word}");
        }
    }
}
