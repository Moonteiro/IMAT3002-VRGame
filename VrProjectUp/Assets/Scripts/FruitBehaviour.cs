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

    private int xPos;
    private int yPos;
    private int zPos;

    private Vector3 randomPos;

    private float fTimer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnFruit", spawnTime, spawnDelay);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SpawnFruit()
    {

        xPos = Random.Range(-5, 5);
        yPos = 10;
        zPos = Random.Range(-5, 5);
        randomPos = new Vector3(xPos, yPos, zPos);

        Instantiate(fruit, randomPos, transform.rotation);
        if (stopSpawn)
        {
            CancelInvoke("SpawnFruit");
        }
    }
}
