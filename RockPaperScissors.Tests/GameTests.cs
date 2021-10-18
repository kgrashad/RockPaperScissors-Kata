using Xunit;

namespace RockPaperScissors.Tests
{
    public class GameTest
    {
        [Fact]
        public void RockBeatsScissors()
        {
            var game = new Game();
            var result = game.Play(Choice.Rock, Choice.Scissors);

            Assert.Equal(Result.Player1, result);
        }

        [Fact]
        public void ScissorsLosesToRock()
        {
            var game = new Game();
            var result = game.Play(Choice.Scissors, Choice.Rock);

            Assert.Equal(Result.Player2, result);
        }

        [Fact]
        public void ScissorsBeatsPaper()
        {
            var game = new Game();
            var result = game.Play(Choice.Scissors, Choice.Paper);

            Assert.Equal(Result.Player1, result);
        }

        [Fact]
        public void PaperLosesToScissors()
        {
            var game = new Game();
            var result = game.Play(Choice.Paper, Choice.Scissors);

            Assert.Equal(Result.Player2, result);
        }

        [Fact]
        public void PaperBeatsRock()
        {
            var game = new Game();
            var result = game.Play(Choice.Paper, Choice.Rock);

            Assert.Equal(Result.Player1, result);
        }

        [Fact]
        public void RockLosesToPaper()
        {
            var game = new Game();
            var result = game.Play(Choice.Rock, Choice.Paper);

            Assert.Equal(Result.Player2, result);
        }


        [Fact]
        public void RockDrawsWithARock()
        {
            var game = new Game();
            var result = game.Play(Choice.Rock, Choice.Rock);

            Assert.Equal(Result.Draw, result);
        }


        [Fact]
        public void ScissorsDrawsWithAScissor()
        {
            var game = new Game();
            var result = game.Play(Choice.Scissors, Choice.Scissors);

            Assert.Equal(Result.Draw, result);
        }


        [Fact]
        public void PaperDrawsWithAPaper()
        {
            var game = new Game();
            var result = game.Play(Choice.Paper, Choice.Paper);

            Assert.Equal(Result.Draw, result);
        }
    }
}
