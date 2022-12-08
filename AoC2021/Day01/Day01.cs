using System.Security.Cryptography.X509Certificates;

namespace AoC2021.Day01;

internal class Day01 : IPuzzle
{
    string[] sonarInput = File.ReadAllLines("Day01/Input");

    public Day01()
    {
        
    }

    public int SolvePart1()
    {
        int largerMeasurementAmount = 0;
        int previousNumber = 0;

        foreach (string number in sonarInput)
        {
            int numberMeasurement = Convert.ToInt32(number);

            if (numberMeasurement > previousNumber)
            {
                largerMeasurementAmount++;
            }
            previousNumber = numberMeasurement;
        }
        return largerMeasurementAmount - 1; 
    }

    public int SolvePart2()
    {
        int largerMeasurementAmount = 0;
        int previousNumberOne = 0;
        int previousNumberTwo = 0;
        int previousPackageOfThree = 0;

        foreach (string number in sonarInput)
        {
            int numberMeasurement = Convert.ToInt32(number);

            int packageOfNumbers = numberMeasurement + previousNumberOne + previousNumberTwo;

            if (packageOfNumbers > previousPackageOfThree) 
            {
                largerMeasurementAmount++;
            }
            previousPackageOfThree= packageOfNumbers;
            previousNumberTwo = previousNumberOne;
            previousNumberOne = numberMeasurement; 
        }
        return largerMeasurementAmount - 3;
    }
}