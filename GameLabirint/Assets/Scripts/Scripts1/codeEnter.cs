using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class codeEnter : MonoBehaviour
{
    public Text txtError;
    GameObject thedoor;
    GameObject puzzleCube2;
    Button buttonEnter;
    public string password;
    public GameObject panelE;
    public InputField inputE;
    private bool puzzle2 = true;
    public bool pass = false;
    void Start()
    {
        thedoor = GameObject.Find("door1");
        puzzleCube2 = GameObject.Find("cubePuzzle2");
    }

    public void press()
    {
        //1 - ответ на загадку
        //5 - фигура, где 5/2
        //4 - кол-во туалетных бумаг
        //6 - кол-во железных хреней
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
            //GameObject.Find("vThirdPersonCamera").GetComponent<Invector.CharacterController.vThirdPersonController>().lockMovement = false;
            inputE.enabled = false;
            pass = true;
        }
        else
        {
            txtError.enabled = true;
        }
    }
}
