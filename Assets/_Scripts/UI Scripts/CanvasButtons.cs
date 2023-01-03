using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasButtons : MonoBehaviour
{
    public GameObject deathScene;

    // Main Menu Buttons
    public void PlayButton() {
        SceneManager.LoadScene("Level 1");
    }

    public void SettingsButton() {

    }

    public void QuitButton() {
        Application.Quit();
    }


    // In Game Buttons
    public void InGameSettingsButton() {
        
    }

    public void ReturnButton() {
        deathScene.SetActive(false);
		SceneManager.LoadScene("Level 1");
	}

	public void QuitToMenuButton() {
        SceneManager.LoadScene("Main Menu");
    }

    public void ChangeScene(string levelName) {
        SceneManager.LoadScene(levelName);
    }

}
