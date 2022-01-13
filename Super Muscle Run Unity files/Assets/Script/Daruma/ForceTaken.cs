using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceTaken : MonoBehaviour
{
    Rigidbody rb;
    playerStrength playerStrengthScript;
    [SerializeField] int force;
    GameFlow gameFlowScript;

    public GameObject player;
    public Animator animator;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        playerStrengthScript = FindObjectOfType<playerStrength>();
        gameFlowScript = FindObjectOfType<GameFlow>();
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        force = playerStrengthScript.strenght;

        if(player != null)
        {
            animator = player.GetComponentInChildren<Animator>();
        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            //trigger the PUNCH animation
            animator.SetTrigger("punch");

            StartCoroutine(WaitAndAddForce());

            collision.gameObject.GetComponent<PlayerMovement>().enabled = false;

            
        }
    }

    IEnumerator WaitAndAddForce()
    {
        yield return new WaitForSeconds(0.7f);
        rb.AddForce(transform.forward * force * 10, ForceMode.Impulse);

        //restart level 
        gameFlowScript.Restart();
    }
}
