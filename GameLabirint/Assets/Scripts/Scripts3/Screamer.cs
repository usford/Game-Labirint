using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screamer : MonoBehaviour
{
    private bool change = false;
    public GameObject scream;
    void Start()
    {
        scream.SetActive(false);
    }

    void Update()
    {
        
    }

    void OnTriggerEnter()
    {
        if (change == false)
        {
            scream.SetActive(true);
            GetComponent<AudioSource>().Play();
            change = true;
        }       
    }
}