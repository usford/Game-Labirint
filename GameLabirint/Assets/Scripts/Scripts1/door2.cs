using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door2 : MonoBehaviour
{
    private bool change = false;
    GameObject theDoor;
    void Start()
    {
        theDoor = GameObject.Find("door2");
    }

    void OnTriggerEnter()
    {
        theDoor.GetComponent<Animation>().Play("open");       
    }

    void OnTriggerExit()
    {

        theDoor.GetComponent<Animation>().Play("close");
    }
}
