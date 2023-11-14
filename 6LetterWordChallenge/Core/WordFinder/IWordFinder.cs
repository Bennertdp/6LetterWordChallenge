using _6LetterWordChallenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6LetterWordChallenge.Core.WordFinder
{
    public interface IWordFinder
    {
        public List<CompositeWord> FindWordCombinations();
    }
}
