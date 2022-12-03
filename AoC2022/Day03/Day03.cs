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

            if (compartmentError <= 'z' && compartmentError >= 'a')
            {
                sumOfPriorities += compartmentError - 'a' + 1; 
            }
            else if (compartmentError <= 'Z' && compartmentError >= 'A')
            {
                sumOfPriorities += compartmentError - 'A' + 27;
            }
        }
        
        return sumOfPriorities;
    }

    public int SolvePart2()
    {
        throw new NotImplementedException();
    }
}
