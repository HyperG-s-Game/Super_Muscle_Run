using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerStrength : MonoBehaviour
{
    public int strenght = 0;
    public Text strengthText;
    Rigidbody rb;
    public Image bar;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        strengthText.text = "Strenght : " + strenght.ToString();
        bar.fillAmount = (float)strenght / 10;

    }
   
 

    
}
