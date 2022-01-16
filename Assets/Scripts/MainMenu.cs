using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Scenes/lvl_1");
    }

    public void QuiGame()
    {
        Application.Quit();
        Debug.Log("quit");
    }
}
