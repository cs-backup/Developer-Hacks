using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingKata
{
    public class Game
    {
        private List<int> scoreList = new List<int>();

        public void Roll(int i)
        {
            if (Score >= 10)
            {
                Score = Score + i;
            }
            Score = Score + i;
            scoreList.Add(i);
        }

        public int GetFrameScore(int i)
        {
            return scoreList.Take(i * 2).Sum();
        }

        public int Score { get; set; }
    }
}
