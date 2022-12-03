using AoC2022;
using AoC2022.Day01;
using AoC2022.Day02;
using AoC2022.Day03;

Solve<Day01>("Solve day 1");
Solve<Day02>("Solve day 2");
Solve<Day03>("Solve day 3");

void Solve<TPuzzle>(string text) where TPuzzle : IPuzzle, new()
{
    IPuzzle puzzle = new TPuzzle();

    Console.WriteLine(text);
    Console.WriteLine(puzzle.SolvePart1());
    Console.WriteLine(puzzle.SolvePart2());
    Console.WriteLine();
}