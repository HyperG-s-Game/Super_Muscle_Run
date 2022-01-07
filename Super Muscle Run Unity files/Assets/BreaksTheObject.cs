using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreaksTheObject : MonoBehaviour
{
    public GameObject destroyedVersion;

   
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            gameObject.SetActive(false);
            Instantiate(destroyedVersion,transform.position,Quaternion.identity);

        }
    }
}
