using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2_Checkpoint2 : MonoBehaviour
{
    GameObject cube;
    GameObject button;
    GameObject person;
    bool used = false;
    // Start is called before the first frame update
    void Start()
    {
        cube = GameObject.Find("Checkpoint2"); //Имя платформы
        button = GameObject.Find("ButtonCheckpoint2"); //Имя кнопки
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
        if ((xCollider + 1 > xPerson) && (xCollider - 1 < xPerson) && (zCollider + 3.1 > zPerson) && (zCollider - 3.1 < zPerson) && !used && Input.GetKeyDown("e"))
        {
            button.GetComponent<Animation>().Play("Level2_ButtonCheckpoint2"); //Анимация нажатия кнопки
            used = true;
        }
        if (used && !cube.GetComponent<Animation>().isPlaying)
        {
            cube.GetComponent<Animation>().Play("Checkpoint2");
        }
    }
}