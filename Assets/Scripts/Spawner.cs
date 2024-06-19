using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject groundTile;
    Vector3 nextSpawnPoint;

    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            SpawnTile();
        }
        //InvokeRepeating("SpawnTile", 0, 0.5f);
    }

    public void SpawnTile()
    {
        GameObject temp = Instantiate(groundTile, nextSpawnPoint, Quaternion.identity);
        nextSpawnPoint = temp.transform.GetChild(1).transform.position;

    }

    //void SelfDestruct(GameObject temp)
    //{
    //    DestroyImmediate(temp, true);
    //}
}
