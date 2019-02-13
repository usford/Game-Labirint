using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class door1 : MonoBehaviour
{
    public Text txtError;
    GameObject thedoor;
    GameObject btn;
    private bool used = true;

    public GameObject panelE;
    public InputField inputE;

    void Start()
    {
        thedoor = GameObject.Find("door1");
        btn = GameObject.Find("button2");
        panelE.SetActive(false);
        txtError.enabled = false;
    }

    void OnTriggerStay()
    {    
        if (Input.GetKeyDown("e") && used && thedoor.GetComponent<Animation>().isPlaying == false)
        {
            GameObject.Find("vThirdPersonController").GetComponent<vThirdPersonCamera>().lockCamera = true;
            GameObject.Find("vThirdPersonCamera").GetComponent<Invector.CharacterController.vThirdPersonController>().lockMovement = true;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            panelE.SetActive(true);          
            //thedoor.GetComponent<Animation>().Play("open");
            //used = false;
        }
    }

    void OnTriggerEnter()
    {
        inputE.text = "";
    }
    void OnTriggerExit()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        panelE.SetActive(false);
        txtError.enabled = false;
    }
}
