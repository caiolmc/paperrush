using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colisoes : MonoBehaviour
{
    public static bool fim = false;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            //Destroy(other.gameObject);
            //other.GetComponent<Rigidbody>().useGravity = true;
            other.GetComponent<PlaneMovement>().enabled = false;
            other.GetComponent<Rigidbody>().freezeRotation = false;
            StartCoroutine(Fim());
        }
    }

    IEnumerator Fim()
    {
        //Debug.Log("entrou");
        yield return new WaitForSeconds(0.5f);
        fim = true;
        //Debug.Log(fim);
    }
}
