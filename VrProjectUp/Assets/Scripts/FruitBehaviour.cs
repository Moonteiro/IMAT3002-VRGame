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
    private int zPos;

    private Vector3 randomPos;

    private int iManyFruitInLevel;

    static public int iUIFruitPresent;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnFruit", spawnTime, spawnDelay);

        iManyFruitInLevel = Random.Range(10, 15);

        iUIFruitPresent = iManyFruitInLevel;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SpawnFruit()
    {
        if (iManyFruitInLevel != 0 && iUIFruitPresent == iUIFruitPresent)
        {
            xPos = Random.Range(-5, 5);
            zPos = Random.Range(-5, 5);
            randomPos = new Vector3(xPos, 10.0f, zPos);

            Instantiate(fruit, randomPos, transform.rotation);
            if (stopSpawn)
            {
                CancelInvoke("SpawnFruit");
            }

            iManyFruitInLevel -= 1;

            Debug.Log("I spawned!" + iUIFruitPresent);

        }

    }
}
