using System.Collections.Concurrent;
using System.Text.RegularExpressions;

Console.WriteLine("Enter the directory path:");
string directoryPath = Console.ReadLine();

Console.WriteLine("Enter the minimum word length:");
int minLength = int.Parse(Console.ReadLine());

string[] files = Directory.GetFiles(directoryPath, "*.txt");

ConcurrentDictionary<string, int> wordCounts = new ConcurrentDictionary<string, int>();

Parallel.ForEach(files, file =>
{
    foreach (var line in File.ReadLines(file))
    {
        string[] words = Regex.Split(line, @"\W+");

        foreach (var word in words)
        {
            if (word.Length > minLength)
            {
                wordCounts.AddOrUpdate(word.ToLower(), 1, (key, count) => count + 1);
            }
        }
    }
});


Console.WriteLine("Top 10 most frequently used words:");

var topWords = wordCounts.OrderByDescending(kv => kv.Value)
                         .ThenByDescending(kv => kv.Key.Length)
                         .Take(10);
foreach (var kv in topWords)
{
    Console.WriteLine($"{kv.Key}: {kv.Value}");
}