using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject fruit;
    public bool stopSpawn;
    public float spawnTime;
    public float spawnDelay;


    private float fTimer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SpawnFruit()
    {
        Instantiate(fruit, transform.position, transform.rotation);
        if (stopSpawn)
        {
            CancelInvoke("SpawnObject");
        }
    }
}
