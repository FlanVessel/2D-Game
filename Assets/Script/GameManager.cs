using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public float gameTime = 10f;

    public TMP_Text scoreText;
    public TMP_Text timerText;

    public Button button;

    private int score = 0;
    private float timeLeft;
    private bool gameRunning = false;

    void Start()
    {
        timeLeft = gameTime;

        scoreText.text = "Score: 0";
        timerText.text = "Time: " + gameTime.ToString("F2");
    }

    void Update()
    {
        if (!gameRunning) return;

        timeLeft -= Time.deltaTime;

        if (timeLeft <= 0)
        {
            timeLeft = 0;
            gameRunning = false;
            button.interactable = false;
        }

        timerText.text = "Time: " + timeLeft.ToString("F2");
    }

    public void AddPoint()
    {
        if (!gameRunning)
            gameRunning = true;

        score++;
        scoreText.text = "Score: " + score;
    }

}