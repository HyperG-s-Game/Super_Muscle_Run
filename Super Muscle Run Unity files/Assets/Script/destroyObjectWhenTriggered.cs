using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyObjectWhenTriggered : MonoBehaviour
{
    public float destroyAfterSec;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Destroy(gameObject, destroyAfterSec);
        }
    }
}
