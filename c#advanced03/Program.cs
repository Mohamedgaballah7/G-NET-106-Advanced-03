namespace c_advanced03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercise one
            /*
            // 1
            List<int> grades = new List<int> { 85, 92, 78, 95, 88, 70, 100, 65 };

            // 2
            Console.WriteLine("Grades:");
            Console.WriteLine(string.Join(", ", grades));

            Console.WriteLine($"Count: {grades.Count}");
            Console.WriteLine($"First Grade: {grades.First()}");
            Console.WriteLine($"Last Grade: {grades.Last()}");

            // 3
            grades.Sort();

            Console.WriteLine("\nSorted Grades:");
            Console.WriteLine(string.Join(", ", grades));

            // 4
            int firstAbove90 = grades.First(g => g > 90);
            Console.WriteLine($"\nFirst grade above 90: {firstAbove90}");

            // 5
            List<int> failingGrades = grades.Where(g => g < 75).ToList();

            Console.WriteLine("\nFailing Grades:");
            Console.WriteLine(string.Join(", ", failingGrades));

            // 6
            grades.RemoveAll(g => g < 75);

            Console.WriteLine("\nGrades after removing failing grades:");
            Console.WriteLine(string.Join(", ", grades));

            // 7
            bool has100 = grades.Any(g => g == 100);
            Console.WriteLine($"\nAny grade equals 100? {has100}");

            // 8
            List<string> gradeStrings = grades
                .Select(g => $"Grade: {g}")
                .ToList();

            Console.WriteLine("\nGrade Strings:");
            foreach (string grade in gradeStrings)
            {
                Console.WriteLine(grade);
            } 
            */
            #endregion

            #region Exercise two

            // 1
            SortedDictionary<int, string> leaderboard = new SortedDictionary<int, string>
        {
            { 500, "Ahmed" },
            { 200, "Sara" },
            { 800, "Ali" },
            { 350, "Mona" }
        };

            // 2
            Console.WriteLine("Leaderboard:");

            foreach (var player in leaderboard)
            {
                Console.WriteLine($"Score: {player.Key}, Player: {player.Value}");
            }

            // 3
            int firstKey = leaderboard.Keys.First();
            string firstValue = leaderboard.Values.First();

            Console.WriteLine($"\nFirst Key: {firstKey}");
            Console.WriteLine($"First Value: {firstValue}");

            // 4
            bool exists = leaderboard.ContainsKey(500);

            Console.WriteLine($"\nDoes score 500 exist? {exists}");

            // 5
            if (leaderboard.TryGetValue(999, out string playerName))
            {
                Console.WriteLine($"Player with score 999: {playerName}");
            }
            else
            {
                Console.WriteLine("No player found with score 999.");
            }

            // 6
            leaderboard.Remove(200);

            Console.WriteLine("\nLeaderboard after removing score 200:");

            foreach (var player in leaderboard)
            {
                Console.WriteLine($"Score: {player.Key}, Player: {player.Value}");
            }

            #endregion
        }
    }
}
