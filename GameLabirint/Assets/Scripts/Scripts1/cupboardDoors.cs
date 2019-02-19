using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cupboardDoors : MonoBehaviour
{
    private bool used = true;
    GameObject cupboard;
    void Start()
    {
        cupboard = GameObject.Find("RFAIPP_Kitchen_Cabinet_Down");
    }

    void OnTriggerStay()
    {
        if (Input.GetKeyDown("e") && used && cupboard.GetComponent<Animation>().isPlaying == false)
        {
            cupboard.GetComponent<Animation>().Play("OpenDoors");
            used = false;
        }else if (Input.GetKeyDown("e") && used == false && cupboard.GetComponent<Animation>().isPlaying == false)
        {
            cupboard.GetComponent<Animation>().Play("CloseDoors");
            used = true;
        }
    }

}
