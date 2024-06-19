using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundTile : MonoBehaviour
{

    Spawner groundSpawner;


    void Start()
    {
        groundSpawner = GameObject.FindObjectOfType<Spawner>();
    }


    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            groundSpawner.SpawnTile();
            Destroy(gameObject, 2);
        }

    }

}
