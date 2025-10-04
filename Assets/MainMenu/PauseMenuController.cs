using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuController : MonoBehaviour
{
    public GameObject pauseMenuUI; // Assign the pause menu panel in the Inspector
    private bool isPaused = false;

    void Update()
    {
        // Toggle pause with Escape key
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);   // Hide pause menu
        Time.timeScale = 1f;            // Resume game time
        isPaused = false;
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);    // Show pause menu
        Time.timeScale = 0f;            // Freeze game time
        isPaused = true;
    }

    public void Restart()
    {
        Time.timeScale = 1f;  // Reset time before reload
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void BackToMainMenu()
    {
        Time.timeScale = 1f;  // Reset time before switching scenes
        SceneManager.LoadScene("MainMenu");  // Replace with your main menu scene name
    }
}
