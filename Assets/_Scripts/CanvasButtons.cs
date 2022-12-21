using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasButtons : MonoBehaviour
{

    // Main Menu Buttons
    public void PlayButton() {
        ChangeScene("Level 1");
    }

    public void SettingsButton() {

    }

    public void QuitButton() {
        Application.Quit();
    }


    // In Game Buttons
    public void InGameSettingsButton() {
        gameObject.SetActive(false);
    }

    public void ReturnButton() {
        gameObject.SetActive(true);
    }

    public void QuitToMenuButton() {
        ChangeScene("Main Menu");
    }

    public void ChangeScene(string levelName) {
        SceneManager.LoadScene(levelName);
    }

}
