namespace AoC2022.Day04;

public class Day04 : IPuzzle
{
    string[] cleaningSectionInput = File.ReadAllLines("Day04/Input");

    public int SolvePart1()
    {
        // How many assignment pairs does one range fully contain the other?

        int doubleAssignmentPairs = 0;

        foreach (string pair in cleaningSectionInput)
        {
            string[] sectionSplitting = pair.Split(',');

            string[] firstPair = sectionSplitting[0].Split('-');
            string[] secondPair = sectionSplitting[1].Split('-');

            int convertedFirstPairLeft = int.Parse(firstPair[0]);
            int convertedFirstPairRight = int.Parse(firstPair[1]);

            int convertedSecondPairLeft = int.Parse(secondPair[0]);
            int convertedSecondPairRight = int.Parse(secondPair[1]);

            // is first section fully contained in second section or vice versa
            if (convertedFirstPairLeft >= convertedSecondPairLeft && convertedFirstPairRight <= convertedSecondPairRight || 
                convertedFirstPairLeft <= convertedSecondPairLeft && convertedFirstPairRight >= convertedSecondPairRight)
            {
                doubleAssignmentPairs++;
            }
        }

        return doubleAssignmentPairs;
    }

    public int SolvePart2()
    {
        int doubleAssignmentPairs = 0;

        foreach (string pair in cleaningSectionInput)
        {

            string[] sectionSplitting = pair.Split(',');

            string[] firstPair = sectionSplitting[0].Split('-');
            string[] secondPair = sectionSplitting[1].Split('-');

            int convertedFirstPairLeft = Int32.Parse(firstPair[0]);
            int convertedFirstPairRight = Int32.Parse(firstPair[1]);

            int convertedSecondPairLeft = Int32.Parse(secondPair[0]);
            int convertedSecondPairRight = Int32.Parse(secondPair[1]);

            IEnumerable<int> numberRangeFirstPair = Enumerable.Range(convertedFirstPairLeft, convertedFirstPairRight-convertedFirstPairLeft+1);
            IEnumerable<int> numberRangeSecondPair = Enumerable.Range(convertedSecondPairLeft, convertedSecondPairRight-convertedSecondPairLeft+1);

            IEnumerable<int> numbersShared = numberRangeFirstPair.Intersect(numberRangeSecondPair);

            if (numbersShared.Any())
            {
                doubleAssignmentPairs++;
            }
        }

            return doubleAssignmentPairs;
    }
}
