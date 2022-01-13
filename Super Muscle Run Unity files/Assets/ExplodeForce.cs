using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodeForce : MonoBehaviour
{
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        rb.AddTorque(new Vector3(360f, 360f, 360f));
        rb.AddExplosionForce(1, transform.position, 1);
    }

}
