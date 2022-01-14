using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseGravityOnCollision : MonoBehaviour
{
    
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player" || collision.gameObject.tag == "Daruma")
        {
            gameObject.GetComponent<Rigidbody>().useGravity = true;
            
        }

    }
}
