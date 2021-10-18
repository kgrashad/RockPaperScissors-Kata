using System;

namespace RockPaperScissors
{
    public class Game
    {
        public Result Play(Choice player1, Choice player2)
        {
            if (player1 == player2)
            {
                return Result.Draw;
            }

            switch (player1, player2)
            {
                case (Choice.Rock, Choice.Scissors):
                case (Choice.Scissors, Choice.Paper):
                case (Choice.Paper, Choice.Rock):
                    return Result.Player1;
                default:
                    return Result.Player2;
            }
        }
    }
}
