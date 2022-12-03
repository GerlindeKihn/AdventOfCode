namespace AoC2022.Day03;

public class Day03 : IPuzzle
{
    string[] rucksackInputFile = File.ReadAllLines("Day03/Input");

    public int SolvePart1()
    {
        int sumOfPriorities = 0;

        foreach (string compartment in rucksackInputFile)
        {
            int stringLength = compartment.Length;
            string firstCompartment = compartment.Substring(0, stringLength / 2);
            string secondCompartment = compartment.Substring(stringLength/ 2);

            char compartmentError = firstCompartment.Intersect(secondCompartment).Single();

            sumOfPriorities += Prioritize(compartmentError);
        }
        
        return sumOfPriorities;
    }

    public int SolvePart2()
    {
        int sumOfPriorities = 0;

        foreach (string[] compartment in rucksackInputFile.Chunk(3))
        {
            char compartmentError = compartment[0].Intersect(compartment[1]).Intersect(compartment[2]).Single();

            sumOfPriorities += Prioritize(compartmentError);
        }

        return sumOfPriorities;
    }

    private int Prioritize(char compartmentError)
    {
        if (compartmentError <= 'z' && compartmentError >= 'a')
        {
            return compartmentError - 'a' + 1;
        }
        if (compartmentError <= 'Z' && compartmentError >= 'A')
        {
            return compartmentError - 'A' + 27;
        }
        
        throw new NotSupportedException("Oops, too many drunk elves!");
    }
}
