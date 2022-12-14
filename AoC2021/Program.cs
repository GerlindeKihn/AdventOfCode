using AoC2021;
using AoC2021.Day01;
using AoC2021.Day02;


//Solve<Day01>("Solve day 1");
Solve<Day02>("Solve day 2");


void Solve<TPuzzle>(string text) where TPuzzle : IPuzzle, new()
{
    IPuzzle puzzle = new TPuzzle();

    Console.WriteLine(text);
    Console.WriteLine(puzzle.SolvePart1());
    Console.WriteLine(puzzle.SolvePart2());
    Console.WriteLine();
}