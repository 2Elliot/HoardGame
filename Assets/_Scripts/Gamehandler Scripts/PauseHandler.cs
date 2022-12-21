using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseHandler : MonoBehaviour
{

    public GameObject pauseScreen;
    private bool isActive;

    public void pause() {
        if (isActive) {
            isActive = false;
            pauseScreen.SetActive(true);
            Time.timeScale = 0f;
        } else {
            isActive = true;
            pauseScreen.SetActive(false);
            Time.timeScale = 1f;
        }
    }
}
