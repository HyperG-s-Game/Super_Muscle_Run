using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyWall : MonoBehaviour
{
    public int minimumStrenghtValueToBreakTheWall = 3;
    public int strengthValueToDecreseAfterDestroyingTheWall = 1;
    GameFlow gameFlowScript;

    private void Start()
    {
        gameFlowScript = FindObjectOfType<GameFlow>();
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (other.gameObject.GetComponent<playerStrength>().strenght >= minimumStrenghtValueToBreakTheWall)
            {
               
                other.gameObject.GetComponent<playerStrength>().strenght -= strengthValueToDecreseAfterDestroyingTheWall;
                Destroy(gameObject);
            }
            else 
            {
                Destroy(other.gameObject,0.2f);

                //Restart the level
                gameFlowScript.Restart();
            }
        }
    }
    
}
