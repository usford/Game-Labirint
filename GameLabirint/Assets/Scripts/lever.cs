using System.Collections;
using UnityEngine;

public class lever : MonoBehaviour
{
    GameObject myLever;
    GameObject wall;
    private bool used = true;
    void Start()
    {
        myLever = GameObject.Find("lever");
        wall = GameObject.Find("SecretWall");
    }

    void OnTriggerStay()
    {

        if (Input.GetKeyDown("e") && used && wall.GetComponent<Animation>().isPlaying == false)
        {
            wall.GetComponent<Animation>().Play("SecretWall");
            myLever.GetComponent<Animation>().Play("leverDown");
            used = false;
        }
        else if (Input.GetKeyDown("e") && used == false && wall.GetComponent<Animation>().isPlaying == false)
        {
            wall.GetComponent<Animation>().Play("SecretWallBack");
            myLever.GetComponent<Animation>().Play("leverUp");
            used = true;
        }
    }
}
