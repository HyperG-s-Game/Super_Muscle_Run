using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class increaseStrength : MonoBehaviour
{
    public int strengthValueToIncrease = 1;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<playerStrength>().strenght += strengthValueToIncrease;
            Destroy(gameObject);
        }
    }
}
