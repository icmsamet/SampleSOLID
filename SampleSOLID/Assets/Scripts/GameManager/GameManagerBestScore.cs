using UnityEngine;

namespace GameManager
{
    public class GameManagerBestScore
    {
        int bestScore;
        public int BestScore(int point)
        {
            bestScore = PlayerPrefs.GetInt("BestScore");
            if (point >= bestScore)
            {
                bestScore = point;
                PlayerPrefs.SetInt("BestScore", bestScore);
            }
            return bestScore;
        }
    }
}
