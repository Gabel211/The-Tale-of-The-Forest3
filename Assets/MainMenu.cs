using UnityEngine;
using UnityEngine.SceneManagement; // dacă vrei să încarci scene

// Clasa trebuie să fie publică
public class MainMenu : MonoBehaviour
{
    // Funcția StartGame trebuie să fie în interiorul clasei MainMenu
    public void StartGame()
    {
        Debug.Log("Starting Game...");
        SceneManager.LoadScene(1); // Înlocuiește cu numele scenei tale
    }

    // Funcția QuitGame trebuie să fie în interiorul aceleași clase
    public void QuitGame()
    {
        Debug.Log("Game Closed");
        Application.Quit();
    }
}
