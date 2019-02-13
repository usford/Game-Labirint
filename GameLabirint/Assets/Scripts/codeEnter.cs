using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class codeEnter : MonoBehaviour
{
    public Text txtError;
    GameObject thedoor;
    GameObject puzzleCube2;
    public string password;
    public GameObject panelE;
    public InputField inputE;
    private bool puzzle2 = true;
    void Start()
    {
        thedoor = GameObject.Find("door1");
        puzzleCube2 = GameObject.Find("cubePuzzle2");
    }

    public void press()
    {
        if (inputE.text == "1234")
        {
            puzzleCube2.GetComponent<Animation>().Play("cubePuzzle2");
            puzzle2 = false;
        }
        if (inputE.text == password)
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            thedoor.GetComponent<Animation>().Play("open");
            panelE.SetActive(false);
            txtError.enabled = false;
            GameObject.Find("vThirdPersonController").GetComponent<vThirdPersonCamera>().lockCamera = false;
            GameObject.Find("vThirdPersonCamera").GetComponent<Invector.CharacterController.vThirdPersonController>().lockMovement = false;
        }
        else
        {
            txtError.enabled = true;
        }
    }
}
