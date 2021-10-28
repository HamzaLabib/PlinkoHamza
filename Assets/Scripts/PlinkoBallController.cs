using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlinkoBallController : MonoBehaviour
{
    public float speed = 1f;
    public Collider myCollider;
    void GetControllers()
    {
        if (Input.GetKey(KeyCode.RightArrow))
            gameObject.GetComponent<Rigidbody>();
    }

}
