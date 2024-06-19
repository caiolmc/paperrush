using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetEffect : MonoBehaviour
{
    public AudioSource source;

    int count = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            DesligaColisores();

            if (this.tag == "Boost" && count == 0)
            {
                source.Play();
                StartCoroutine(Boost());
            }
            else if (this.tag == "Slow" && count == 0)
            {
                source.Play();
                StartCoroutine(Slow());
            }
            else if (this.tag == "Double" && count == 0)
            {
                source.Play();
                Double();
            }
            else if (this.tag == "Points" && count == 0)
            {
                source.Play();
                Points();
            }
            //else if (this.tag == "Star")
            //{
            //    Points();
            //}

            count++;
        }

    }

    void DesligaColisores()
    {
        if (this.gameObject.GetComponent<SphereCollider>() != null)
        {
            this.gameObject.GetComponent<SphereCollider>().enabled = false;
        }
        if (this.gameObject.GetComponent<BoxCollider>() != null)
        {
            this.gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    }

    public void Points()
    {
        //Debug.Log("points");

        GameManager.givePoints(false);

        this.gameObject.GetComponent<MeshRenderer>().enabled = false;
        //Destroy(this.gameObject);
    }

    public void Double()
    {
        //Debug.Log("double");

        GameManager.givePoints(true);

        this.gameObject.GetComponent<MeshRenderer>().enabled = false;
        //Destroy(this.gameObject);
    }


    IEnumerator Slow()
    {
        //Debug.Log("slow");

        if(PlaneMovement.speed > 7)
        PlaneMovement.speed -= 6;

        yield return new WaitForSeconds(3);

        PlaneMovement.speed = 15;

    }


    IEnumerator Boost()
    {
        //Debug.Log("boost");

        if(PlaneMovement.speed < 25)
        {
            PlaneMovement.speed += 8;
        }

        yield return new WaitForSeconds(3);

        PlaneMovement.speed = 15;

    }
}
