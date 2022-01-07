using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "GymCycle")
        {
            //Play gymCycle Animation
        }

        if (other.gameObject.tag == "Rod")
        {
            //Play rod Animation
        }

        if (other.gameObject.tag == "Ladder")
        {
            //Play Ladder Animation
        }

    }
}
