using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class decreaseStrenght : MonoBehaviour
{
    public int strengthValueToDecrease = 1;
   
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {   
            if(other.gameObject.GetComponent<playerStrength>().strenght > 0)
            {
                other.gameObject.GetComponent<playerStrength>().strenght -= strengthValueToDecrease;
            }
            Destroy(gameObject);
        }
    }
}
