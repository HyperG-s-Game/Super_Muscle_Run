using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyWall : MonoBehaviour
{
    public int minimumStrenghtValueToBreakTheWall = 3;
    public int strengthValueToDecreaseAfterDestroyingTheWall = 1;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (other.gameObject.GetComponent<playerStrength>().strenght >= minimumStrenghtValueToBreakTheWall)
            {
               
                other.gameObject.GetComponent<playerStrength>().strenght -= strengthValueToDecreaseAfterDestroyingTheWall;
                Destroy(gameObject);
            }
            else 
            {
                Destroy(other.gameObject,0.2f);

                //Restart the level
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            
            }
        }
    }
    
}
