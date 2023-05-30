using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Fruit")
        {

            Debug.Log("One fruit in");

            BasketGlobal.iFruitEnterGlobal += 1;

            Destroy(other, 1f);

        }

        
    }
}