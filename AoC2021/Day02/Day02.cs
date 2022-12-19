using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC2021.Day02
{
    internal class Day02 : IPuzzle
    {
        string[] commands = File.ReadAllLines("Day02/Input");

        public int SolvePart1()
        {
            int horizontalCount = 0;
            int depthCount = 0;

            foreach (var command in commands)
            {
                string[] split = command.Split(" ");
                int splitParse = int.Parse(split[1]);

                if (command.StartsWith("forward"))
                {
                    horizontalCount += splitParse;
                }

                if (command.StartsWith("down"))
                {
                    depthCount += splitParse;
                }
                if (command.StartsWith("up"))
                {
                    depthCount -= splitParse;
                }
            }

            return horizontalCount * depthCount;
        }

        public int SolvePart2()
        {
            int horizontalCount = 0;
            int depthCount = 0;
            int aim = 0;

            foreach (var command in commands)
            {
                string[] split = command.Split(" ");
                int splitParse = int.Parse(split[1]);

                if (command.StartsWith("forward"))
                {
                    horizontalCount += splitParse;
                    depthCount += aim * splitParse;
                }

                if (command.StartsWith("down"))
                {
                    aim += splitParse;
                }
                if (command.StartsWith("up"))
                {
                    aim -= splitParse;
                }
            }

            return horizontalCount * depthCount;
        }
    }
}