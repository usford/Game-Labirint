using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OpenLevel : MonoBehaviour
{
    string name;
    public void openLevel()
    {
        name = gameObject.name;
        switch(name)
        {
            case "BtnLevel1":
                {
                    SceneManager.LoadScene("level1");
                    break;
                }
            case "BtnLevel2":
                {
                    SceneManager.LoadScene("level2");
                    break;
                }
            case "BtnLevel3":
                {
                    SceneManager.LoadScene("level3");
                    break;
                }
            case "BtnLevel4":
                {
                    break;
                }
        }
    }
}
