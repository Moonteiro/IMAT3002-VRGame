using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeBehaviour : MonoBehaviour
{

    public GameObject trees;

    private int xPos;
    private int zPos;

    private float xRot;
    private float zRot;

    private Vector3 randomPos;

    private Vector3 randomRot;

    private int iTrees;

    // Start is called before the first frame update
    void Start()
    {

        iTrees = 30;

        SpawnTrees();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void SpawnTrees()
    {

        for (int i = 0; i < iTrees; i++)
        {
            xPos = Random.Range(8, -8);
            zPos = Random.Range(8, -8);

            randomPos = new Vector3(xPos, 0f, zPos);

            xRot = Random.Range(0, 300);
            zRot = Random.Range(0, 300);

            randomRot = new Vector3(xRot, 0.0f, zRot);

            Instantiate(trees, randomPos, transform.rotation);
        }

    }
}
