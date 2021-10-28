using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlinkoBallController : MonoBehaviour
{
    public float speed = 10f;
    public Rigidbody rb;

    private void Update()
    {
        GetControllers();
    }
    void GetControllers()
    {
        if (Input.GetKey(KeyCode.RightArrow))
            rb.AddForce(speed * Time.deltaTime, 0, 0, ForceMode.Impulse);
        if (Input.GetKey(KeyCode.LeftArrow))
            rb.AddForce(-speed * Time.deltaTime, 0, 0, ForceMode.Impulse);
        if (Input.GetKeyUp(KeyCode.Space))
        {
            rb.useGravity = true;
            gameObject.GetComponent<PlinkoBallController>().enabled = false;
        }
    }
}
