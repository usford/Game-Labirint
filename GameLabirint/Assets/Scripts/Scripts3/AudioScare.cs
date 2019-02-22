using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScare : MonoBehaviour
{
    public AudioClip myClip;
    void Start()
    {
        AudioSource.PlayClipAtPoint(myClip, transform.position);
    }

    void Update()
    {
        
    }
}
