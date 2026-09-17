using UnityEngine;
using UnityEngine.Networking;
using System.Collections;
using TMPro;

public class DatabaseManager : MonoBehaviour
{
    [Header("API Endpoints")]
    // Replace these with your actual Database Web API URLs
    public string submitScoreURL = "https://your-api.com/submit_score.php";
    public string getScoresURL = "https://your-api.com/get_scores.php";

    [Header("References")]
    public TMP_Text leaderboardText;
    private GameManager gameManager;

    private void Start()
    {
        gameManager = GetComponent<GameManager>();
    }

    // Called by the Submit Button on the Game Over screen
    public void SubmitScore()
    {
        string playerName = gameManager.nameInputField.text;
        int score = gameManager.GetFinalScore();

        if (string.IsNullOrEmpty(playerName)) return;

        StartCoroutine(PostScore(playerName, score));
    }

    private IEnumerator PostScore(string name, int score)
    {
        WWWForm form = new WWWForm();
        form.AddField("name", name);
        form.AddField("score", score);

        using (UnityWebRequest www = UnityWebRequest.Post(submitScoreURL, form))
        {
            yield return www.SendWebRequest();

            if (www.result != UnityWebRequest.Result.Success)
            {
                Debug.LogError("Database Error: " + www.error);
            }
            else
            {
                // Score submitted successfully, open leaderboard
                gameManager.OpenLeaderboard();
            }
        }
    }

    public void GetScores()
    {
        StartCoroutine(FetchScores());
    }

    private IEnumerator FetchScores()
    {
        leaderboardText.text = "Loading...";

        using (UnityWebRequest www = UnityWebRequest.Get(getScoresURL))
        {
            yield return www.SendWebRequest();

            if (www.result != UnityWebRequest.Result.Success)
            {
                leaderboardText.text = "Failed to load scores.";
            }
            else
            {
                // Assuming your API returns a formatted string: "1. Alice - 500\n2. Bob - 300"
                // If returning JSON, use JsonUtility to parse it here.
                leaderboardText.text = www.downloadHandler.text;
            }
        }
    }
}