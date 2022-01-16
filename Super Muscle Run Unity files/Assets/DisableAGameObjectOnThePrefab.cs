using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableAGameObjectOnThePrefab : MonoBehaviour
{

    public GameObject objectToDisable;

    public void DisableTheObject()
    {
         objectToDisable.SetActive(false);
    }
}
