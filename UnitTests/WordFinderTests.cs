using _6LetterWordChallenge.Core.WordFinder;

namespace UnitTests
{
    public class WordFinderTests
    {
        [Fact]
        public void WordFinder_FindWordCombinations_OneWord_Should_Succeed()
        {
            var inputs = new List<string>()
            {
                "testen",
                "tes",
                "ten",
                "t",
                "e",
                "sten",
            };

            WordFinder wordFinder = new WordFinder(inputs);
            var result = wordFinder.FindWordCombinations();

            Assert.Equal(2, result.Count);

            Assert.Contains(result, fw => fw.Word == "testen" && fw.Parts.Count == 2 && fw.Parts.Contains("tes") && fw.Parts.Contains("ten"));
            Assert.Contains(result, fw => fw.Word == "testen" && fw.Parts.Count == 3 && fw.Parts.Contains("t") && fw.Parts.Contains("e") && fw.Parts.Contains("sten"));
        }

        [Fact]
        public void WordFinder_FindWordCombinations_MultipleWords_Should_Succeed()
        {
            var inputs = new List<string>()
            {
                "testen",
                "tester",
                "tes",
                "ten",
                "t",
                "e",
                "sten",
                "ter"
            };

            WordFinder wordFinder = new WordFinder(inputs);
            var result = wordFinder.FindWordCombinations();

            Assert.Equal(3, result.Count);

            Assert.Contains(result, fw => fw.Word == "testen" && fw.Parts.Count == 2 && fw.Parts.Contains("tes") && fw.Parts.Contains("ten"));
            Assert.Contains(result, fw => fw.Word == "testen" && fw.Parts.Count == 3 && fw.Parts.Contains("t") && fw.Parts.Contains("e") && fw.Parts.Contains("sten"));
            Assert.Contains(result, fw => fw.Word == "tester" && fw.Parts.Count == 2 && fw.Parts.Contains("tes") && fw.Parts.Contains("ter"));
        }

        [Fact]
        public void WordFinder_NoWordCombination_Should_ReturnEmptyList()
        {
            var inputs = new List<string>()
            {
                "abc",
                "def",
                "ghi"
            };

            WordFinder wordFinder = new WordFinder(inputs);
            var result = wordFinder.FindWordCombinations();

            Assert.Empty(result);
        }

        [Fact]
        public void WordFinder_EmptyInput_Should_ReturnEmptyList()
        {
            var inputs = new List<string>();

            WordFinder wordFinder = new WordFinder(inputs);
            var result = wordFinder.FindWordCombinations();

            Assert.Empty(result);
        }
    }
}