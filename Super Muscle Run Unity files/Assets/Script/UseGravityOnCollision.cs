using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseGravityOnCollision : MonoBehaviour
{
    public GameObject player;
    public Animator animator;

    DisableAGameObjectOnThePrefab disableAGameObjectOnThePrefabScript;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        disableAGameObjectOnThePrefabScript = FindObjectOfType<DisableAGameObjectOnThePrefab>();
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
        if(collision.gameObject.tag == "Player")
        {
            //trigger the PUNCH animation
            animator.SetTrigger("punch");
            player.GetComponent<PlayerMovement>().enabled = false;
            StartCoroutine(WaitAndUseGravity());
            
        }
        else if (collision.gameObject.tag == "Daruma")
        {
            gameObject.GetComponent<Rigidbody>().useGravity = true;
        }

    }

    IEnumerator WaitAndUseGravity()
    {
        yield return new WaitForSeconds(1f);
        disableAGameObjectOnThePrefabScript.DisableTheObject();
        gameObject.GetComponent<Rigidbody>().useGravity = true;
        gameObject.GetComponent<BoxCollider>().enabled = false;
        player.GetComponent<PlayerMovement>().enabled = true;
    }
}
