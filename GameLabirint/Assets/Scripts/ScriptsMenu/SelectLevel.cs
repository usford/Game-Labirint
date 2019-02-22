using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectLevel : MonoBehaviour
{
    public void Level1()
    {
        SceneManager.LoadScene("level1");
    }

    public void Level2()
    {
        SceneManager.LoadScene("level2");
    }

    public void Level3()
    {
        SceneManager.LoadScene("level3");
    }

    public void Level4()
    {
        SceneManager.LoadScene("level4");
    }

    public void Back()
    {
        SceneManager.LoadScene("MainMenu");
    }
}