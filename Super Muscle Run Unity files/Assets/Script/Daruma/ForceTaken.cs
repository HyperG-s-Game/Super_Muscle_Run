using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceTaken : MonoBehaviour
{
    Rigidbody rb;
    playerStrength playerStrengthScript;
    [SerializeField] int force;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        playerStrengthScript = FindObjectOfType<playerStrength>();       
    }

    private void Update()
    {
        force = playerStrengthScript.strenght;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
                rb.AddForce(transform.forward * force * 10 , ForceMode.Impulse);
        }
    }
}
