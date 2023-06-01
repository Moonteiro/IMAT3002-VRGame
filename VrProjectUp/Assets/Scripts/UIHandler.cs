using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
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
        SceneManager.LoadScene("Menu");
    }

    public void RestartMainGame()
    {
        BasketGlobal.iFruitEnterGlobal = 0;

        SceneManager.LoadScene("MainGame");
    }

    void Start()
    {
        TimerActive = true;

        fTimeLeft = 150.0f;
    }

    void Update()
    {
        scoreText.text = "Score:" + BasketGlobal.iFruitEnterGlobal.ToString() + "/" + FruitBehaviour.iUIFruitPresent;

        TimerText.text = "Time left: " + iTimeLeft.ToString();


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

                BasketGlobal.iFruitEnterGlobal = 0;

                SceneManager.LoadScene("Menu");
            }

            iTimeLeft = Mathf.RoundToInt(fTimeLeft);
        }


    }




}
