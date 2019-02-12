using UnityEngine;
using System.Collections;

public class door : MonoBehaviour {
	GameObject thedoor;
    GameObject btn;
    private bool used = true;

    void Update()
    {
        thedoor = GameObject.FindWithTag("SF_Door");
        btn = GameObject.FindWithTag("btnPress");
        if (Input.GetKeyDown("e") && used && thedoor.GetComponent<Animation>().isPlaying == false)
        {
            thedoor.GetComponent<Animation>().Play("open");
            btn.GetComponent<Animation>().Play("press");
            used = false;
        }else if (Input.GetKeyDown("e") && used == false && thedoor.GetComponent<Animation>().isPlaying == false)
        {
            thedoor.GetComponent<Animation>().Play("close");
            btn.GetComponent<Animation>().Play("press");
            used = true;
        }
    }
}
