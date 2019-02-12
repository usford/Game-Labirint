using UnityEngine;
using System.Collections;

public class door : MonoBehaviour {
	GameObject thedoor;
    //public Transform mainDoor;
    //void OnTriggerEnter(Collider obj)
    //{
    //    thedoor = GameObject.FindWithTag("SF_Door");
    //    thedoor.GetComponent<Animation>().Play("open");
    //}

    //void OnTriggerExit(Collider obj)
    //{
    //    thedoor = GameObject.FindWithTag("SF_Door");
    //    thedoor.GetComponent<Animation>().Play("close");
    //}
    void OnTriggerStay(Collider obj)
    {
        thedoor = GameObject.FindWithTag("SF_Door");
        if (Input.GetKey("e") && thedoor.transform.position.y == -0.61899)
        {        
                thedoor.GetComponent<Animation>().Play("open");          
        }
    }
}