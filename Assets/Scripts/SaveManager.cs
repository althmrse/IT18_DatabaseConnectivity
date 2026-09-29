using UnityEngine;
using UnityEngine.SceneManagement; // Required for loading new scenes

public class SaveManager : MonoBehaviour
{
    // This function will be called by your 3 slot buttons.
    // It takes an integer (number) so it knows which slot was clicked.
    public void SelectSaveSlot(int slotNumber)
    {
        // We create a unique name for the save data based on the slot number (e.g., "SaveData_1")
        string saveKey = "SaveData_" + slotNumber;

        // Check if data already exists for this slot
        if (PlayerPrefs.HasKey(saveKey))
        {
            Debug.Log("Found existing save in Slot " + slotNumber + ". Continuing game...");

            // TODO: Load your game scene here. 
            // Example: SceneManager.LoadScene("MyGameScene");
        }
        else
        {
            Debug.Log("Slot " + slotNumber + " is empty. Starting a NEW game...");

            // Mark this slot as used by saving a simple value (1) to it
            PlayerPrefs.SetInt(saveKey, 1);
            PlayerPrefs.Save();

            // TODO: Load your game scene here.
            // Example: SceneManager.LoadScene("MyGameScene");
        }
    }

    // A handy button for you to use while testing to reset everything
    public void DeleteAllSaves()
    {
        PlayerPrefs.DeleteAll();
        Debug.Log("All saves deleted!");
    }
}