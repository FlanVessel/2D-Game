using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Button clickButton;
    public TMP_Text scoreText;
    public TMP_Text timerText;

    public GameObject endPanel;
    public TMP_InputField nameInput;

    public ScoreManager scoreManager;
    public TimerManager timer;
    public ProfileManager profileManager;
    public RankingUI rankingUI;

    void Start()
    {
        timer.OnTimeEnd += EndGame;
        endPanel.SetActive(false);
    }

    void Update()
    {
        scoreText.text = "Score: " + scoreManager.Score;
        timerText.text = "Time: " + timer.GetTimeLeft().ToString("F2");
    }

    public void ClickButton()
    {
        if (profileManager.CurrentProfile == null)
        {
            Debug.Log("No hay perfil seleccionado");
            return;
        }

        if(!timer.enabled)
            timer.StartTimer();

        scoreManager.AddPoint();
    }

    void EndGame()
    {
        clickButton.gameObject.SetActive(false);
        endPanel.SetActive(true);

        profileManager.AddScore(scoreManager.Score);
        rankingUI.Show(profileManager.GetProfiles());
    }

    public void CreateProfile()
    {
        string name = nameInput.text == "" ? "Player" : nameInput.text;
        profileManager.CreateProfile(name);
        RestartGame();
    }
    void RestartGame()
    {
        scoreManager.ResetScore();
        clickButton.gameObject.SetActive(true);
        endPanel.SetActive(false);
        timer.StartTimer();
    }

}