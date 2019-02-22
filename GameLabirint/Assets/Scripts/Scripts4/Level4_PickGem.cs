using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Level4_PickGem : MonoBehaviour
{
    string GemName = "";
    public int Count = 0;
    
    Image ImageRed;
    Image ImageYellow;
    Image ImageGreen;
    Image ImageBlue;
    Image ImagePink;

    void OnTriggerEnter(Collider other)
    {
        GemName = gameObject.name;
        GameObject.Find("Terrain").GetComponent<AudioSource>().Play();
        switch (GemName)
        {
            case "gemRed":
                {
                    ImageRed = GameObject.Find("RedImage").GetComponent<Image>();
                    ImageRed.sprite = Resources.Load<Sprite>("Red");
                    break;
                }
            case "gemYellow":
                {
                    ImageYellow = GameObject.Find("YellowImage").GetComponent<Image>();
                    ImageYellow.sprite = Resources.Load<Sprite>("Yellow");
                    break;
                }
            case "gemGreen":
                {
                    ImageGreen = GameObject.Find("GreenImage").GetComponent<Image>();
                    ImageGreen.sprite = Resources.Load<Sprite>("Green");
                    break;
                }
            case "gemBlue":
                {
                    ImageBlue = GameObject.Find("BlueImage").GetComponent<Image>();
                    ImageBlue.sprite = Resources.Load<Sprite>("Blue");
                    break;
                }
            case "gemPink":
                {
                    ImagePink = GameObject.Find("PinkImage").GetComponent<Image>();
                    ImagePink.sprite = Resources.Load<Sprite>("Pink");
                    break;
                }
        }
        GameObject go = GameObject.Find("Terrain");
        go.tag += "1";
        gameObject.SetActive(false);
        if (go.tag == "Untagged11111")
            SceneManager.LoadScene("EndGame");
    }
}