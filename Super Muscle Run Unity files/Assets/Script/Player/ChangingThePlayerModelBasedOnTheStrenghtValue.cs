using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangingThePlayerModelBasedOnTheStrenghtValue : MonoBehaviour
{
    SwitchCharacterScript switchCharacterScript;

    int redCube = 0;
    int greenCube = 0;

    public int minimumRedCubeToChange = 3;
    public int minimumGreenCubeToChange = 3;

    public GameObject particleEffectForChaningTheModel;

    private void Start()
    {
        switchCharacterScript = FindObjectOfType<SwitchCharacterScript>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "RedCube")
        {
            redCube++;
            if (redCube == minimumRedCubeToChange) 
            {
                print("triggered with red cube");
                GameObject particle = Instantiate(particleEffectForChaningTheModel, transform.position, transform.rotation);
                switchCharacterScript.Fat();
                redCube = 0;
                Destroy(particle, 1f);
            }
            
        }
        if(other.tag == "GreenCube")
        {
            greenCube++;
            if(greenCube == minimumGreenCubeToChange)
            {
                print("triggered with green cube");
                GameObject particle = Instantiate(particleEffectForChaningTheModel, transform.position, transform.rotation);
                switchCharacterScript.Muscle();
                greenCube = 0;
                Destroy(particle, 1f);
            }
            
        }
    }
}
