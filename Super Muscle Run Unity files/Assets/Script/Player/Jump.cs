using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float jumpForce = 3f;
    Rigidbody rb;

    public AudioSource jumpAudio;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
   
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Trampolin")
        {
            rb.AddForce(transform.up * jumpForce);
            jumpAudio.Play();

        }
    }
}
