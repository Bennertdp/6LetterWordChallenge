using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6LetterWordChallenge.Core.File
{
    public interface IFileReader
    {
        public List<string> Read(string filaName);
    }
}
