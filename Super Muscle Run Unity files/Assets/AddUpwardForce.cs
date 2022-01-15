using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddUpwardForce : MonoBehaviour
{
    Rigidbody rb;
    AudioSource audi;

    public float upSpeed;

    public AudioClip audioClip;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        audi = GetComponent<AudioSource>();

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag =="Player")
        {
            rb.AddForce(Vector3.up * upSpeed * Time.deltaTime, ForceMode.Impulse);
            rb.AddTorque(Vector3.up * upSpeed);

            audi.PlayOneShot(audioClip);
        }
    }
}
