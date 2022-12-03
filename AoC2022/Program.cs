using AoC2022;
using AoC2022.Day01;
using AoC2022.Day02;
using AoC2022.Day03;

IPuzzle Day01 = new Day01();
Console.WriteLine("Solve day 1:");
Console.WriteLine(Day01.SolvePart1());
Console.WriteLine(Day01.SolvePart2());

IPuzzle Day02 = new Day02();
Console.WriteLine("Solve day 2:");
Console.WriteLine(Day02.SolvePart1());
Console.WriteLine(Day02.SolvePart2());

IPuzzle Day03 = new Day03();
Console.WriteLine("Solve day 3:");
Console.WriteLine(Day03.SolvePart1());
//Console.WriteLine(Day02.SolvePart2());

//Solve<Day01>("Solve day 1");
//Solve<Day02>("Solve day 2");

//void Solve<TPuzzle>(string text) where TPuzzle : IPuzzle, new()
//{
//    IPuzzle puzzle = new TPuzzle();

//    Console.WriteLine(text);
//    Console.WriteLine(puzzle.SolvePart1());
//    Console.WriteLine(puzzle.SolvePart2());
//    Console.WriteLine();
//}