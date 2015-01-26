using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace BowlingKata.Tests
{
    [TestFixture]
    public class GameScoreTests
    {
        private Game _Game ;

        [SetUp]
        public void Setup()
        {
            _Game = new Game();
        }

        public void RollMultipleTimes(int numberOfTimes, int pins)
        {
            for (int i = 0; i < numberOfTimes; i++)
            {
                _Game.Roll(pins);
            }
        }

        [Test]
        public void Score_AllRollsAreBlank_Zero()
        {
            _Game.Roll(0);
            RollMultipleTimes(19, 0);
            var score = _Game.Score;

            Assert.AreEqual(0, score);
        }

        [Test]
        public void Score_RollOnePin_One()
        {         
            _Game.Roll(1);

            RollMultipleTimes(19, 0);

            var score = _Game.Score;

            Assert.AreEqual(1, score);
        }

        [Test]
        public void Score_RollOneSpareFirstFrameOnePinNextFrame_Twelve()
        {
            _Game.Roll(6);
            _Game.Roll(4);
            _Game.Roll(1);

            RollMultipleTimes(17, 0);

            var score = _Game.Score;

            Assert.AreEqual(12, score);
        }

        [Test]
        public void Score_RollStrikeFirstFrameOnePinNextTwoRolls_Fourteen()
        {
            _Game.Roll(10);
            _Game.Roll(1);
            _Game.Roll(1);

            RollMultipleTimes(17, 0);

            var score = _Game.Score;

            Assert.AreEqual(14, score);
        }

        [Test]
        public void Score_RollTwoPinInFirstFrame_FirstFrameScoreTwo()
        {
            _Game.Roll(1);
            _Game.Roll(1);

            RollMultipleTimes(18, 0);

            var frameScore = _Game.GetFrameScore(1);
            Assert.AreEqual(2, frameScore);
        }
    }
}
