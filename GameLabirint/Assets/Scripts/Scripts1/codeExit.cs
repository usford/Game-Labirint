using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class codeExit : MonoBehaviour
{
    public Text txtError;
    public GameObject panelE;
    public InputField inputE;
    void Start()
    {
    }


    public void press()
    {
        panelE.SetActive(false);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        inputE.text = "";   
        txtError.enabled = false;
        GameObject.Find("vThirdPersonController").GetComponent<vThirdPersonCamera>().lockCamera = false;
        //GameObject.Find("vThirdPersonCamera").GetComponent<Invector.CharacterController.vThirdPersonController>().lockMovement = false;
    }
}
