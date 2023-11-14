using _6LetterWordChallenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _6LetterWordChallenge.Core.WordFinder
{
    public class WordFinder : IWordFinder
    {
        private readonly List<string> Inputs;

        public WordFinder(List<string> inputs)
        {
            Inputs = inputs;
        }

        public List<CompositeWord> FindWordCombinations()
        {
            List<CompositeWord> compositeWords = new List<CompositeWord>();
            var wordList = Inputs.Where(x => x.Length == Constants.WordLength).ToList();
            var partList = Inputs.Where(x => x.Length < Constants.WordLength).ToList();

            foreach (var word in wordList)
            {
                GenerateWordCombinationsWithWordParts(word, new List<string>(), new List<string>(partList), compositeWords, new HashSet<string>());
            }

            return compositeWords;
        }

        private void GenerateWordCombinationsWithWordParts(string targetWord, List<string> currentWords,
            List<string> remainingWords, List<CompositeWord> compositeWords, HashSet<string> usedParts)
        {
            if (targetWord.Length == 0)
            {
                var compositeWord = new CompositeWord(currentWords);
                compositeWords.Add(compositeWord);
                compositeWord.Print();
                return;
            }

            foreach (var word in remainingWords.ToList())
            {
                if (targetWord.StartsWith(word) && usedParts.Add(word))
                {
                    List<string> updatedCurrentWords = new List<string>(currentWords) { word };
                    List<string> updatedRemainingWords = new List<string>(remainingWords);
                    updatedRemainingWords.Remove(word);
                    GenerateWordCombinationsWithWordParts(targetWord.Substring(word.Length), updatedCurrentWords, updatedRemainingWords, compositeWords, new HashSet<string>(usedParts));
                }
            }
        }
    }
}