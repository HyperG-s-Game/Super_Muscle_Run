using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForwardForce : MonoBehaviour
{
    Rigidbody rb;
    public float forwardForce = 100f;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            rb.AddForce(Vector3.forward * forwardForce, ForceMode.Impulse);
        }
    }
}
