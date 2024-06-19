using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneMovement : MonoBehaviour
{

    public static float speed = 15;
    public Rigidbody rb;

    float horizontalInput;
    float verticalInput;

    float velocidadeManobra = 2;

    public GameObject boost;
    public GameObject slow;

    private void FixedUpdate()
    {
        Vector3 forwardMove = rb.transform.forward * speed * Time.fixedDeltaTime;
        Vector3 horizontalMove = rb.transform.right * horizontalInput * speed * velocidadeManobra * Time.fixedDeltaTime;
        Vector3 verticalMove = rb.transform.up * verticalInput * speed * velocidadeManobra * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + forwardMove + horizontalMove + verticalMove);
    }

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        SpeedEffect();
    }

    void SpeedEffect()
    {
        if (speed > 15)
        {
            boost.SetActive(true);
        }
        else if (speed < 15)
        {
            slow.SetActive(true);
        }
        else
        {
            boost.SetActive(false);
            slow.SetActive(false);
        }
    }

}
