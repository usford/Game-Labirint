using UnityEngine;
using System.Collections;

public class door : MonoBehaviour {
	GameObject thedoor;
    GameObject btn;
    private bool used = true;

    void Start()
    {
        thedoor = GameObject.FindWithTag("SF_Door");
        btn = GameObject.FindWithTag("btnPress");
    }

    void OnTriggerStay()
    {
        
        if (Input.GetKeyDown("e") && used && thedoor.GetComponent<Animation>().isPlaying == false)
        {
            thedoor.GetComponent<Animation>().Play("open");
            btn.GetComponent<Animation>().Play("pressBtn1");
            used = false;
        }else if (Input.GetKeyDown("e") && used == false && thedoor.GetComponent<Animation>().isPlaying == false)
        {
            thedoor.GetComponent<Animation>().Play("close");
            btn.GetComponent<Animation>().Play("pressBtn1");
            used = true;
        }
    }
}
