using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int Score { get; private set; }

    public void AddPoint()
    {
        Score++;
    }

    public void ResetScore()
    {
        Score = 0;
    }
}