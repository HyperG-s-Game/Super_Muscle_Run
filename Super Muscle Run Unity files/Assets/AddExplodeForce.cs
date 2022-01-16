using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddExplodeForce : MonoBehaviour
{
    Rigidbody rb;

    public float force = 100f;
    public float explosionForce = 100f, explosionRadius = 10f;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        rb.AddExplosionForce(explosionForce, transform.position, explosionRadius);
        rb.AddForce(Vector3.forward * force , ForceMode.Impulse);
        StartCoroutine(WaitAndUnCheckTheCollier());
    }

    IEnumerator WaitAndUnCheckTheCollier()
    {
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
    }
}
