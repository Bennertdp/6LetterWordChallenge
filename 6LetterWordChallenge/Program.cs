using _6LetterWordChallenge.Core.File;
using _6LetterWordChallenge.Core.WordFinder;

if (args.Length == 0)
{
    Console.WriteLine("Please provide the file path as a command-line argument.");
    return;
}

string filePath = args[0];

IFileReader fileReader = new FileReader();
List<string> wordsFromFile = fileReader.Read(filePath);

IWordFinder wordfinder = new WordFinder(wordsFromFile);
wordfinder.FindWordCombinations();