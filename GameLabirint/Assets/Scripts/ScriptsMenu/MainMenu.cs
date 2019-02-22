using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void NewGame()
    {
        SceneManager.LoadScene("level1");
    }

    public void SelectLevel()
    {
        SceneManager.LoadScene("SelectLevel");
    }

    public void Exit()
    {
        Application.Quit();
    }
}