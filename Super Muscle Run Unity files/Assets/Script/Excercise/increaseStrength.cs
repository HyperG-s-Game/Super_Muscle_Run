using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class increaseStrength : MonoBehaviour
{
    public int strengthValueToIncrease = 1;

    public MeshRenderer meshRenderer;

   // public GameObject particleFX;

    private void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<playerStrength>().strenght += strengthValueToIncrease;
            meshRenderer.enabled = false;
            //GameObject particle =  Instantiate(particleFX, transform.position, Quaternion.identity);
            //Destroy(particle, 2f);
            Destroy(gameObject, 1f);
        }
    }
}
