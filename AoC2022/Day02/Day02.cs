using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AoC2022.Day02
{
    internal class Day02
    {
        const int ROCK = 1;
        const int PAPER = 2;
        const int SCISSORS = 3;

        int myScore = 0;

        string[] rockPaperScissorsInputFile = File.ReadAllLines("Day02/Input");

        public Day02()
        {
            char opponentRock = 'A';
            char opponentPaper = 'B';
            char opponentScissors = 'C';

            char myRock = 'X';
            char myPaper = 'Y';
            char myScissors = 'Z';

            foreach (string line in rockPaperScissorsInputFile)
            {
                char opponent = line[0];
                char me = line[2];

                int playerOpponent = 0;
                int playerMe = 0;

                if (opponent == opponentRock)
                {
                    playerOpponent = ROCK;
                }
                else if (opponent == opponentPaper)
                {
                    playerOpponent = PAPER;
                }
                else if (opponent == opponentScissors)
                {
                    playerOpponent = SCISSORS;
                }
                else
                {
                    Console.WriteLine("Oops, there must be a mistake!");
                }

                if (me == myRock)
                {
                    playerMe = ROCK;
                }
                else if (me == myPaper)
                {
                    playerMe = PAPER;
                }
                else if (me == myScissors)
                {
                    playerMe = SCISSORS;
                } 
                else
                {
                    Console.WriteLine("Oops, there must be a mistake!");
                }

                myScore += playerMe;

                if (playerOpponent == playerMe)
                {
                    myScore += 3;
                }
                else if (playerMe == ROCK && playerOpponent == SCISSORS)
                {
                    myScore += 6;
                }
                else if (playerMe == PAPER && playerOpponent == ROCK)
                {
                    myScore += 6;
                }
                else if (playerMe == SCISSORS && playerOpponent == PAPER)
                {
                    myScore += 6;
                }
            }
        }

        public int SolvePart1()
        {
            return myScore;
        }

        //public int SolvePart2()
        //{
        //    return 1;
        //}
    }
}
