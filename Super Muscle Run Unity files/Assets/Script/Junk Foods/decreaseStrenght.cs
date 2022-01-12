using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class decreaseStrenght : MonoBehaviour
{
    public int strengthValueToDecrease = 1;

    public MeshRenderer meshRenderer;

    public GameObject particleFX;

    private void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {   
            if(other.gameObject.GetComponent<playerStrength>().strenght > 0)
            {
                other.gameObject.GetComponent<playerStrength>().strenght -= strengthValueToDecrease;
            }
            meshRenderer.enabled = false;
            Instantiate(particleFX, transform.position, Quaternion.identity);
            Destroy(gameObject,1f);
        }
    }
}
