using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel2 : MonoBehaviour
{
    void OnTriggerEnter()
    {
        SceneManager.LoadScene("level2");
    }
}