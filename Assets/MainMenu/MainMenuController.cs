using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    // These methods will be connected to your UI Buttons in the Inspector

    public void PlayMadDriver()
    {
        SceneManager.LoadScene("MadDriver/Scenes/Prototype 1");
    }

    public void PlayFlyLikeABird()
    {
        SceneManager.LoadScene("FlyLikeABird/Challenge 1/Challenge 1");
    }

    public void PlayImASumoAndABall()
    {
        SceneManager.LoadScene("ImASumoAndABall/Challenge 4/Challenge 4");
    }

    public void QuitGame()
    {      
        #if UNITY_EDITOR
                // Stop play mode in the editor
                UnityEditor.EditorApplication.isPlaying = false;
        #else
                // Quit application in build
                Application.Quit();
        #endif
    }
}
