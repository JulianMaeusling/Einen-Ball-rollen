using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
    // Wenn ein neues Spiel erstellt wird
    public void NewGame()
    {
        // Lese den Key aus
        if (PlayerPrefs.HasKey("Points"))
            // Setze die Punkte auf 0
            PlayerPrefs.SetInt("Points", 0);
        // Lese den Key aus
        if (PlayerPrefs.HasKey("CheckPoints"))
            // Setze die CheckPoints auf 0
            PlayerPrefs.SetInt("CheckPoints", 0);
        // Lade Level 1
        SceneManager.LoadScene("lvl1");
    }
    // Wenn das Spiel geladen wird
    public void LoadGame()
    {
        // Lese den Key aus
        if (PlayerPrefs.HasKey("Points"))
        {
            // Wenn CheckPoints auf 0 steht
            if (PlayerPrefs.GetInt("CheckPoints") == 0)
                // Lade Level 1
                SceneManager.LoadScene("lvl1");

            // Wenn CheckPoints auf 1 steht
            if (PlayerPrefs.GetInt("CheckPoints") == 1)
                // Lade Level 2
                SceneManager.LoadScene("lvl2");

            // Wenn CheckPoints auf 2 steht
            if (PlayerPrefs.GetInt("CheckPoints") == 2)
                // Lade Level 3
                SceneManager.LoadScene("lvl3");
        }
    }
}