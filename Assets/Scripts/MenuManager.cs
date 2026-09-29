using UnityEngine;

public class MenuManager : MonoBehaviour
{
    [Header("UI Panels")]
    public GameObject mainMenuPanel;
    public GameObject savesPanel;

    void Start()
    {
        if (mainMenuPanel != null) mainMenuPanel.SetActive(true);
        if (savesPanel != null) savesPanel.SetActive(false);
    }

    public void OpenSavesPanel()
    {
        // This message will appear in the Console if the button works
        Debug.Log("The Start button was clicked and the script is running!");

        if (mainMenuPanel != null)
        {
            mainMenuPanel.SetActive(false);
            Debug.Log("Main Menu deactivated.");
        }
        else
        {
            Debug.LogWarning("Main Menu Panel is not assigned in the Inspector!");
        }

        if (savesPanel != null)
        {
            savesPanel.SetActive(true);
            Debug.Log("Saves Panel activated.");
        }
        else
        {
            Debug.LogWarning("Saves Panel is not assigned in the Inspector!");
        }
    }
}