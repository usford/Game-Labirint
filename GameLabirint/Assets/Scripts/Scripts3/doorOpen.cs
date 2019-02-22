using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorOpen : MonoBehaviour
{
    public GameObject door;
    bool change = false;
    bool key1;
    bool key2;
    bool key3;
    bool key4;
    void Start()
    {
    }

    void Update()
    {
        key1 = GameObject.Find("key5").GetComponent<Keys>().key1;
        key2 = GameObject.Find("key5").GetComponent<Keys>().key2;
        key3 = GameObject.Find("key5").GetComponent<Keys>().key3;
        key4 = GameObject.Find("key5").GetComponent<Keys>().key4;
        if (change == false)
        {
            if (key1 == true & key2 == true & key3 == true & key4 == true)
            {
                door.GetComponent<Animation>().Play("open");
                change = true;
            }
        }
    }

}