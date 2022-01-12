using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killPlayer : MonoBehaviour
{
    GameFlow gameFlowScript;

    private void Start()
    {
        gameFlowScript = FindObjectOfType<GameFlow>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            //death animation
            Destroy(collision.gameObject);
            //restart the level
            gameFlowScript.Restart();
        }
    }
}
