using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class UIHandler : MonoBehaviour
{

    public Text scoreText;

    private float fTimeLeft;
    private int iTimeLeft;
    private bool TimerActive;
    public Text TimerText;

    public void ExitGame()
    {
        Application.Quit();
    }

    public void LoadMenu()
    {
        Application.LoadLevel("Menu");
    }

    public void RestartMainGame()
    {
        Application.LoadLevel("MainGame");
    }

    void Start()
    {
        TimerActive = true;

        fTimeLeft = 150.0f;
    }

    void Update()
    {
        scoreText.text = BasketGlobal.iFruitEnterGlobal.ToString();

        TimerText.text = iTimeLeft.ToString();


        if(TimerActive)
        {
            if(fTimeLeft > 0)
            {
                fTimeLeft -= Time.deltaTime;
            }
            else
            {
                fTimeLeft = 0;
                TimerActive = false;
            }

            iTimeLeft = Mathf.RoundToInt(fTimeLeft);
        }


    }




}
