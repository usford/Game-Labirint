using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wrongPlatform : MonoBehaviour
{
    string thisName;
    void Start()
    {
        thisName = gameObject.name;
        if (thisName == "Cube33")
        { 

        }
    }


    void Update()
    {
    }

    void OnTriggerEnter(Collider other)
    {       
        Vector3 teleport = new Vector3(3.081644F, 0.01000029F, -32.82029F);
        other.gameObject.transform.position = teleport;
        GameObject.Find("Cube21").GetComponent<MeshRenderer>().material.color = Color.white;
        GameObject.Find("Cube24").GetComponent<MeshRenderer>().material.color = Color.white;
        GameObject.Find("Cube25").GetComponent<MeshRenderer>().material.color = Color.white;
        GameObject.Find("Cube27").GetComponent<MeshRenderer>().material.color = Color.white;
        GameObject.Find("Cube29").GetComponent<MeshRenderer>().material.color = Color.white;
        GameObject.Find("Cube30").GetComponent<MeshRenderer>().material.color = Color.white;
    }
}