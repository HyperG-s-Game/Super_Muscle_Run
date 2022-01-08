using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseGravityOnCollision : MonoBehaviour
{
    public bool useGravity=false;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            gameObject.GetComponent<Rigidbody>().useGravity = true;
            useGravity = true;
        }
    }
}
