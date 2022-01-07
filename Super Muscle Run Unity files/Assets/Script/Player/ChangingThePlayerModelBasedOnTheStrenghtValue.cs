using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangingThePlayerModelBasedOnTheStrenghtValue : MonoBehaviour
{
    SwitchCharacterScript switchCharacterScript;

    int redCube = 0;
    int greenCube = 0;

    public int minRedCubeToChange = 3;
    public int minGreenCubeToChange = 3;

    private void Start()
    {
        switchCharacterScript = FindObjectOfType<SwitchCharacterScript>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "RedCube")
        {
            redCube++;
            if (redCube == minRedCubeToChange) 
            {
                print("triggered with red cube");
                switchCharacterScript.Fat();
                redCube = 0;
            }
            
        }
        if(other.tag == "GreenCube")
        {
            greenCube++;
            if(greenCube == minGreenCubeToChange)
            {
                print("triggered with green cube");
                switchCharacterScript.Muscle();
                greenCube = 0;
            }
            
        }
    }
}