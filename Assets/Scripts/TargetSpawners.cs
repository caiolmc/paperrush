using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSpawners : MonoBehaviour
{
    public List<Transform> targetSpawners;
    public List<GameObject> targets;


    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < Random.Range(4, 7); i++)
        {
            SpawnTarget();
        }
    }

    private Transform SorteiaSpawner()
    {
        Transform spawn = targetSpawners[Random.Range(0,targetSpawners.Count)];
        targetSpawners.Remove(spawn);

        return spawn;
    }

    private GameObject SorteiaTarget()
    {
        return targets[Random.Range(0, targets.Count)];
    }

    private void SpawnTarget()
    {
        Rigidbody rb = SorteiaTarget().GetComponent<Rigidbody>();

        Rigidbody instance = Instantiate(rb, SorteiaSpawner());
    }


}
