using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2_Door : MonoBehaviour
{
    GameObject door;
    GameObject button;
    GameObject person;
    bool used = false;
    // Start is called before the first frame update
    void Start()
    {
        door = GameObject.FindWithTag("SF_Door");
        button = GameObject.FindWithTag("Level2_Button");
        person = GameObject.Find("vThirdPersonCamera"); //Имя персонажа
    }

    // Update is called once per frame
    void Update()
    {
        Transform colliderTransform = button.GetComponent<BoxCollider>().transform;
        double xCollider = colliderTransform.position.x; //координата "x" - колайдера кнопки
        double zCollider = colliderTransform.position.z; //координата "z" - колайдера кнопки
        Transform personTransform = person.transform;
        double xPerson = personTransform.position.x; //координата "x" - персонажа
        double zPerson = personTransform.position.z; //координата "y" - персонажа
        if ((xCollider + 1.1 > xPerson) && (xCollider - 1.1 < xPerson) && (zCollider + 1 > zPerson) && (zCollider - 1 < zPerson) && !used && Input.GetKeyDown("e"))
        {
            button.GetComponent<Animation>().Play("Level2_PressButton"); //Анимация нажатия кнопки
            door.GetComponent<Animation>().Play("open"); //Анимация открытия двери
            used = true;
        }
    }
}