using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level4_PickGem : MonoBehaviour
{
    //GameObject Gem;
    string GemName = "";
    int Count = 0;
    
    Image ImageRed;
    Image ImageYellow;
    Image ImageGreen;
    Image ImageBlue;
    Image ImagePink;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        gameObject.SetActive(false);
        GemName = gameObject.name;
        switch (GemName)
        {
            case "gemRed":
                {
                    ImageRed = GameObject.Find("RedImage").GetComponent<Image>();
                    ImageRed.sprite = Resources.Load<Sprite>("Red");
                    Count++;
                    break;
                }
            case "gemYellow":
                {
                    ImageYellow = GameObject.Find("YellowImage").GetComponent<Image>();
                    ImageYellow.sprite = Resources.Load<Sprite>("Yellow");
                    Count++;
                    break;
                }
            case "gemGreen":
                {
                    ImageGreen = GameObject.Find("GreenImage").GetComponent<Image>();
                    ImageGreen.sprite = Resources.Load<Sprite>("Green");
                    Count++;
                    break;
                }
            case "gemBlue":
                {
                    ImageBlue = GameObject.Find("BlueImage").GetComponent<Image>();
                    ImageBlue.sprite = Resources.Load<Sprite>("Blue");
                    Count++;
                    break;
                }
            case "gemPink":
                {
                    ImagePink = GameObject.Find("PinkImage").GetComponent<Image>();
                    ImagePink.sprite = Resources.Load<Sprite>("Pink");
                    Count++;
                    break;
                }
        }
    }
}