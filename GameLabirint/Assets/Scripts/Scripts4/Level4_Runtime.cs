using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Level4_Runtime : MonoBehaviour
{
    public Text CurrentTime;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("TimerTick", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void TimerTick()
    {
        if (CurrentTime.text != "Время истекло!")
        {
            string sub = CurrentTime.text.Substring(18, CurrentTime.text.Length - 18);
            if (CurrentTime.text != "Времени осталось: 0")
                CurrentTime.text = "Времени осталось: " + (Convert.ToInt32(sub) - 1).ToString();
            else
                CurrentTime.text = "Время истекло!";
        }
        else
        {
            System.Threading.Thread.Sleep(3000);
            SceneManager.LoadScene("level4");
        }
    }
}