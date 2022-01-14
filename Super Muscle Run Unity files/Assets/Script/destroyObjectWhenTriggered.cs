using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyObjectWhenTriggered : MonoBehaviour
{
    public float destroyAfterSec;
    public GameObject destroyedParticle;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            //Virbration in Mobile
            Handheld.Vibrate();
            Debug.Log("Vibrate");
            Destroy(gameObject, destroyAfterSec);
            GameObject particles =  Instantiate(destroyedParticle, transform.position, transform.rotation);
            Destroy(particles, 2f);
        }
    }
}
