namespace AoC2022.Day01;

internal class Day01 : IPuzzle
{
    string[] caloriesInput = File.ReadAllLines("Day01/Input");
    List<int> caloriesPerElf = new List<int>();

    public Day01()
    {
        int currentElfCalories = 0;

        foreach (string line in caloriesInput)
        {
            if (line != string.Empty)
            {
                int currentCalories = Convert.ToInt32(line);
                currentElfCalories = currentElfCalories + currentCalories;
            }
            else
            {
                caloriesPerElf.Add(currentElfCalories);
                currentElfCalories = 0;
            }
        }
    }

    public int SolvePart1()
    {
        return caloriesPerElf.Max();
    }
    
    public int SolvePart2()
    {
        int totalCaloriesOfTopThreeElves = caloriesPerElf.OrderDescending().Take(3).Sum();
        return totalCaloriesOfTopThreeElves;
    }

    
}
