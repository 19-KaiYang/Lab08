using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnerscript : MonoBehaviour
{
    public GameObject SpawnObject;
    public GameObject SpawnBrownCube;
    public GameObject SpawnGreenCube;

    float PositionY;

    float RandomSpawner;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObjects", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
       


    }

    void SpawnObjects()
    {
        PositionY = Random.Range(4, -4f);
        RandomSpawner = Random.Range(1, 4);
        this.transform.position = new Vector3(transform.position.x, PositionY, transform.position.z);

        if(RandomSpawner == 1)
        {
            Instantiate(SpawnObject, transform.position, transform.rotation);
        }
        if (RandomSpawner == 2)
        {
            Instantiate(SpawnBrownCube, transform.position, transform.rotation);
        }
        if (RandomSpawner == 3)
        {
            Instantiate(SpawnGreenCube, transform.position, transform.rotation);
        }

    }
}
