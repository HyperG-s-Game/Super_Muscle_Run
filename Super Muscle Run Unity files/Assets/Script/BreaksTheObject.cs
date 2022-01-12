using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreaksTheObject : MonoBehaviour
{
    public GameObject destroyedVersion;
    public GameObject player;
    public Animator animator;


    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        
    }
    private void Update()
    {
        if (player != null)
        {
            animator = player.GetComponentInChildren<Animator>();
        }
       
    }
    private void OnCollisionEnter(Collision collision)
    {
            if (collision.gameObject.tag == "Player")
            {
                animator.SetTrigger("punch");
                Instantiate(destroyedVersion, transform.position, Quaternion.identity);
            }
       
    }

  
}
