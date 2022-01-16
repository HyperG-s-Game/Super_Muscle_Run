using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneColliionAtATime : MonoBehaviour
{
    CapsuleCollider cc;
    Rigidbody rb;

    [Header("Minimum should be 0.5")]
    public float waitingTimeToReEnableTheColliders = 0.5f;
    

    private void Start()
    {
        cc = GetComponent<CapsuleCollider>();
        rb = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "GreenCube" || other.gameObject.tag == "RedCube")
        {
            cc.enabled = false;
            rb.useGravity = false;
            StartCoroutine(WaitAndReset());
        }

    }



    IEnumerator WaitAndReset()
    {
        yield return new WaitForSeconds(waitingTimeToReEnableTheColliders);
        gameObject.GetComponent<CapsuleCollider>().enabled = true;
        gameObject.GetComponent<Rigidbody>().useGravity = true;
    }
}
