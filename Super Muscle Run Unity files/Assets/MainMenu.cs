using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    void PauseGame()
    {
        Time.timeScale = 0;
    }

    private void Start()
    {
        PauseGame();
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
    }
}
