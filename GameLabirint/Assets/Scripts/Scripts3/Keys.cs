using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Keys : MonoBehaviour
{
    bool key1 = false;
    bool key2 = false;
    bool key3 = false;
    bool key4 = false;
    public Image image1;
    public Image image2;
    public Image image3;
    public Image image4;

    string key;
    void Start()
    {
        image1.enabled = false;
        image2.enabled = false;
        image3.enabled = false;
        image4.enabled = false;
        key = gameObject.name;
    }


    void OnTriggerEnter(Collider other)
    {       
        switch(key)
        {
            case "key1":
                {
                    key1 = true;
                    break;
                }

            case "key2":
                {
                    key2 = true;
                    break;
                }

            case "key3":
                {
                    key3 = true;
                    break;
                }
            case "key4":
                {
                    key4 = true;
                    break;
                }
        }

        gameObject.SetActive(false);
        if (image1.enabled == false)
        {
            image1.enabled = true;
        }
        else if (image2.enabled == false)
        {
            image2.enabled = true;
        }
        else if (image3.enabled == false)
        {
            image3.enabled = true;
        }
        else if (image4.enabled == false)
        {
            image4.enabled = true;
        }
    }
}
