using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class BasketGlobal : MonoBehaviour
{
    private int iFruitEnter;
    static public int iFruitEnterGlobal;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        iFruitEnter = iFruitEnterGlobal;

        if (iFruitEnterGlobal == FruitBehaviour.iUIFruitPresent)
        {
            SceneManager.LoadScene("Menu");

            iFruitEnterGlobal = 0;


        }

    }


}
