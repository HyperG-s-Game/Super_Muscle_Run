using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float jumpForce = 5f;
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
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            jumpAudio.Play();

        }
    }

}
