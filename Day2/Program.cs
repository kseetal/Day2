public class Day2
{
    public static void Main()
    {
        var scoreDictPart1 = new Dictionary<string, int>
        {
            { "A X", 4},
            { "A Y", 8},
            { "A Z", 3},
            { "B X", 1},
            { "B Y", 5},
            { "B Z", 9},
            { "C X", 7},
            { "C Y", 2},
            { "C Z", 6}
        };

        var scoreDictPart2 = new Dictionary<string, int>
        {
            { "A X", 3},
            { "A Y", 4},
            { "A Z", 8},
            { "B X", 1},
            { "B Y", 5},
            { "B Z", 9},
            { "C X", 2},
            { "C Y", 6},
            { "C Z", 7}
        };

        string line;
        int score = 0;
        while ((line = Console.ReadLine()) != string.Empty)
        {
            score += scoreDictPart2[line];
        }

        Console.WriteLine(score);
    }
}