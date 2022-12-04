namespace AoC2022.Day02;

internal class Day02 : IPuzzle
{
    const int ROCK = 1;
    const int PAPER = 2;
    const int SCISSORS = 3;

    string[] rockPaperScissorsInputFile = File.ReadAllLines("Day02/Input");
    
    public int Solve(Func<char, int, int> getPlayerMe)
    {
        int myScore = 0;

        char opponentRock = 'A';
        char opponentPaper = 'B';
        char opponentScissors = 'C';

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

            playerMe = getPlayerMe(me, playerOpponent);

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

        return myScore;
    }

    public int SolvePart1()
    {
        int getPlayerMe (char me, int playerOpponent)
        {
            char myRock = 'X';
            char myPaper = 'Y';
            char myScissors = 'Z';

            if (me == myRock)
            {
                return ROCK;
            }
            else if (me == myPaper)
            {
                return PAPER;
            }
            else if (me == myScissors)
            {
                return SCISSORS;
            }
            else
            {
                throw new NotSupportedException("Oops, there must be a mistake!");
            }
        }

        return Solve(getPlayerMe);
    }

    public int SolvePart2()
    {
        int getPlayerMe(char me, int playerOpponent)
        {
            char myLoss = 'X';
            char myDraw = 'Y';
            char myWin = 'Z';

            if (me == myDraw)
            {
                return playerOpponent;
            }
            if (me == myLoss)
            {
                if (playerOpponent == ROCK)
                {
                    return SCISSORS;
                }
                if (playerOpponent == PAPER)
                {
                    return ROCK;
                }
                if (playerOpponent == SCISSORS)
                {
                    return PAPER;
                }
            }
            if (me == myWin)
            {
                if (playerOpponent == ROCK)
                {
                    return PAPER;
                }
                if (playerOpponent == PAPER)
                {
                    return SCISSORS;
                }
                if (playerOpponent == SCISSORS)
                {
                    return ROCK;
                }
            }
            
            throw new NotSupportedException("Oops, there must be a mistake!");
        }

        return Solve(getPlayerMe);
    }
}