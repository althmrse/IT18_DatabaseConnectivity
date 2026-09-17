using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [Header("UI Panels")]
    public GameObject mainMenuPanel;
    public GameObject gamePanel;
    public GameObject gameOverPanel;
    public GameObject leaderboardPanel;

    [Header("UI Elements")]
    public TMP_InputField nameInputField;
    public TMP_Text scoreDisplay;

    [Header("Game Dynamics")]
    public float initialGameSpeed = 8f;
    public float speedIncreaseRate = 0.2f; // How much speed to add every second
    public float currentWorldSpeed;

    private float scoreTimer = 0f;
    private int currentScore = 0;
    public bool isGameActive = false;

    private void Start()
    {
        ShowMainMenu();
    }

    private void Update()
    {
        if (isGameActive)
        {
            // Gradually increase the world speed
            currentWorldSpeed += speedIncreaseRate * Time.deltaTime;

            // Score increases based on how fast you are running
            scoreTimer += Time.deltaTime * currentWorldSpeed;
            currentScore = Mathf.FloorToInt(scoreTimer / 10f);

            if (scoreDisplay != null)
            {
                scoreDisplay.text = "Score: " + currentScore.ToString();
            }
        }
    }

    public void ShowMainMenu()
    {
        mainMenuPanel.SetActive(true);
        gamePanel.SetActive(false);
        gameOverPanel.SetActive(false);
        leaderboardPanel.SetActive(false);
    }

    public void StartGame()
    {
        currentScore = 0;
        scoreTimer = 0f;
        currentWorldSpeed = initialGameSpeed;
        isGameActive = true;

        mainMenuPanel.SetActive(false);
        gamePanel.SetActive(true);
    }

    public void GameOver()
    {
        isGameActive = false;
        gamePanel.SetActive(false);
        gameOverPanel.SetActive(true);
        if (nameInputField != null) nameInputField.text = "";
    }

    public void OpenLeaderboard()
    {
        mainMenuPanel.SetActive(false);
        gameOverPanel.SetActive(false);
        leaderboardPanel.SetActive(true);

        DatabaseManager dbManager = FindAnyObjectByType<DatabaseManager>();
        if (dbManager != null) dbManager.GetScores();
    }

    public int GetFinalScore()
    {
        return currentScore;
    }
    public void QuitGame()
    {
        Debug.Log("Game is closing!");

        // Tells the built game to close
        Application.Quit();

#if UNITY_EDITOR
        // Tells the Unity Editor to exit Play Mode
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}