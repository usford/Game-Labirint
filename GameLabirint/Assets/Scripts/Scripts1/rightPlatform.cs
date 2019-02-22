using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rightPlatform : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {
        
    }

    void OnTriggerEnter()
    {
        GetComponent<MeshRenderer>().material.color = Color.blue;
    }
}